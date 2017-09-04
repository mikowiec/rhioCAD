#region Usings

using BooGearPlugin.Modifiers.Names;
using BooGearPlugin.Views;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.Boo;
using NaroBasicPipes.Actions;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace BooGearPlugin.Modifiers.Gear
{
    internal class BooGearShape : DrawingLiveShape
    {
        private double _extrudeSize;
        private GearProperties _form;
        private LibraryShape _poly;
        private bool _registered;
        private int _steps;

        public BooGearShape()
            : base(BooModifier.BooGearShape)
        {
            _steps = 5;
            _extrudeSize = 20;
            GlobalLibraryShapeFactory.Instance.Register<GearShape>(BooShapeNames.BooGearShape);
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
            _extrudeSize = _form.ExtrudeSize;

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
            UpdateTreeView();
            BackToNeutralModifier();
        }

        private void UpdateTreeView()
        {
            if (_poly.GenerateTreeViewFromRootBuilder)
                AddBuilderToTreeRecursively(_poly.RootBuilder);
            else
                RebuildTreeView();
        }

        private void BuildFinalShape()
        {
            Preview();
            CommitFinal("Created Regular Polygon");
            UpdateTreeView();
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
                _form = new GearProperties(5, _extrudeSize);
                _form.OnValueChange += OnPreviewValueChange;
                _form.OnDialogClosed += OnPreferencesClosed;
                _form.Show();
            }
            if (Points.Count <= 3)
                return;
            BuildFinalShape();

            _form.Close();
            _form = null;
            BackToNeutralModifier();
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
            if (Points.Count == 2)
            {
                InitSession();
                var polygon = GlobalLibraryShapeFactory.Instance.Get(BooShapeNames.RegularPolygon);
                polygon.Set(0, Points[0]);
                polygon.Set(1, Points[1]);
                polygon.Set(2, _steps);
                polygon.Execute(Document);
                return;
            }
            if (Points.Count < 3) return;
            InitSession();
            _poly = GlobalLibraryShapeFactory.Instance.Get(BooShapeNames.BooGearShape);
            _poly.Set(0, Points[0]);
            _poly.Set(1, Points[0].Distance(Points[1]));
            _poly.Set(2, Points[0].Distance(Points[2]));
            _poly.Set(3, _steps);
            _poly.Set(4, _extrudeSize);
            _poly.Execute(Document);
            UpdateView();
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