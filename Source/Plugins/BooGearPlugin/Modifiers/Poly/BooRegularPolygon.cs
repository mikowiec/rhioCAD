#region Usings

using BooGearPlugin.Modifiers.Names;
using BooGearPlugin.Views;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.Boo;
using NaroBasicPipes.Actions;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace BooGearPlugin.Modifiers.Poly
{
    internal class BooRegularPolygon : DrawingLiveShape
    {
        private RegularPolyProperties _form;
        private LibraryShape _poly;
        private bool _registered;
        private int _steps;

        public BooRegularPolygon()
            : base(BooModifier.RegularPolygon)
        {
            _steps = 5;
        }

        private void RegisterRegularPoly()
        {
            if (_registered) return;
            _registered = GlobalLibraryShapeFactory.Instance.Register(BooShapeNames.RegularPolygon,
                                                                      "Boo\\Library\\RegularPoly.boo");
            Ensure.IsTrue(_registered);
        }

        public override void OnActivate()
        {
            base.OnActivate();

            RegisterRegularPoly();

            _poly = GlobalLibraryShapeFactory.Instance.Get(BooShapeNames.RegularPolygon);
            Reset();
        }

        private void Reset()
        {
            Points.Clear();
            Points.Add(new Point3D());
        }

        private void OnPreviewValueChange()
        {
            _steps = _form.Steps;

            Preview();
        }

        private void OnPreferencesClosed()
        {
            if (!_form.Executed)
            {
                _form = null;
                BackToNeutralModifier();
                return;
            }
            _form = null;
            BuildFinalShape();
            UpdateView();
            RebuildTreeView();
            BackToNeutralModifier();
        }

        private void BuildFinalShape()
        {
            Preview();
            CommitFinal("Created Regular Polygon");
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            if (_poly.GenerateTreeViewFromRootBuilder)
                AddBuilderToTreeRecursively(_poly.RootBuilder);
            else
                RebuildTreeView();
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (mouseData.MouseDown) return;

            Points[Points.Count - 1] = mouseData.Point;
            Points.Add(mouseData.Point);
            if (_form == null)
            {
                _form = new RegularPolyProperties(5);
                _form.OnValueChange += OnPreviewValueChange;
                _form.OnDialogClosed += OnPreferencesClosed;
                _form.Show();
            }
            if (Points.Count <= 2)
                return;
            BuildFinalShape();
            _form.Close();
            Reset();
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            base.OnMouseMove3DAction(mouseData);
            if (Points.Count == 0) return;
            Points[Points.Count - 1] = mouseData.Point;
            if (Points.Count < 2) return;
            if (Points[0].IsEqual(Points[1])) return;
            Preview();
        }

        private void Preview()
        {
            if (Points.Count < 2) return;
            InitSession();

            _poly.Set(0, Points[0]);
            _poly.Set(1, Points[1]);
            _poly.Set(2, _steps);
            _poly.Execute(Document);
        }

        public override void OnDeactivate()
        {
            if (_form != null)
            {
                _form.Close();
                _form = null;
            }
            base.OnDeactivate();
        }
    }
}