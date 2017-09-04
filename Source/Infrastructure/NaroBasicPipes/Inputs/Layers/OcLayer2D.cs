#region Usings

using System;
using System.Drawing;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Visual3d;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroBasicPipes.Inputs.Layers
{
    public class OcLayer2D
    {
        private readonly Visual3dLayer _layer;
        private string _text;
        private int _x;
        private int _y;

        public OcLayer2D(Visual3dLayer layer)
        {
            _layer = layer;
            Color = Color.Black;
        }

        public Color Color { get; set; }

        public void SetSize(int width, int height)
        {
            _layer.SetViewport(width, height);
            _layer.SetOrtho(0, width, width, 0, AspectTypeOfConstraint.Aspect_TOC_TOP_LEFT);
        }

        public void TextOut(string text)
        {
            _text = text;
        }

        public void SetPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Draw()
        {
            if(_text != null)
            {
                _layer.Color = ShapeUtils.GetOccColor(Color);
                _layer.SetTextAttributes("Arial",
                                    AspectTypeOfDisplayText.Aspect_TODT_NORMAL,
                                    ShapeUtils.GetOccColor(Color.Black));
                _layer.DrawText(_text, _x, _y, 12.0);
            }
        }
    }
}