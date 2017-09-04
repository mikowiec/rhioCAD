#region Usings

using NaroConstants.Names;
using TreeData.Capabilities;

#endregion

namespace ShapeFunctionsInterface.Functions
{
    public class ReferencedShapeConstraints
    {
        private static readonly ReferencedShapeConstraints InternalInstance = new ReferencedShapeConstraints();

        private ReferencedShapeConstraints()
        {
            Capabilities = new CapabilitiesCollection();
            var face = Capabilities.AddConcept("Face");

            var rectangle = Capabilities.AddConcept(FunctionNames.ThreePointsRectangle);
            var parallelogram = Capabilities.AddConcept(FunctionNames.Paralleogram);
            var circle = Capabilities.AddConcept(FunctionNames.Circle);
            var ellipse = Capabilities.AddConcept(FunctionNames.Ellipse);
            var makeFace = Capabilities.AddConcept(FunctionNames.Face);

            Capabilities.AddConcept(FunctionNames.Arc);
            var line = Capabilities.AddConcept(FunctionNames.LineTwoPoints);
            Capabilities.AddConcept(FunctionNames.WireTwoPoints);
            Capabilities.AddConcept(FunctionNames.VerticalLine);
            Capabilities.AddConcept(FunctionNames.HorizontalLine);

            var box = Capabilities.AddConcept(FunctionNames.Box);
            var cone = Capabilities.AddConcept(FunctionNames.Cone);
            var cylinder = Capabilities.AddConcept(FunctionNames.Cylinder);
            Capabilities.AddConcept(FunctionNames.Sphere);
            Capabilities.AddConcept(FunctionNames.Torus);

            var cut = Capabilities.AddConcept(FunctionNames.Cut);

            rectangle.AddRelatedConcept(face);
            circle.AddRelatedConcept(face);
            ellipse.AddRelatedConcept(face);
            makeFace.AddRelatedConcept(face);

            box.AddRelatedConcept(face);
            cone.AddRelatedConcept(face);
            cylinder.AddRelatedConcept(face);

            var extrude = Capabilities.AddConcept(FunctionNames.Extrude);

            AcceptOperation(face, ShapeOperations.Extrudable);
            AcceptOperation(extrude, ShapeOperations.Extrudable);
            AcceptOperation(cut, ShapeOperations.Extrudable);

            AcceptOperation(line, ShapeOperations.Dimensionable);
            AcceptOperation(cut, ShapeOperations.Dimensionable);
            AcceptOperation(extrude, ShapeOperations.Dimensionable);
            AcceptOperation(face, ShapeOperations.Dimensionable);
            AcceptOperation(parallelogram, ShapeOperations.Dimensionable);

            AcceptOperation(circle, ShapeOperations.CircleRadiusConstraint);
            AcceptOperation(line, ShapeOperations.LineLengthConstraint);
            AcceptOperation(rectangle, ShapeOperations.RectangleMeasurementConstraint);


            //Capabilities.SaveAsDocument("ReferencedShapeConstraints.xmlcaps");
            //CapabilitiesDocumentImporter.LoadFileCapabilities("ReferencedShapeConstraints.xmlcaps",
            //                                                  "ReferencedShapeConstraints.caps");

            //Capabilities = CapabilitiesLoader.LoadFileCapabilities("ReferencedShapeConstraints.caps");
        }

        private CapabilitiesCollection Capabilities { get; set; }

        public static ReferencedShapeConstraints Instance
        {
            get { return InternalInstance; }
        }

        private static void AcceptOperation(ConceptBuilder shapeBuilder, string functionName)
        {
            shapeBuilder.SetCapability(functionName, string.Empty);
        }

        public bool IsOperationPossible(string shapeName, string operation)
        {
            var shape = Capabilities.GetConcept(shapeName);
            return shape.Node != null && shape.HasCapability(operation);
        }
    }
}