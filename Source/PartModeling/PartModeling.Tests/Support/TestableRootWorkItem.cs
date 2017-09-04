using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.WinForms;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.BuilderStrategies;

namespace NaroCAD.PartModeling.Tests.Support
{
    public class TestableRootWorkItem : WorkItem
    {
        public TestableRootWorkItem()
        {
            InitializeRootWorkItem(CreateBuilder());

            Services.AddNew<CommandAdapterMapService, ICommandAdapterMapService>();
            Services.AddNew<ControlActivationService, IControlActivationService>();
        }

        public Builder Builder
        {
            get { return InnerBuilder; }
        }

        public IReadWriteLocator Locator
        {
            get { return InnerLocator; }
        }

        private Builder CreateBuilder()
        {
            Builder builder = new Builder();

            builder.Strategies.AddNew<WinFormServiceStrategy>(BuilderStage.Initialization);
            builder.Strategies.AddNew<EventBrokerStrategy>(BuilderStage.Initialization);
            builder.Strategies.AddNew<CommandStrategy>(BuilderStage.Initialization);
            builder.Strategies.AddNew<ControlActivationStrategy>(BuilderStage.Initialization);
            builder.Strategies.AddNew<ControlSmartPartStrategy>(BuilderStage.Initialization);
            builder.Strategies.AddNew<ObjectBuiltNotificationStrategy>(BuilderStage.PostInitialization);

            builder.Policies.SetDefault<ObjectBuiltNotificationPolicy>(new ObjectBuiltNotificationPolicy());
            builder.Policies.SetDefault<ISingletonPolicy>(new SingletonPolicy(true));

            return builder;
        }
    }
}
