#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Microsoft.Windows.Controls.Ribbon;
using Naro.Infrastructure.Interface.Views;
using Naro.Infrastructure.Library.Capabilities;
using NaroConstants.Names;
using TreeData.Capabilities;

#endregion

namespace PartModellingUi.Views
{
    public class ContextMenuManager : IContextMenuManager
    {
        private readonly DefaultShapeConcepts _concepts;

        private readonly SortedDictionary<string, Dictionary<MenuItem, RibbonCommand>> _groups =
            new SortedDictionary<string, Dictionary<MenuItem, RibbonCommand>>();

        public ContextMenuManager(CapabilitiesCollection globalCapabilities)
        {
            ContextMenu = new ContextMenu();
            _concepts = new DefaultShapeConcepts(globalCapabilities);
            ClearAllButtons();
        }

        #region IContextMenuManager Members

        public ContextMenu ContextMenu { get; private set; }
        public ImageBitmapCache ImageBitmapCache { get; set; }

        public void BuildShapeContext(string shapeName)
        {
            var shapeConcept = _concepts.Capabilities.GetConcept(shapeName);
            if (shapeName == string.Empty || shapeConcept.Node == null)
            {
                BuildEmptyContext();
                return;
            }
            ClearAllButtons();

            var acceptConcepts = ExtractAcceptConcepts();
            foreach (var acceptConcept in acceptConcepts)
            {
                BuildAcceptSection(shapeConcept, acceptConcept);
            }

            RebuildContextMenu();
        }

        public event OnClickHandler OnClick;

        #endregion

        private bool ExtractResourceName(string conceptName, out string resourceName, out string sectionName,
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
                {
                    continue;
                }
                if (_concepts.Capabilities.IsRelatedWith(conceptName, referencedConcept))
                {
                    shapeConcepts.Add(conceptName);
                }
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

        /// <summary>
        ///   Rebuilds the context menu from scratch. Separators added between groups.
        /// </summary>
        private void RebuildContextMenu()
        {
            ContextMenu.MenuItems.Clear();
            foreach (var group in _groups)
            {
                foreach (var item in group.Value)
                {
                    ContextMenu.MenuItems.Add(item.Key);
                }
                ContextMenu.MenuItems.Add(new MenuItem("-"));
            }
        }

        private void BuildAcceptSection(ConceptBuilder shapeConcept, string acceptName)
        {
            var acceptExtrude = shapeConcept.GetRelatedConcept(acceptName);
            if (acceptExtrude.Node == null) return;
            string resourceName;
            string sectionName;
            string labelName;
            if (!ExtractResourceName(acceptName, out resourceName, out sectionName, out labelName))
                throw new Exception("The used concept should exist");
            AddButton(resourceName, sectionName, labelName);
        }

        private void AddButton(string iconImage, string groupName, string textButton)
        {
            var buttonGroup = "Default";
            if (groupName.Length > 0)
                buttonGroup = groupName;
            var button = new MenuItem(textButton);
            var command = new RibbonCommand {LabelTitle = textButton};
            if (string.IsNullOrEmpty(iconImage))
                throw new Exception("Invalid icon image!");
            command.LargeImageSource = new BitmapImage(new Uri(iconImage, UriKind.RelativeOrAbsolute));
            var group = SetGroup(buttonGroup);
            group.Add(button, command);
            button.Click += ContextCommandExecuted;
        }

        private Dictionary<MenuItem, RibbonCommand> SetGroup(string groupName)
        {
            if (_groups.ContainsKey(groupName))
                return _groups[groupName];
            var group = new Dictionary<MenuItem, RibbonCommand>();
            _groups[groupName] = group;
            return group;
        }

        /// <summary>
        ///   Search through the menu item lists for the one passed as parameter. Returns the command object attached to the item.
        /// </summary>
        /// <param name = "menuItem"></param>
        /// <returns></returns>
        private RibbonCommand GetAttachedCommand(IDisposable menuItem)
        {
            foreach (var group in _groups)
            {
                foreach (var item in group.Value)
                {
                    if (item.Key == menuItem)
                        return item.Value;
                }
            }
            return null;
        }

        /// <summary>
        ///   Called when a menu item is clicked.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        private void ContextCommandExecuted(object sender, EventArgs e)
        {
            if (!(sender is MenuItem))
            {
                return;
            }
            // Find the attached command to the clicked menu item
            var commandName = GetAttachedCommand(sender as MenuItem);
            if (commandName == null)
            {
                return;
            }
            if (OnClick != null)
            {
                // Inform listeners that the command was launched
                OnClick(commandName.LabelTitle);
            }
        }

        /// <summary>
        ///   Clear the built menu and disconnect the events from menu items
        /// </summary>
        private void ClearAllButtons()
        {
            foreach (var group in _groups)
            {
                foreach (var item in group.Value)
                    item.Key.Click -= ContextCommandExecuted;
                group.Value.Clear();
            }
            _groups.Clear();
        }
    }
}