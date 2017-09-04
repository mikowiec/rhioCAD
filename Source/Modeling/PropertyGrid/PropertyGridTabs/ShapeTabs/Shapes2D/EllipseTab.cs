#region Usings

using System;
using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    /// <summary>
    ///   Description of EllipseTab.
    /// </summary>
    public class EllipseTab : GridTabBase
    {
        private DoublePropertyTabItem _majorRadiusProperty;
        private DoublePropertyTabItem _minorRadiusProperty;

        public EllipseTab()
            : base(PropertyDescriptorsResources.TabTitleEllipse)
        {
        }

        protected override void BuildInterface()
        {
            _minorRadiusProperty = new DoublePropertyTabItem();
            _minorRadiusProperty.OnSetValue += SetMinorRadius;
            _minorRadiusProperty.OnGetValue += GetMinorRadius;
            //_minorRadiusProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                      FunctionNames.
            //                                                                          EllipseMinorRadiusConstraint));
            _minorRadiusProperty.OnLockClicked += OnMinorRadiusLocked;
            PropertyListGenerator.AddProperty("Minor radius", _minorRadiusProperty);

            _majorRadiusProperty = new DoublePropertyTabItem();
            _majorRadiusProperty.OnSetValue += SetMajorRadius;
            _majorRadiusProperty.OnGetValue += GetMajorRadius;
            //_majorRadiusProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                      FunctionNames.
            //                                                                          EllipseMajorRadiusConstraint));
            _majorRadiusProperty.OnLockClicked += OnMajorRadiusLocked;
            PropertyListGenerator.AddProperty("Major radius", _majorRadiusProperty);
        }

        private void OnMinorRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.EllipseMinorRadiusConstraint, GetPreviousMinorRadius());
        }

        private void OnMajorRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.EllipseMajorRadiusConstraint, GetPreviousMajorRadius());
        }

        private void GetMajorRadius(ref object resultvalue)
        {
            resultvalue = GetPreviousMajorRadius();
        }

        private void SetMajorRadius(object data)
        {
            BeginUpdate();

            var previousMinor = GetPreviousMinorRadius();
            SetRadius((double)data, previousMinor);
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
            EndVisualUpdate(PropertyDescriptorsResources.EllipseTab_Set_major_radius);
        }

        private void GetMinorRadius(ref object resultvalue)
        {
            resultvalue = GetPreviousMinorRadius();
        }

        private void SetMinorRadius(object data)
        {
            BeginUpdate();
            var previousMajor = GetPreviousMajorRadius();
            SetRadius(previousMajor, (double)data);
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
            EndUpdate(PropertyDescriptorsResources.EllipseTab_Set_minor_radius);
        }

        private double GetPreviousMajorRadius()
        {
            bool reversed;
           gpDir dirX = null;
           gpDir dirY = null;
            double previousMinorRadius;
            double previousMajorRadius;
            var firstPoint = Builder[0].ReferenceBuilder[1].TransformedPoint3D;
            var secondPoint = Builder[1].ReferenceBuilder[1].TransformedPoint3D;
            var thirdPoint = Builder[2].ReferenceBuilder[1].TransformedPoint3D;
            TreeUtils.ComputeEllipseRadiuses(firstPoint, secondPoint, thirdPoint,
                                             out previousMinorRadius, out previousMajorRadius, out reversed,
                                             ref dirX, ref dirY);
            return previousMajorRadius;
        }


        private double GetPreviousMinorRadius()
        {
            bool reversed;
           gpDir dirX = null;
           gpDir dirY = null;
            double previousMinorRadius;
            double previousMajorRadius;
            var firstPoint = Builder[0].ReferenceBuilder[1].TransformedPoint3D;
            var secondPoint = Builder[1].ReferenceBuilder[1].TransformedPoint3D;
            var thirdPoint = Builder[2].ReferenceBuilder[1].TransformedPoint3D;
            TreeUtils.ComputeEllipseRadiuses(firstPoint, secondPoint, thirdPoint,
                                             out previousMinorRadius, out previousMajorRadius, out reversed,
                                             ref dirX, ref dirY);
            return previousMinorRadius;
        }


        private void SetRadius(Double majorRadius, Double minorRadius)
        {
            bool reversed;
           gpDir dirX = null;
           gpDir dirY = null;
            double previousMinorRadius;
            double previousMajorRadius;
            var firstPoint = Builder[0].ReferenceBuilder[1].TransformedPoint3D;
            var secondPoint = Builder[1].ReferenceBuilder[1].TransformedPoint3D;
            var thirdPoint = Builder[2].ReferenceBuilder[1].TransformedPoint3D;
            TreeUtils.ComputeEllipseRadiuses(firstPoint, secondPoint, thirdPoint,
                                             out previousMinorRadius, out previousMajorRadius, out reversed,
                                             ref dirX, ref dirY);
            // Calculate the ratio needed to scale the radiuses
            var scaleMajor = majorRadius/previousMajorRadius;
            var scaleMinor = minorRadius/previousMinorRadius;

            var center = firstPoint;

            var translatedPoint = new Point3D(center.X, center.Y, center.Z);
            var translatedPoint2 = new Point3D(center.X, center.Y, center.Z);

            // If minor radius is smaller than major radius
            if (!reversed)
            {
                Builder[1].ReferenceBuilder[1].TransformedPoint3D = TreeUtils.ScaleSegment(translatedPoint, secondPoint, scaleMajor); 
                Builder[2].ReferenceBuilder[1].TransformedPoint3D = TreeUtils.ScaleSegment(translatedPoint2, thirdPoint, scaleMinor);
            }
            else
            {
                Builder[1].ReferenceBuilder[1].TransformedPoint3D = TreeUtils.ScaleSegment(translatedPoint, secondPoint, scaleMinor); 
                Builder[2].ReferenceBuilder[1].TransformedPoint3D = TreeUtils.ScaleSegment(translatedPoint2, thirdPoint, scaleMajor);
            }
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _minorRadiusProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _majorRadiusProperty.SetTabOrder(tabIndex);
        }
    }
}