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

using System.Globalization;

namespace Microsoft.Practices.CompositeUI
{
	internal static class StateChangedTopic
	{
		private const string TOPIC_PREFIX = "topic://WorkitemStateChanged/{0}";

		internal static string BuildStateChangedTopicString(string stateName)
		{
			return string.Format(CultureInfo.InvariantCulture, TOPIC_PREFIX, stateName);
		}
	}
}