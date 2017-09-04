#region Usings

using NaroConstants.Names;
using TreeData.Capabilities;

#endregion

namespace Naro.Infrastructure.Library.Capabilities
{
    public class DefaultShapeConcepts
    {
        public DefaultShapeConcepts(CapabilitiesCollection globalCapabilities)
        {
            Capabilities = globalCapabilities ?? new CapabilitiesCollection();
            Setup();
        }

        public CapabilitiesCollection Capabilities { get; private set; }

        private void Setup()
        {
            //concept None have no capabilities
            Capabilities.AddConcept(ConceptNames.None);

            //concept Shape will have a box icon and edit actions
            var shapeConcept = Capabilities.AddConcept(ConceptNames.Shape);
            shapeConcept.SetCapability(ShapeCapabilitiesNames.Section, "Shape");
            shapeConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/cube.png");

            var featureConcept = Capabilities.AddConcept(ConceptNames.Feature);
            featureConcept.SetCapability(ShapeCapabilitiesNames.Section, "Feature");
            featureConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/circle.png");

            var circleConcept = Capabilities.AddConcept(FunctionNames.Circle);
            circleConcept.SetCapability(ShapeCapabilitiesNames.Label, "Circle");
            circleConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/circle.png");

            var ellipseConcept = Capabilities.AddConcept(FunctionNames.Ellipse);
            ellipseConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/circle.png");

            var pointConcept = Capabilities.AddConcept(FunctionNames.Point);
            pointConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/point.png");

            var rectangleConcept = Capabilities.AddConcept(FunctionNames.Rectangle);
            rectangleConcept.SetCapability(ShapeCapabilitiesNames.Label, "Rectangle");
            rectangleConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                           "/Resources;component/Resources/rectangle.png");

            var rectangle2Concept = Capabilities.AddConcept(FunctionNames.Paralleogram);
            rectangle2Concept.SetCapability(ShapeCapabilitiesNames.Label, "Rectangle");
            rectangle2Concept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                            "/Resources;component/Resources/rectangle.png");

