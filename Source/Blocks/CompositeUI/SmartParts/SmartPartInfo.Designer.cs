//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================


using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using System;
using System.CodeDom;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	[DesignerCategory("Code")]
	[ToolboxBitmap(typeof(SmartPartInfo), "SmartPartInfo")]
	//[Designer(typeof(SmartPartInfo.SmartPartInfoDesigner), typeof(IDesigner))]
	[DesignerSerializer(typeof(SmartPartInfo.SmartPartInfoDesignerSerializer), typeof(CodeDomSerializer))]
	public partial class SmartPartInfo : Component
	{
		/// <summary>
		/// Adds the SmartPart property to the smart part info at design-time.
		/// </summary>
		private class SmartPartInfoDesigner : ComponentDesigner
		{
			private string smartPart;

			protected override void PreFilterProperties(IDictionary properties)
			{
				IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
				if (host.RootComponent is WorkItem)
				{
					properties.Add("SmartPart", TypeDescriptor.GetProperties(this)["SmartPart"]);
				}
			}

			[Description("The smart part this information object describes.")]
			[Category("Behavior")]
			[TypeConverter(typeof(SmartPartConverter))]
			[DesignOnly(true)]
			[DefaultValue(null)]
			public string SmartPart
			{
				get { return smartPart; }
				set { smartPart = value; }
			}
		}

		/// <summary>
		/// Provides a list of the smartparts in the current workitem to select from.
		/// </summary>
		private class SmartPartConverter : TypeConverter
		{
			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return true;
			}

			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return true;
			}

			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				List<string> smartParts = new List<string>();
				foreach (IComponent component in context.Container.Components)
				{
					// Only add those components that have the SmartPart attribute defined, 
					// which are the only ones we care to call RegisterSPI with.
					if (Attribute.IsDefined(component.GetType(), typeof(SmartPartAttribute)))
					{
						smartParts.Add(component.Site.Name);
					}
				}

				return new StandardValuesCollection(smartParts);
			}
		}

		/// <summary>
		/// Provides custom serialization to register the SPI with the WorkItem.
		/// </summary>
		private class SmartPartInfoDesignerSerializer : DesignerCodeDomSerializer
		{
			const string GetSmartPartInfoMethod = "GetSmartPartInfo";
			const string AddSmartPartInfosMethod = "AddSmartPartInfos";
			const string ProviderField = "infoProvider";

			public override object Serialize(IDesignerSerializationManager manager, object value)
			{
				// Get the original CodeDom as emitted by the built-in component serializer.
				CodeDomSerializer baseSerializer =
					(CodeDomSerializer)manager.GetSerializer(typeof(Component), typeof(CodeDomSerializer));
				CodeStatementCollection statements = (CodeStatementCollection)baseSerializer.Serialize(manager, value);

				IDesignerHost host = (IDesignerHost)manager.GetService(typeof(IDesignerHost));

				if (host.RootComponent is WorkItem)
				{
					//GenerateWorkItemCode(manager, value, statements);
				}
				else
				{
					GenerateSmartPartCode(manager, value, statements);
				}

				return statements;
			}

			public override object Deserialize(IDesignerSerializationManager manager, object codeObject)
			{
				CodeTypeDeclaration declaration = (CodeTypeDeclaration)manager.GetService(typeof(CodeTypeDeclaration));
				CodeStatementCollection statements = codeObject as CodeStatementCollection;

				if (statements != null)
				{
					// Before deserialization, remove statements we added.
					RemoveFromStatements<CodeMethodInvokeExpression>(statements,
						delegate(CodeMethodInvokeExpression invoke)
						{
							CodePropertyReferenceExpression propref = invoke.Method.TargetObject as CodePropertyReferenceExpression;
							if (propref != null)
							{
								CodeFieldReferenceExpression fieldref = propref.TargetObject as CodeFieldReferenceExpression;
								return fieldref.FieldName == ProviderField && 
									fieldref.TargetObject is CodeThisReferenceExpression;
							}

							return false;
						});

					CodeMemberField providerField = FindMember<CodeMemberField>(declaration, ProviderField);
					if (providerField != null)
					{
						declaration.Members.Remove(providerField);
					}
				}

				return base.Deserialize(manager, codeObject);
			}

			#region Serialize helpers

			private static void GenerateSmartPartCode(IDesignerSerializationManager manager, object value, CodeStatementCollection statements)
			{
				IDesignerHost host = (IDesignerHost)manager.GetService(typeof(IDesignerHost));
				CodeTypeDeclaration declaration = (CodeTypeDeclaration)manager.GetService(typeof(CodeTypeDeclaration));

				if (host.Container.Components[ProviderField] == null)
				{
					IComponent provider = host.CreateComponent(typeof(SmartPartInfoProvider), ProviderField);
					host.Container.Add(provider, ProviderField);
				}

				// Make sure this will break a test if we modify the ISmartPartInfoProvider interface.
				MethodInfo interfaceMethod = typeof(ISmartPartInfoProvider).GetMethod(GetSmartPartInfoMethod);
				Debug.Assert(interfaceMethod != null, "ISmartPartInfoProvider interface definition changed. GetSmartPartInfo method not found.");
				
				CodeMemberMethod getInfo = FindMember<CodeMemberMethod>(declaration, GetSmartPartInfoMethod);
				if (getInfo == null)
				{
					getInfo = GenerateGetSmartPartInfo(interfaceMethod);
					declaration.Members.Add(getInfo);
				}

				AddToProvider(manager, value, statements);
			}

			private static void AddToProvider(IDesignerSerializationManager manager, object value, CodeStatementCollection statements)
			{
				IReferenceService refsvc = (IReferenceService)manager.GetService(typeof(IReferenceService));

				// this.infoProvider.Items.Add(component);
				statements.Add(
					new CodeMethodInvokeExpression(
						new CodePropertyReferenceExpression(
							new CodeFieldReferenceExpression(
								new CodeThisReferenceExpression(),
								ProviderField),
							"Items"),
						"Add",
						new CodeFieldReferenceExpression(
							new CodeThisReferenceExpression(),
							refsvc.GetName(value))));
			}

			private static CodeMemberMethod GenerateGetSmartPartInfo(MethodInfo interfaceMethod)
			{
				// ISmartPartInfoProvider.GetSmartPartInfo signature:
				// public ISmartPartInfo GetSmartPartInfo(Type smartPartInfoType)
				CodeMemberMethod methodImpl = new CodeMemberMethod();
				methodImpl.Attributes = MemberAttributes.Public;
				methodImpl.Comments.Add(new CodeCommentStatement("<summary>Generated by a designer. Required inmplementation of ISmartPartInfoProvider"));

				GenerateCastForInterface(methodImpl);

				methodImpl.Name = interfaceMethod.Name;
				methodImpl.ReturnType = new CodeTypeReference(interfaceMethod.ReturnType);
				List<CodeExpression> parameters = new List<CodeExpression>();

				foreach (ParameterInfo parameter in interfaceMethod.GetParameters())
				{
					methodImpl.Parameters.Add(new CodeParameterDeclarationExpression(
						parameter.ParameterType, parameter.Name));
					parameters.Add(new CodeArgumentReferenceExpression(parameter.Name));
				}

				// return this.infoProvider.GetSmartPartInfo(SmartPartInfoType);
				CodeMethodInvokeExpression invoke = new CodeMethodInvokeExpression(
					new CodeFieldReferenceExpression(
						new CodeThisReferenceExpression(),
							ProviderField),
							interfaceMethod.Name,
							parameters.ToArray());

				methodImpl.Statements.Add(new CodeMethodReturnStatement(invoke));

				return methodImpl;
			}

			private static void GenerateCastForInterface(CodeMemberMethod methodImpl)
			{
				methodImpl.Statements.Add(new CodeCommentStatement(Properties.Resources.SmartPartMustImplementISmartPartInfoProvider));
				// ISmartPartInfoProvider ensureProvider = (ISmartPartInfoProvider)this;
				methodImpl.Statements.Add(
					new CodeVariableDeclarationStatement(
						typeof(ISmartPartInfoProvider), "ensureProvider",
						new CodeThisReferenceExpression()
					)
				);

			}

			private static void GenerateWorkItemCode(IDesignerSerializationManager manager, object value, CodeStatementCollection statements)
			{
				// See if there's a smartpart assigned at designtime.
				string smartPart = (string)TypeDescriptor.GetProperties(value)["SmartPart"].GetValue(value);
				if (smartPart != null)
				{
					// Add the registration information to it.
					CodeMethodInvokeExpression registerSP = new CodeMethodInvokeExpression(
						new CodeMethodReferenceExpression(
							new CodeBaseReferenceExpression(),
							"RegisterSmartPartInfo"),
						new CodeFieldReferenceExpression(
							new CodeThisReferenceExpression(),
							smartPart),
						new CodeFieldReferenceExpression(
							new CodeThisReferenceExpression(),
							manager.GetName(value)));
					statements.Add(registerSP);
				}
			}

			#endregion
		}
	}
}
