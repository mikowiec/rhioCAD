#region Usings

using System;
using System.Text;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace PartModellingLogic.UI.Views.Rendering
{
    public class RenderShape
    {
        private readonly TriangleMesh _triangleShape;

        public RenderShape(TopoDSShape shape)
        {
            _triangleShape = Triangulation.Process(shape);
        }

        public string GenerateMesh(string shaderName, string shapeName)
        {
            var sb = new StringBuilder();

            sb.AppendLine("object {");
            sb.Append("shader ");
            sb.AppendLine(shaderName);
            sb.AppendLine("type generic-mesh");
            sb.AppendLine("name \"" + shapeName + "\"");

            var pointCount = _triangleShape.Points.Count;
            sb.AppendLine("points " + pointCount);


            foreach (var point in _triangleShape.Points)
                sb.AppendFormat("{0}{1}", RenderDialog.ExtractInvariantPoint(point), Environment.NewLine);
            var triangleCount = _triangleShape.Triangles.Count;
            sb.AppendLine("triangles " + triangleCount);
            foreach (var triangle in _triangleShape.Triangles)
                sb.AppendFormat("{0} {1} {2}{3}", triangle.V1, triangle.V2, triangle.V3, Environment.NewLine);

            sb.AppendLine("normals none");
            sb.AppendLine("uvs none");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}