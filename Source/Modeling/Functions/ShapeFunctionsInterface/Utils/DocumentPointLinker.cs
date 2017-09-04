using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Collections;
namespace ShapeFunctionsInterface.Utils
{
    public class DocumentPointLinker
    {
        private readonly Document _document;
        private SortedDictionary<Point3D, NodeBuilder> _points;
        private readonly Node _sketchNode;

        public DocumentPointLinker(Document document, Node sketchNode)
        {
            _document = document;
            _sketchNode = sketchNode;

            _points = new SortedDictionary<Point3D, NodeBuilder>(new GeomUtils.PointComparer());
            var root = _document.Root;
            var dci = root.Get<DocumentContextInterpreter>();
            var shapeGraph = dci.ShapesGraph;
            var sketchNodeIndex = sketchNode.Index;
            List<int> fromMap;
            if (!shapeGraph.ReferrencedBy.TryGetValue(sketchNodeIndex, out fromMap)) return;
            foreach (var key in fromMap)
            {
                var candidateBuilder = new NodeBuilder(root[key]);
                if (candidateBuilder.FunctionName != FunctionNames.Point) continue;
                _points[candidateBuilder[1].TransformedPoint3D] = candidateBuilder;
            }
        }

        public NodeBuilder GetPoint(Point3D point)
        {
            NodeBuilder result;
            if (_points.TryGetValue(point, out result))
            {
                return result;
            }
            result = new NodeBuilder(_document, FunctionNames.Point);
            result.Node.Set<TreeViewVisibilityInterpreter>();
            result[0].Reference = _sketchNode;
            result[1].TransformedPoint3D = point;
            _points[point] = result;
            result.Color = Color.Orange;
            result.ExecuteFunction();
            return result;
        }


        public NodeBuilder GetLine(Point3D point1, Point3D point2)
        {
            NodeBuilder result;
            NodeBuilder p1=null, p2=null;
            if (_points.TryGetValue(point1, out result))
            {
                p1 = result;
            }
            if (_points.TryGetValue(point2, out result))
            {
                p2 = result;
            }
            if (p1!= null) 
            {
                if(p2!=null)
                {
                    foreach(var child in _document.Root.Children.Values)
                    {
                        var nb = new NodeBuilder(child);
                        if(nb.FunctionName == FunctionNames.LineTwoPoints)
                        {
                            var nbP = NodeBuilderUtils.GetDependencyReferenceIndexes(child.Index, _document).ToList();
                            if((nbP[0] == p1.Node.Index ||nbP[0] == p2.Node.Index) && (nbP[1] == p1.Node.Index ||nbP[1] == p2.Node.Index))
                            {
                               return new NodeBuilder(child);
                            }
                        }
                    }
                }
                else
                {
                    p2 = GetPoint(point2);
                }
            }
            else
            {
                p1 = GetPoint(point1);
                if (p2 == null)
                {
                    p2 = GetPoint(point2);
                }
            }
            var line = new NodeBuilder(_document, FunctionNames.LineTwoPoints);
            line[0].Reference = p1.Node;
            line[1].Reference = p2.Node;
            line.ExecuteFunction();
            return line;
        }
    }
}