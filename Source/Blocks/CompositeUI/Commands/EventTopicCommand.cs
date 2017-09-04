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
using System.Text;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.CompositeUI.EventBroker;
using System.Globalization;

namespace Microsoft.Practices.CompositeUI.Commands
{
	/// <summary>
	/// Defines a <see cref="Command"/> that fires an <see cref="EventTopic"/> when
	/// it is executed
	/// </summary>
	public class EventTopicCommand : Command
	{
		private PublicationScope scope = PublicationScope.Descendants;
        private WorkItem workItem;
        private const string TopicNameFormat = "topic://EventTopicCommand/{0}";

		/// <summary>
		/// The <see cref="WorkItem"/> that contains this command.
		/// </summary>
		[ServiceDependency]
		public WorkItem WorkItem
		{
			set { workItem = value; }
		}

		/// <summary>
		/// Executes the command and fires the <see cref="EventTopic"/>.
		/// </summary>
		/// <param name="sender">The sender for the <see cref="Command"/> handlers
		/// and the <see cref="EventTopic"/> subscriptions.</param>
		/// <param name="e">The <see cref="EventArgs"/> for the <see cref="Command"/> handlers and
		/// the <see cref="EventTopic"/> subscriptions.</param>
		protected override void OnExecuteAction(object sender, EventArgs e)
		{
			base.OnExecuteAction(sender, e);
			EventTopic topic = workItem.EventTopics.Get(String.Format(CultureInfo.InstalledUICulture, TopicNameFormat, Name));
			if (topic != null)
			{
				topic.Fire(sender, e, workItem, scope);
			}
		}

        /// <summary>
        /// The <see cref="PublicationScope"/> the <see cref="EventTopic"/> will be fired with.
        /// </summary>
        public PublicationScope Scope
        {
            get { return scope; }
            set { scope = value;  }
        }
	}
}
