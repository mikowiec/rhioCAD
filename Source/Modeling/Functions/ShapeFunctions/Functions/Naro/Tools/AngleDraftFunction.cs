#region Usings

using System;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepOffsetAPI;
using NaroCppCore.Occ.Draft;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using OccCode;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.Utils;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class AngleDraftFunction : FunctionBase
    {
        #region Constructor

        public AngleDraftFunction() : base(FunctionNames.AngleDraft)
        {
            // Reference to face to be drafted
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Face describing the reference plane
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Direction to apply draft
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            // Draft angle
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        #endregion

        #region Overriden methods

        protected override bool ValidateReference(int indexDependency, ReferenceInterpreter reference)
        {
            return true;
        }

        public override void PreExecute()
        {
        }

        public override bool Execute()
        {
            var draftedShape = Dependency[0].ReferedShape;
            var draftedFace = TopoDS.Face(Dependency[0].ReferenceData.TargetShape());

            var draftReferenceShape = Dependency[1].ReferenceData.TargetShape();
            Ensure.IsTrue(draftReferenceShape.ShapeType == TopAbsShapeEnum.TopAbs_FACE);
            var draftReferenceFace = TopoDS.Face(draftReferenceShape);
            var draftDirection = GeomUtils.ExtractDirection(draftReferenceFace).Reversed;

            var angle = Dependency[3].Real;
            if (Math.Abs(angle) < Precision.Angular) return false;

            var neutralPlaneNormal = Dependency[2].Axis3D.GpAxis;
            var neutralPlane = new gpPln(neutralPlaneNormal.Location, neutralPlaneNormal.Direction);

            var draft = new BRepOffsetAPIDraftAngle(draftedShape);

            var draftSuceeded = BuildFaceDraft(draft, draftedFace, draftDirection, angle, neutralPlane);
            if (!draftSuceeded) return false;

            draft.Build();
            if (!draft.IsDone)
            {
                return false;
            }
            if (draft.Status != DraftErrorStatus.Draft_NoError)
            {
                return false;
            }
            var refNode = Dependency[0].Reference;

            NodeUtils.Hide(refNode);

            Shape = draft.Shape;

            return true;
        }

        #endregion

        #region Methods

        public static bool BuildFaceDraft(BRepOffsetAPIDraftAngle draft, TopoDSFace draftedFace,
                                          gpDir draftDirection, double angle, gpPln neutralPlane)
        {
            try
            {
                draft.Add(draftedFace, draftDirection, angle, neutralPlane, true);
                if (!draft.AddDone)
                {
                    //draft.Remove(draftedFace);
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}