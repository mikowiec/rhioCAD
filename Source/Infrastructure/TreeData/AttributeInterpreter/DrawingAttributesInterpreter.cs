#region Usings

using System.Drawing;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Quantity;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class DrawingAttributesInterpreter : AttributeInterpreterBase
    {
        private Color _color;
        private AISDisplayMode _displayMode;
        private bool _hasColorSet;
        private bool _hasNoColor;
        private bool _selectionEnabled = true;
        private double _transparency;
        private ObjectVisibility _visibility;

        public DrawingAttributesInterpreter()
        {
            _displayMode = AISDisplayMode.AIS_Shaded;
        }

        public ObjectVisibility Visibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                OnModified();
            }
        }

        public Color Color
        {
            get { return _color; }
            set
            {
                HasColorSet = true;
                _color = value;
                OnModified();
            }
        }

        public QuantityColor OccColor
        {
            get { return ShapeUtils.GetOccColor(_color); }
        }

        public bool HasNoColor
        {
            get { return _hasNoColor; }
            set
            {
                _hasNoColor = value;
                OnModified();
            }
        }

        public bool HasColorSet
        {
            get { return _hasColorSet; }
            set
            {
                _hasColorSet = value;
                OnModified();
            }
        }

        public double Transparency
        {
            get { return _transparency; }
            set
            {
                HasTransparency = true;
                _transparency = value;
                OnModified();
            }
        }

        public bool HasTransparency { get; set; }

        public AISDisplayMode DisplayMode
        {
            get { return _displayMode; }
            set
            {
                _displayMode = value;
                OnModified();
            }
        }

        public bool EnableSelection
        {
            get { return _selectionEnabled; }
            set
            {
                _selectionEnabled = value;
                OnModified();
            }
        }

        public override void Serialize(AttributeData data)
        {
            //Color info
            data.WriteAttribute("Red", Color.R);
            data.WriteAttribute("Green", Color.G);
            data.WriteAttribute("Blue", Color.B);
            data.WriteAttribute("HasColor", HasColorSet);
            //Transparency info
            data.WriteAttribute("Transparency", Transparency);
            data.WriteAttribute("HasTransparency", HasTransparency);
            //Display info
            data.WriteAttribute("DisplayMode", (int) DisplayMode);
            data.WriteAttribute("Visibility", (int) Visibility);
            data.WriteAttribute("EnableSelection", EnableSelection ? 1 : 0);
            data.WriteAttribute("HasNoColor", _hasNoColor ? 1 : 0);
        }

        public override void Deserialize(AttributeData data)
        {
            //Color info
            _hasNoColor = data.ReadAttributeInteger("HasNoColor") != 0;
            HasColorSet = data.ReadAttributeInteger("HasColor") != 0;
            var red = data.ReadAttributeInteger("Red");
            var greem = data.ReadAttributeInteger("Green");
            var blue = data.ReadAttributeInteger("Blue");
            _color = Color.FromArgb(255, red, greem, blue);
            //Transparency info
            HasTransparency = data.ReadAttributeInteger("HasTransparency") != 0;
            _transparency = data.ReadAttributeDouble("Transparency");
            //Display info
            _displayMode = (AISDisplayMode) data.ReadAttributeInteger("DisplayMode");
            _visibility = (ObjectVisibility) data.ReadAttributeInteger("Visibility");
            _selectionEnabled = data.ReadAttributeInteger("EnableSelection") == 1 ? true : false;
            OnModified();
        }
    }
}