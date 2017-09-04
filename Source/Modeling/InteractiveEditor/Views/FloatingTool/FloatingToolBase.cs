#region Usings

using System.Windows.Controls;
using Naro.Infrastructure.Interface;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;

#endregion

namespace InteractiveEditor.Views.FloatingTool
{
    public abstract class FloatingToolBase
    {
        public ViewInfo ViewInfo;

        protected FloatingToolBase(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }


        public abstract bool AcceptEntity(SelectionContainer entity);

        public abstract void PopulateView(StackPanel panel, SelectionContainer entity, ActionsGraph actionsGraph);
    }
}