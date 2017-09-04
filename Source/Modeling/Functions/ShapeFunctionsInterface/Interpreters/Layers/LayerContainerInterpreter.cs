#region Usings

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctionsInterface.Interpreters.Layers
{
    /// <summary>
    ///   Node interpreter to be setted up in root node. It should have setted up the state of layers (like visible/not, name, etc.).
    /// </summary>
    public class LayerContainerInterpreter : AttributeInterpreterBase
    {
        private bool _useLayerColors;

        #region Constructor

        public LayerContainerInterpreter()
        {
            VisibleIndices = new SortedDictionary<int, bool>();
            LayerNames = new List<string>();
            LayerColors = new List<Color>();
            AddLayer("Default", ShapeUtils.ComputeRandomColor());
        }

        public void AddLayer(string name, Color color)
        {
            LayerNames.Add(name);
            LayerColors.Add(color);
            var result = Count - 1;
            CurrentLayer = result;
            VisibleIndices[result] = true;
        }

        public void RemoveLayer(int layerIndex, Document document)
        {
            if (layerIndex < CurrentLayer)
                CurrentLayer--;
            var children = new List<Node>(document.Root.Children.Values);
            foreach (var child in children)
            {
                var interpreter = child.Set<LayerVisibilityInterpreter>();
                if (interpreter.TagIndex == layerIndex)
                    DeleteNode(child, document);
                if (interpreter.TagIndex > layerIndex)
                    interpreter.TagIndex--;
            }
            LayerNames.RemoveAt(layerIndex);
            LayerColors.RemoveAt(layerIndex);
        }

        public static void DeleteNode(Node nodeToDelete, Document document)
        {
            new NodeBuilder(nodeToDelete) {Visibility = ObjectVisibility.Hidden};
            document.OptimizeData();
        }

        #endregion

        #region Properties

        public bool UseLayerColors
        {
            get { return _useLayerColors; }
            set
            {
                _useLayerColors = value;
                OnModified();
            }
        }

        private int Count
        {
            get { return LayerNames.Count; }
        }

        private SortedDictionary<int, bool> VisibleIndices { get; set; }

        public List<string> LayerNames { get; private set; }
        public List<Color> LayerColors { get; private set; }
        public int CurrentLayer { get; set; }

        #endregion

        #region Methods

        private void UpdateVisibility()
        {
            var root = Parent.Root;
            foreach (var shape in root.Children.Values)
            {
                var nsInterpeter = shape.Get<NamedShapeInterpreter>();
                if (nsInterpeter != null)
                    nsInterpeter.RegenerateInteractive();
            }
            OnModified();
        }

        public void SetLayerVisibility(int layerIndex, bool isVisible)
        {
            if (isVisible)
                VisibleIndices[layerIndex] = true;
            else
                VisibleIndices.Remove(layerIndex);
            OnModified();
        }

        public bool IsLayerVisible(int layerTagIndex)
        {
            return Count != 0 && VisibleIndices.ContainsKey(layerTagIndex);
        }

        private void SerializeTags(AttributeData data)
        {
            data.WriteAttribute("Tags", LayerNames);
            data.WriteAttribute("Colors", LayerColors);
            data.WriteAttribute("Visible", VisibleIndices.Keys.ToList());
            data.WriteAttribute("Index", CurrentLayer);
        }


        private void DeserializeTags(AttributeData data)
        {
            var oldLayerNames = LayerNames;
            var oldLayerColors = LayerColors;
            var oldVisibleIndices = VisibleIndices;
            LayerNames = data.ReadAttributeListString("Tags");
            var visibilityList = data.ReadAttributeListInteger("Visible");
            LayerColors = data.ReadAttributeListColor("Colors");
            VisibleIndices.Clear();
            foreach (var visibleId in visibilityList)
                VisibleIndices[visibleId] = true;
            if (AreLayerChanged(oldLayerNames, oldLayerColors, oldVisibleIndices))
                UpdateVisibility();
            CurrentLayer = data.ReadAttributeInteger("Index");
        }

        private bool AreLayerChanged(IList<string> oldNames, IList<Color> oldColors,
                                     SortedDictionary<int, bool> oldVisibility)
        {
            if (LayerNames.Count != oldNames.Count) return true;
            for (var i = 0; i < oldNames.Count; i++)
                if (LayerNames[i] != oldNames[i])
                    return true;
            if (LayerColors.Count != oldColors.Count) return true;
            for (var i = 0; i < oldNames.Count; i++)
                if (LayerColors[i] != oldColors[i])
                    return true;
            foreach (var visibleItem in oldVisibility.Keys)
            {
                if (!VisibleIndices.ContainsKey(visibleItem))
                    return true;
            }
            return false;
        }

        #endregion

        #region Overridden methods

        public override void Serialize(AttributeData data)
        {
            SerializeTags(data);
        }

        public override void Deserialize(AttributeData data)
        {
            DeserializeTags(data);
        }

        #endregion
    }
}