            var parallelogramConcept = Capabilities.AddConcept(FunctionNames.ThreePointsRectangle);
            parallelogramConcept.SetCapability(ShapeCapabilitiesNames.Label, "Rectangle");
            parallelogramConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                               "/Resources;component/Resources/rectangle.png");

            var lineConcept = Capabilities.AddConcept(FunctionNames.LineTwoPoints);
            lineConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/line.png");

            var angleDraft = Capabilities.AddConcept(FunctionNames.AngleDraft);
            angleDraft.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/line.png");

            var wire = Capabilities.AddConcept(FunctionNames.WireTwoPoints);
            wire.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/line.png");
            var lineHints = Capabilities.AddConcept(FunctionNames.LineHints);
            lineHints.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/line.png");

            var splineConcept = Capabilities.AddConcept(FunctionNames.Spline);
            splineConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/spline.png");

            var arcRseConcept = Capabilities.AddConcept(FunctionNames.Arc3P);
            arcRseConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/arc.png");

            var arcSerConcept = Capabilities.AddConcept(FunctionNames.Arc);
            arcSerConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/arc-ser.png");

            var horizontalLine = Capabilities.AddConcept(FunctionNames.HorizontalLine);
            horizontalLine.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                         "/Resources;component/Resources/line-horizontal.png");

            var verticalLine = Capabilities.AddConcept(FunctionNames.VerticalLine);
            verticalLine.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                       "/Resources;component/Resources/line-vertical.png");

            var boxConcept = Capabilities.AddConcept(FunctionNames.Box);
            boxConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/cube.png");

            var sphereConcept = Capabilities.AddConcept(FunctionNames.Sphere);
            sphereConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/sphere.png");

            var cylinderConcept = Capabilities.AddConcept(FunctionNames.Cylinder);
            cylinderConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                          "/Resources;component/Resources/cylinder.png");

            var coneConcept = Capabilities.AddConcept(FunctionNames.Cone);
            coneConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/cone.png");

            var torusConcept = Capabilities.AddConcept(FunctionNames.Torus);
            torusConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/torus.png");

            var extrudeConcept = Capabilities.AddConcept(FunctionNames.Extrude);
            extrudeConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                         "/Resources;component/Resources/extrude.png");

            var pipeConcept = Capabilities.AddConcept(FunctionNames.Pipe);
            pipeConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                      "/Resources;component/Resources/extrude.png");

            var cutConcept = Capabilities.AddConcept(FunctionNames.Cut);
            cutConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/cut.png");

            var booleanConcept = Capabilities.AddConcept(FunctionNames.Boolean);
            booleanConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                         "/Resources;component/Resources/bool_fuse.png");

            var sewingConcept = Capabilities.AddConcept(FunctionNames.Sewing);
            sewingConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                        "/Resources;component/Resources/bool_fuse.png");

            var fillet2DConcept = Capabilities.AddConcept(FunctionNames.Fillet2D);
            fillet2DConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                          "/Resources;component/Resources/fillet2d.png");
            fillet2DConcept.SetCapability(ShapeCapabilitiesNames.Label, "Fillet2D");

            var fillet3DConcept = Capabilities.AddConcept(FunctionNames.Fillet);
            fillet3DConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon,
                                          "/Resources;component/Resources/drawing_fillet.png");
            fillet3DConcept.SetCapability(ShapeCapabilitiesNames.Label, "Fillet");

            //var chamfer2dConcept = Capabilities.AddConcept(FunctionNames.Chamfer2D);
            //chamfer2dConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/chamfer2d.png");
            //chamfer2dConcept.SetCapability(ShapeCapabilitiesNames.Label, "Chamfer2D");

            //var chamfer3dConcept = Capabilities.AddConcept(FunctionNames.Chamfer);
            //chamfer3dConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/chamfer.png");
            //chamfer3dConcept.SetCapability(ShapeCapabilitiesNames.Label, "Chamfer");

            //

            var acceptExtrude = Capabilities.AddConcept(ConceptNames.AcceptExtrude);
            acceptExtrude.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "/Resources;component/Resources/extrude.png");
            acceptExtrude.SetCapability(ShapeCapabilitiesNames.Label, "Extrude");
            acceptExtrude.SetCapability(ShapeCapabilitiesNames.Section, "Feature");

            //var acceptEdgeOperation = Capabilities.AddConcept(ConceptNames.AcceptEdgeOperation);
            //acceptEdgeOperation.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/extrude.png");

            //var acceptCut = Capabilities.AddConcept(ConceptNames.AcceptCut);
            //acceptCut.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/cut.png");
            //acceptCut.SetCapability(ShapeCapabilitiesNames.Label, "Cut");

            //var acceptExplode = Capabilities.AddConcept(ConceptNames.AcceptExplode);
            //acceptExplode.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/extrude.png");

            //var acceptFillet = Capabilities.AddConcept(ConceptNames.AcceptFillet);
            //acceptFillet.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/fillet2d.png");
            //acceptFillet.SetCapability(ShapeCapabilitiesNames.Label, "Fillet");

            //var acceptChamfer = Capabilities.AddConcept(ConceptNames.AcceptChamfer);
            //acceptChamfer.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/chamfer.png");
            //acceptChamfer.SetCapability(ShapeCapabilitiesNames.Label, "Chamfer");

            //var acceptConstraints = Capabilities.AddConcept(ConceptNames.AcceptConstraints);
            //acceptConstraints.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/add_constraints.png");
            //acceptConstraints.SetCapability(ShapeCapabilitiesNames.Label, "Constraints");

            //var acceptBoolean = Capabilities.AddConcept(ConceptNames.AcceptBoolean);
            //acceptBoolean.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/extrude.png");

            //var acceptEdit = Capabilities.AddConcept(ConceptNames.AcceptEdit);
            //acceptEdit.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/extrude.png");
            //acceptEdit.SetCapability(ShapeCapabilitiesNames.Label, "Edit");

            //var acceptMirror = Capabilities.AddConcept(ConceptNames.AcceptMirror);
            //acceptMirror.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/mirrorLine.png");
            //acceptMirror.SetCapability(ShapeCapabilitiesNames.Label, "Mirror");

            //var acceptPattern = Capabilities.AddConcept(ConceptNames.AcceptPattern);
            //acceptPattern.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/patternlinecircle.png");
            //acceptPattern.SetCapability(ShapeCapabilitiesNames.Label, "Pattern");

            //var acceptFaceFuse = Capabilities.AddConcept(ConceptNames.AcceptFaceFuse);
            //acceptFaceFuse.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/extrude.png");
            //acceptFaceFuse.SetCapability(ShapeCapabilitiesNames.Label, "Face Fuse");

            //var acceptOffset = Capabilities.AddConcept(ConceptNames.AcceptOffset);
            //acceptOffset.SetCapability(ShapeCapabilitiesNames.DefaultIcon, "../../Resources/offset3D.png");
            //acceptOffset.SetCapability(ShapeCapabilitiesNames.Label, "Offset");


            Capabilities.AddRelation(FunctionNames.Circle, ConceptNames.Shape);
            Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.Shape);
            //Circle capabilities
            //Capabilities.AddRelation(FunctionNames.Circle, ConceptNames.AcceptConstraints);
            Capabilities.AddRelation(FunctionNames.Circle, ConceptNames.AcceptExtrude);
            //Capabilities.AddRelation(FunctionNames.Circle, ConceptNames.AcceptMirror);
            //Capabilities.AddRelation(FunctionNames.Circle, ConceptNames.AcceptOffset);
            //Capabilities.AddRelation(FunctionNames.Circle, ConceptNames.AcceptPattern);
            ////Rectangle capabilities
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptChamfer);
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptConstraints);
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptCut);
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptExtrude);
            Capabilities.AddRelation(FunctionNames.LineTwoPoints, ConceptNames.Axis);
            Capabilities.AddRelation(FunctionNames.HorizontalLine, ConceptNames.Axis);
            Capabilities.AddRelation(FunctionNames.VerticalLine, ConceptNames.Axis);
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptFillet);
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptMirror);
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptOffset);
            //Capabilities.AddRelation(FunctionNames.Rectangle, ConceptNames.AcceptPattern);

            //Capabilities.SaveAsDocument("DefaultShapeConcepts.xmlcaps");
            //CapabilitiesDocumentImporter.LoadFileCapabilities("DefaultShapeConcepts.xmlcaps",
            //                                                  "DefaultShapeConcepts.caps");

            //Capabilities = CapabilitiesLoader.LoadFileCapabilities("DefaultShapeConcepts.caps");
        }
    }
}