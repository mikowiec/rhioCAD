#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.Visual3d;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroBasicPipes.Inputs.Layers
{
    public class OcLayer2DManager
    {
        private readonly Control _control;
        private readonly Visual3dLayer _layer;
        private readonly SortedDictionary<string, OcLayer2D> _layers = new SortedDictionary<string, OcLayer2D>();

        public OcLayer2DManager(V3dView view, Control control)
        {
            _control = control;
            _layer = new Visual3dLayer(view.View.ViewManager, AspectTypeOfLayer.Aspect_TOL_OVERLAY, false);
            if (_control == null)
                return;
            control.Resize += ViewResize;
        }

        private void ViewResize(object sender, EventArgs e)
        {
            Resize(_control.Width, _control.Height);
        }

        public OcLayer2D SetLayer(string name)
        {
            OcLayer2D layer;
            if (_layers.TryGetValue(name, out layer)) return layer;
            layer = new OcLayer2D(_layer);
            layer.SetSize(_control.Width, _control.Height);
            _layers[name] = layer;
            return layer;
        }

        private void Resize(int width, int height)
        {
            foreach (var layer2D in _layers)
                layer2D.Value.SetSize(width, height);
        }

        public void Draw()
        {
            if (_layers.Count == 0) return;

            _layer.Clear();

            _layer.Begin();
            _layer.SetTextAttributes("Arial",
                                     AspectTypeOfDisplayText.Aspect_TODT_NORMAL,
                                     ShapeUtils.GetOccColor(Color.Black));
            foreach (var layer2D in _layers.Values)
                layer2D.Draw();
            _layer.End();
        }

        public void Clear()
        {
            _layers.Clear();
        }
    }
}