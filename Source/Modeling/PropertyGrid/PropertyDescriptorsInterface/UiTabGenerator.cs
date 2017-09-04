#region Usings

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Naro.Infrastructure.Interface;

#endregion

namespace PropertyDescriptorsInterface
{
    public class UiTabGenerator
    {
        public readonly List<PropertyTabItemBase> GeneratedProperties = new List<PropertyTabItemBase>();
        private readonly List<PropertyTabItemBase> _propertyList = new List<PropertyTabItemBase>();

        public void AddProperty(string title, PropertyTabItemBase property)
        {
            _propertyList.Add(property);
            property.Name = title;
        }

        public void PopulateControl(StackPanel mainGrid, IEnumerable<string> filterCriterias)
        {
            GeneratedProperties.Clear();

            foreach (var property in
                _propertyList.Where(property => FilteringUtils.PassFilteringInsensitive(property.Name, filterCriterias))
                )
            {
                GeneratedProperties.Add(property);
                var rowGridPanel = new DockPanel {HorizontalAlignment = HorizontalAlignment.Stretch};
                var label = new Label
                                {
                                    Content = property.Name,
                                    Margin = new Thickness(7, 0, 0, 0),
                                    Width = 90,
                                    HorizontalAlignment = HorizontalAlignment.Left
                                };
                rowGridPanel.Children.Add(label);
                mainGrid.Children.Add(rowGridPanel);
                property.FillControlEvents(rowGridPanel);
            }
        }

        public void RemoveAll()
        {
            _propertyList.Clear();
        }
    }
}