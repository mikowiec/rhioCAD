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
using System.Configuration;
using System.Globalization;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// Attribute for Dependency Injection of a reference to an <see cref="ApplicationSettingsBase"/>-derived
	/// class that provides the configuration for the component.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class ConfigurationAttribute : ParameterAttribute
	{
		private string settingsKey;

		/// <summary>
		/// Initializes the attribute with no special key for the configuration settings class.
		/// </summary>
		public ConfigurationAttribute()
		{
		}

		/// <summary>
		/// Initializes the attribute with a key to use to specialize the configuration settings class.
		/// </summary>
		/// <param name="settingsKey">The key used to specialize the configuration settings class.</param>
		public ConfigurationAttribute(string settingsKey)
		{
			this.settingsKey = settingsKey;
		}

		/// <summary>
		/// See <see cref="ParameterAttribute.CreateParameter"/> for more information.
		/// </summary>
		public override IParameter CreateParameter(Type memberType)
		{
			if (!typeof(ApplicationSettingsBase).IsAssignableFrom(memberType))
				throw new ArgumentException(String.Format(
						CultureInfo.CurrentCulture,
						Properties.Resources.ConfigurationAttributeOnValueWithIncompatibleType,
						memberType));

			return new ConfigurationParameter(memberType, settingsKey);
		}

		private class ConfigurationParameter : KnownTypeParameter
		{
			static Dictionary<string, ApplicationSettingsBase> cache = new Dictionary<string, ApplicationSettingsBase>();
			string settingsKey;

			public ConfigurationParameter(Type type, string settingsKey)
				: base(type)
			{
				this.settingsKey = settingsKey;
			}

			public override object GetValue(IBuilderContext context)
			{
				lock (cache)
				{
					string cacheKey = type.ToString();

					if (settingsKey != null)
						cacheKey += "-" + settingsKey;

					ApplicationSettingsBase settings = cache[cacheKey];

					if (settings == null)
					{
						settings = (ApplicationSettingsBase)context.HeadOfChain.BuildUp(context, type, null, null);

						if (settingsKey != null)
							settings.SettingsKey = settingsKey;

						cache.Add(cacheKey, settings);
					}

					return settings;
				}
			}
		}
	}
}
