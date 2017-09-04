#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Windows.Controls.Ribbon;
using Naro.Infrastructure.Library.Capabilities;
using NaroConstants.Names;
using TreeData.Capabilities;

#endregion

namespace PartModellingUi.Layout.RibbonTabs
{
    /// <summary>
    ///   Interaction logic for ContextualToolBar.xaml
    /// </summary>
    public partial class ContextualToolBar
    {
        #region Members

        private readonly List<RibbonCommand> _commands = new List<RibbonCommand>();
        private readonly SortedDictionary<string, RibbonGroup> _groups = new SortedDictionary<string, RibbonGroup>();
        private DefaultShapeConcepts _concepts;

        #endregion

        #region Delegates

        public delegate void OnClickHandler(string textButton);

        #endregion

        public OnClickHandler OnClick;

        public ContextualToolBar()
        {
            InitializeComponent();
            ClearAllButtons();
        }

        private bool ExtractResourceName(string conceptName,
                                         out string resourceName,
                                         out string sectionName,
                                         out string labelName)
        {
            var concept = _concepts.Capabilities.GetConcept(conceptName);
            if (concept.Node == null)
            {
                resourceName = string.Empty;
                sectionName = string.Empty;
                labelName = string.Empty;
                return false;
            }

            resourceName = concept.GetCapability(ShapeCapabilitiesNames.DefaultIcon);
            sectionName = concept.GetCapability(ShapeCapabilitiesNames.Section);
            labelName = concept.GetCapability(ShapeCapabilitiesNames.Label);
            return true;
        }

        private void BuildEmptyContext()
        {
            ClearAllButtons();
            Label = "Contextual";
            const string referencedConcept = ConceptNames.Shape;
            var shapeConcepts = ExtractReferencedConcepts(referencedConcept);
            foreach (var shape in shapeConcepts)
            {
                string resourceName;
                string sectionName;
                string labelName;
                if (!ExtractResourceName(shape, out resourceName, out sectionName, out labelName))
                {
                    throw new Exception("The used concept should exist");
                }
                AddButton(resourceName, sectionName, labelName);
            }
        }

        private IEnumerable<string> ExtractReferencedConcepts(string referencedConcept)
        {
            var concepts = _concepts.Capabilities.ConceptList;
            var shapeConcepts = new List<string>();
            foreach (var conceptName in concepts)
            {
                if (conceptName == referencedConcept)
                    continue;
                if (_concepts.Capabilities.IsRelatedWith(conceptName, referencedConcept))
                    shapeConcepts.Add(conceptName);
            }
            return shapeConcepts;
        }

        private IEnumerable<string> ExtractAcceptConcepts()
        {
            var result = new List<string>();
            var concepts = _concepts.Capabilities.ConceptList;
            foreach (var conceptName in concepts)
            {
                if (conceptName.StartsWith("Accept"))
                {
                    result.Add(conceptName);
                }
            }
            return result;
        }

        public void BuildShapeContext(string shapeName)
        {
            var shapeConcept = _concepts.Capabilities.GetConcept(shapeName);
            if ((shapeName == string.Empty) || (shapeConcept.Node == null))
            {
                BuildEmptyContext();
                Focus();
                return;
            }

            ClearAllButtons();
            Label = "Current: " + shapeName;
            AddButton("../../Resources/edit-undo.png", "Shapes", "Shapes");


            var acceptConcepts = ExtractAcceptConcepts();
            foreach (var acceptConcept in acceptConcepts)
            {
                BuildAcceptSection(shapeConcept, acceptConcept);
            }
            Focus();
        }

        private void BuildAcceptSection(ConceptBuilder shapeConcept, string acceptName)
        {
            var acceptExtrude = shapeConcept.GetRelatedConcept(acceptName);
            if (acceptExtrude.Node == null) return;
            string resourceName;
            string sectionName;
            string labelName;
            if (!ExtractResourceName(acceptName, out resourceName, out sectionName, out labelName))
            {
                throw new Exception("The used concept should exist");
            }
            AddButton(resourceName, sectionName, labelName);
        }


        public void SetupConcepts(DefaultShapeConcepts concepts)
        {
            _concepts = concepts;

            BuildShapeContext(string.Empty);
        }

        private void AddButton(string iconImage, string groupName, string textButton)
        {
            var button = new RibbonButton();
            var command = new RibbonCommand {LabelTitle = textButton};
            if (string.IsNullOrEmpty(iconImage))
            {
                throw new Exception("Should not happen!");
            }
            command.LargeImageSource = new BitmapImage(new Uri(iconImage, UriKind.RelativeOrAbsolute));
            command.Executed += ContextCommandExecuted;
            _commands.Add(command);
            var group = SetGroup(groupName);
            group.Controls.Add(button);
            button.Command = command;
        }

        private RibbonGroup SetGroup(string groupName)
        {
            if (_groups.ContainsKey(groupName))
            {
                return _groups[groupName];
            }
            var group = new RibbonGroup();
            var titleCommand = new RibbonCommand {LabelTitle = groupName};
            group.Command = titleCommand;
            _groups[groupName] = group;
            Groups.Add(group);
            return group;
        }

        private void ContextCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var commandName = ((RibbonCommand) e.Command).LabelTitle;
            if (commandName == "Shapes")
            {
                BuildEmptyContext();
                return;
            }
            if (OnClick != null)
            {
                OnClick(commandName);
            }
        }

        private void ClearAllButtons()
        {
            foreach (var command in _commands)
            {
                command.Executed -= ContextCommandExecuted;
            }
            _commands.Clear();
            _groups.Clear();
            foreach (var group in Groups)
            {
                group.Controls.Clear();
            }
            Groups.Clear();
        }
    }
}