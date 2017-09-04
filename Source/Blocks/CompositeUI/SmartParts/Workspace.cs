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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Microsoft.Practices.CompositeUI.Utility;
using System.ComponentModel;

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	/// <summary>
	/// Default base implementation of the <see cref="IWorkspace"/> interface.
	/// </summary>
	/// <remarks>
	/// Implements the common behavior for Workspaces, which includes activating the smart part 
	/// when it is shown, retrieving registered <see cref="ISmartPartInfo"/> components from the 
	/// <see cref="WorkItem"/>, and raising the 
	/// appropriate events when needed.
	/// </remarks>
	/// <typeparam name="TSmartPart">Type of smart parts that the workspace manages.</typeparam>
	/// <typeparam name="TSmartPartInfo">Type of smart part information used by the workspace. 
	/// Must implement <see cref="ISmartPartInfo"/>.</typeparam>
	public abstract class Workspace<TSmartPart, TSmartPartInfo> : IWorkspace
		where TSmartPartInfo : ISmartPartInfo, new()
	{
		private WorkItem workItem;
		private object activeSmartPart;
		private List<TSmartPart> smartParts = new List<TSmartPart>();

		/// <summary>
		/// Dependency injection setter property to get the <see cref="WorkItem"/> where the 
		/// object is contained.
		/// </summary>
		[ServiceDependency]
		public WorkItem WorkItem
		{
			set { workItem = value; }
		}

		#region IWorkspace Members

		/// <summary>
		/// See <see cref="IWorkspace.SmartPartClosing"/>.
		/// </summary>
		public event EventHandler<WorkspaceCancelEventArgs> SmartPartClosing;

		/// <summary>
		/// See <see cref="IWorkspace.SmartPartActivated"/>.
		/// </summary>
		public event EventHandler<WorkspaceEventArgs> SmartPartActivated;

		/// <summary>
		/// The active smart part in the Workspace, or <c>null</c> (<c>Nothing</c> in VB.NET).
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public object ActiveSmartPart
		{
			get { return activeSmartPart; }
		}

		/// <summary>
		/// Allows a derived class to set the Active SmartPart in the Workspace
		/// </summary>
		/// <remarks>
		/// If a derived class is directly setting the value, it must be 
		/// of a supported type, and must have been shown previously.
		/// </remarks>
		/// <param name="value">The SmartPart is set as the <see cref="ActiveSmartPart"/></param>
		protected void SetActiveSmartPart(object value)
		{
			if (value != null)
			{
				ThrowIfUnsupportedSP(value);
				ThrowIfSmartPartNotShownPreviously((TSmartPart)value);
			}
			activeSmartPart = value;
		}


		/// <summary>
		/// The collection of smart parts contained in the workspace.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ReadOnlyCollection<object> SmartParts
		{
			get
			{
				return new ReadOnlyCollection<object>(smartParts.ConvertAll<object>(
					delegate(TSmartPart smartPart)
					{
						return (object)smartPart;
					}));
			}
		}

		/// <summary>
		/// Activates the smartPart on the workspace.
		/// </summary>
		/// <param name="smartPart">The smart part to activate.</param>
		/// <exception cref="ArgumentException">The smartPart
		/// was not previously shown in the workspace.</exception>
		/// <exception cref="ArgumentException">The smartPart cannot be 
		/// assigned to TSmartPart.</exception>
		/// <remarks>
		/// <see cref="OnActivate"/> and <see cref="SmartPartActivated"/> 
		/// wil only be called if the smartPart is different than the 
		/// <see cref="ActiveSmartPart"/>.
		/// </remarks>
		public void Activate(object smartPart)
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");
			ThrowIfUnsupportedSP(smartPart);
			ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);

			if (activeSmartPart != smartPart)
			{
				OnActivate((TSmartPart)smartPart);
				activeSmartPart = smartPart;
				RaiseSmartPartActivated(smartPart);
			}
		}

		/// <summary>
		/// Applies the smartPartInfo to the smartPart.
		/// </summary>
		/// <exception cref="ArgumentException">The smartPart
		/// was not previously shown in the workspace.</exception>
		/// <exception cref="ArgumentException">The smartPart cannot be 
		/// assigned to TSmartPart.</exception>
		/// <remarks>
		/// Applying the smartPartInfo does not cause automatic activation 
		/// of the smartPart.
		/// </remarks>
		public void ApplySmartPartInfo(object smartPart, ISmartPartInfo smartPartInfo)
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");
			Guard.ArgumentNotNull(smartPartInfo, "smartPartInfo");
			ThrowIfUnsupportedSP(smartPart);
			ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);

			TSmartPartInfo typedInfo = GetSupportedSPI(smartPartInfo);

			OnApplySmartPartInfo((TSmartPart)smartPart, typedInfo);
		}

		/// <summary>
		/// Shows SmartPart using the given <see cref="ISmartPartInfo"/>.
		/// </summary>
		/// <exception cref="ArgumentException">The smartPart cannot be 
		/// assigned to TSmartPart.</exception>
		/// <remarks>
		/// If the smartPart was previously shown, 
		/// <see cref="ApplySmartPartInfo"/> and <see cref="Activate"/> will be called. 
		/// Otherwise, <see cref="OnShow"/> is called.
		/// </remarks>
		public void Show(object smartPart, ISmartPartInfo smartPartInfo)
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");
			Guard.ArgumentNotNull(smartPartInfo, "smartPartInfo");
			ThrowIfUnsupportedSP(smartPart);

			TSmartPartInfo typedInfo = GetSupportedSPI(smartPartInfo);
			TSmartPart typedSmartPart = (TSmartPart)smartPart;

			if (smartParts.Contains(typedSmartPart))
			{
				ApplySmartPartInfo(smartPart, smartPartInfo);
				Activate(smartPart);
			}
			else
			{
				smartParts.Add(typedSmartPart);
				OnShow(typedSmartPart, typedInfo);
			}
		}

		/// <summary>
		/// Locates an appropriate <see cref="ISmartPartInfo"/> compatible with the type 
		/// TSmartPartInfo, and calls <see cref="Show(object, ISmartPartInfo)"/>.
		/// </summary>
		/// <exception cref="ArgumentException">The smartPart cannot be 
		/// assigned to TSmartPart.</exception>
		/// <remarks>
		/// If <see cref="WorkItem"/> is not null, <see cref="Microsoft.Practices.CompositeUI.WorkItem.GetSmartPartInfo{TSmartPartInfo}(object)"/> will 
		/// be called for the TSmartPartInfo concrete type. If no value is returned, 
		/// it will be called again for a generic <see cref="SmartPartInfo"/>. Finally, if no generic info 
		/// is registered either, a new default instance of the TSmartPartInfo will 
		/// be used by calling the <see cref="CreateDefaultSmartPartInfo"/> method and finally passed to 
		/// the <see cref="Show(object, ISmartPartInfo)"/> overload.
		/// </remarks>
		public void Show(object smartPart)
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");
			ThrowIfUnsupportedSP(smartPart);

			TSmartPart typedSmartPart = (TSmartPart)smartPart;

			// Behavior is slightly different than the other overload, as we don't want to 
			// reapply the SPI in this case.
			if (smartParts.Contains(typedSmartPart))
			{
				Activate(smartPart);
			}
			else
			{
				ISmartPartInfo info = null;
				ISmartPartInfoProvider provider = smartPart as ISmartPartInfoProvider;

				if (workItem != null)
				{
					info = workItem.GetSmartPartInfo<TSmartPartInfo>(smartPart);
					if (info == null && provider != null)
					{
						info = provider.GetSmartPartInfo(typeof(TSmartPartInfo));
					}
					if (info == null)
					{
						info = workItem.GetSmartPartInfo<SmartPartInfo>(smartPart);
					}
					if (info == null && provider != null)
					{
						info = provider.GetSmartPartInfo(typeof(SmartPartInfo));
					}
				}
				else if (provider != null)
				{
					info = provider.GetSmartPartInfo(typeof(TSmartPartInfo));
					if (info == null)
					{
						info = provider.GetSmartPartInfo(typeof(SmartPartInfo));
					}
				}

				if (info == null)
				{
					info = CreateDefaultSmartPartInfo(typedSmartPart);
				}

				Show(typedSmartPart, info);
			}
		}

		/// <summary>
		/// Hides the smart part and resets (sets to null) the <see cref="ActiveSmartPart"/>.
		/// </summary>
		/// <exception cref="ArgumentException">The smartPart
		/// was not previously shown in the workspace.</exception>
		/// <exception cref="ArgumentException">The smartPart cannot be 
		/// assigned to TSmartPart.</exception>
		public void Hide(object smartPart)
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");
			ThrowIfUnsupportedSP(smartPart);
			ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);

			if (activeSmartPart == smartPart) activeSmartPart = null;
			OnHide((TSmartPart)smartPart);
		}

		/// <summary>
		/// Closes the smart part and resets (sets to null) the <see cref="ActiveSmartPart"/>.
		/// </summary>
		/// <exception cref="ArgumentException">The smartPart
		/// was not previously shown in the workspace.</exception>
		/// <exception cref="ArgumentException">The smartPart cannot be 
		/// assigned to TSmartPart.</exception>
		public void Close(object smartPart)
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");
			ThrowIfUnsupportedSP(smartPart);
			ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);

			WorkspaceCancelEventArgs cancelArgs = RaiseSmartPartClosing(smartPart);
			if (cancelArgs.Cancel == false)
			{
				CloseInternal((TSmartPart)smartPart);
			}
		}

		#endregion

		#region Private methods

		private TSmartPartInfo GetSupportedSPI(ISmartPartInfo smartPartInfo)
		{
			if (typeof(TSmartPartInfo).IsAssignableFrom(smartPartInfo.GetType()) == false)
			{
				return ConvertFrom(smartPartInfo);
			}
			else
			{
				return (TSmartPartInfo)smartPartInfo;
			}
		}

		private void ThrowIfUnsupportedSP(object smartPart)
		{
			if (typeof(TSmartPart).IsAssignableFrom(smartPart.GetType()) == false)
			{
				throw new ArgumentException(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.UnsupportedSmartPartType,
					smartPart.GetType(), typeof(TSmartPart)), "smartPart");
			}
		}

		private void ThrowIfSmartPartNotShownPreviously(TSmartPart smartPart)
		{
			if (smartParts.Contains(smartPart) == false)
			{
				throw new ArgumentException(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.SmartPartNotInWorkspace,
					smartPart, this));
			}
		}

		/// <summary>
		/// Raises the <see cref="SmartPartActivated"/> event.
		/// </summary>
		/// <param name="smartPart">The smart part that was activated.</param>
		protected void RaiseSmartPartActivated(object smartPart)
		{
			if (this.SmartPartActivated != null)
			{
				WorkspaceEventArgs args = new WorkspaceEventArgs(smartPart);
				this.SmartPartActivated(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="SmartPartClosing"/> event.
		/// </summary>
		/// <param name="smartPart">The smart part that is being closed.</param>
		protected WorkspaceCancelEventArgs RaiseSmartPartClosing(object smartPart)
		{
			WorkspaceCancelEventArgs cancelArgs = new WorkspaceCancelEventArgs(smartPart);
			RaiseSmartPartClosing(cancelArgs);

			return cancelArgs;
		}

		/// <summary>
		/// Raises the <see cref="SmartPartClosing"/> event using the specified 
		/// event argument.
		/// </summary>
		/// <param name="e">The arguments to pass to the event.</param>
		protected void RaiseSmartPartClosing(WorkspaceCancelEventArgs e)
		{
			if (this.SmartPartClosing != null)
			{
				this.SmartPartClosing(this, e);
			}
		}

		#endregion

		#region Abstract members

		/// <summary>
		/// When overridden in a derived class, activates the smartPart
		/// on the workspace.
		/// </summary>
		/// <param name="smartPart">The smart part to activate.</param>
		protected abstract void OnActivate(TSmartPart smartPart);

		/// <summary>
		/// When overridden in a derived class, applies the smartPartInfo
		/// to the smartPart that lives in the workspace.
		/// </summary>
		protected abstract void OnApplySmartPartInfo(TSmartPart smartPart, TSmartPartInfo smartPartInfo);

		/// <summary>
		/// When overridden in a derived class, shows the smartPart
		/// on the workspace.
		/// </summary>
		/// <param name="smartPart">The smart part to show.</param>
		/// <param name="smartPartInfo">The information to apply to the smart part.</param>
		protected abstract void OnShow(TSmartPart smartPart, TSmartPartInfo smartPartInfo);

		/// <summary>
		/// When overridden in a derived class, hides the smartPart
		/// on the workspace.
		/// </summary>
		/// <param name="smartPart">The smart part to hide.</param>
		protected abstract void OnHide(TSmartPart smartPart);

		/// <summary>
		/// When overridden in a derived class, closes and removes the smartPart
		/// from the workspace.
		/// </summary>
		/// <param name="smartPart">The smart part to close.</param>
		protected abstract void OnClose(TSmartPart smartPart);

		#endregion

		#region Protected Mehtods

		/// <summary>
		/// The list of smart parts shown in the workspace.
		/// </summary>
		protected ICollection<TSmartPart> InnerSmartParts
		{
			get { return smartParts; }
		}

		/// <summary>
		/// By default uses the conversion implemented in <see cref="SmartPartInfo.ConvertTo{TSmartPartInfo}"/>. 
		/// A derived class can implement a different conversion scheme.
		/// </summary>
		protected virtual TSmartPartInfo ConvertFrom(ISmartPartInfo source)
		{
			return SmartPartInfo.ConvertTo<TSmartPartInfo>(source);
		}

		/// <summary>
		/// Creates an instance of the TSmartPartInfo to use to show 
		/// the SmartPart when no information has been 
		/// provided. By default creates a new instance of the TSmartPartInfo.
		/// </summary>
		/// <param name="forSmartPart">The smart part to create the default information for.</param>
		/// <returns>A new instance of the information to use to show the smart part.</returns>
		protected virtual TSmartPartInfo CreateDefaultSmartPartInfo(TSmartPart forSmartPart)
		{
			return new TSmartPartInfo();
		}

		/// <summary>
		/// Closes the smart part without raising the <see cref="SmartPartClosing"/> event.
		/// </summary>
		protected void CloseInternal(TSmartPart smartPart)
		{
			OnClose((TSmartPart)smartPart);
			if (activeSmartPart != null && activeSmartPart.Equals(smartPart))
			{
				activeSmartPart = null;
			}
			smartParts.Remove((TSmartPart)smartPart);
		}

		#endregion
	}
}
