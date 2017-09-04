#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctionsInterface.Functions
{
    public sealed class FunctionDependency
    {
        #region Constructor

        public FunctionDependency(string name)
        {
            Name = name;
        }

        #endregion

        #region Data members

        private bool _isConnectedToNode;
        private Node _label;
        private bool _lockUpdate;

        #endregion

        #region Properties

        public readonly List<DependencyNode> Children = new List<DependencyNode>();

        /// <summary>
        ///   Dependency name
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        ///   Get the children count
        /// </summary>
        public int Count
        {
            get { return Children.Count; }
        }


        public bool IsValid
        {
            get { return Children.All(child => child.IsValid); }
        }

        public Node Node
        {
            get { return _label; }
            set
            {
                DisconnectToNodeChanges();
                ConnectToNodeChanges(value);
                _label = value;
            }
        }

        public DependencyNode this[int childId]
        {
            get { return Child(childId); }
        }

        #endregion

        #region Methods

        /// <summary>
        ///   gets the child (if exists) with the specified index
        /// </summary>
        /// <param name = "childId">The index to look for children</param>
        /// <returns>null in case the children do not exist</returns>
        private DependencyNode Child(int childId)
        {
            return Children[childId];
        }

        /// <summary>
        ///   Associate a new child dependency of a specified type
        /// </summary>
        /// <param name = "typeName"></param>
        public void AddAttributeType(string typeName)
        {
            Children.Add(new DependencyNode(typeName));
            if (Node == null) return;
            DisconnectToNodeChanges();
            ConnectToNodeChanges(Node);
        }

        public void RemoveIndex(int index)
        {
            if (Node != null)
                DisconnectToNodeChanges();
            Children.RemoveAt(index);
            if (Node != null)
                ConnectToNodeChanges(Node);
        }

        /// <summary>
        ///   create connections between dependency and associated node changes
        /// </summary>
        /// <param name = "label"></param>
        private void ConnectToNodeChanges(Node label)
        {
            if (_isConnectedToNode)
            {
                return;
            }

            var position = 0;
            foreach (var child in Children)
            {
                position++;
                child.Node = label.FindChild(position, true);
                child.Node.OnModified += Root_Label_OnModified;
            }
            _isConnectedToNode = true;
        }

        /// <summary>
        ///   remove any connections to node changes so the dependency will not get any notifications in case of any change on a node
        /// </summary>
        private void DisconnectToNodeChanges()
        {
            if (_isConnectedToNode == false)
                return;

            var position = 0;
            foreach (var child in Children)
            {
                child.Node = Node.FindChild(position++, true);
                child.Node.OnModified -= Root_Label_OnModified;
            }
            _isConnectedToNode = false;
        }

        /// <summary>
        ///   locks the dependency changes notification till EndUpdate is happening
        /// </summary>
        public void BeginUpdate()
        {
            _lockUpdate = true;
        }

        /// <summary>
        ///   unlocks the dependency notification
        /// </summary>
        public void EndUpdate()
        {
            _lockUpdate = false;
        }

        /// <summary>
        ///   On node changes calls the function's execute method
        /// </summary>
        /// <param name = "node">node that generates the change</param>
        /// <param name = "interpreterName">interpreter changed</param>
        private void Root_Label_OnModified(Node node, AttributeInterpreterBase interpreterName)
        {
            if (_lockUpdate)
                return;
            if (interpreterName is FunctionInterpreter)
                return;
            Node.Get<FunctionInterpreter>().Execute();
        }

        #endregion

        #region DependencyNode child class

        /// <summary>
        ///   Embeded class that wraps a child Node of the attached dependency node
        /// </summary>
        public class DependencyNode
        {
            #region Constructor

            /// <summary>
            /// </summary>
            /// <param name = "name"></param>
            public DependencyNode(string name)
            {
                Node = null;
                Name = name;
            }

            #endregion

            #region Properties

            /// <summary>
            ///   Gets the associated type of the dependency
            /// </summary>
            public string Name { get; private set; }

            /// <summary>
            ///   Gets the node associated label
            /// </summary>
            public Node Node { get; set; }

            /// <summary>
            ///   Gets the attached 3d point
            /// </summary>
            //public Point3D Point3D
            //{
            //    get
            //    {
            //        HasAttributeOrThrow(InterpreterNames.Point3D);

            //        var geometryPoint = Node.Get<Point3DInterpreter>();
            //        return geometryPoint == null ? new Point3D() : geometryPoint.Value;
            //    }
            //    set
            //    {
            //        HasAttributeOrThrow(InterpreterNames.Point3D);
            //        var builder = new NodeBuilder(Node.Parent);
            //        var geometryPoint = Node.Set<Point3DInterpreter>();
            //        var trsf = BuildTranslation(new Point3D(0, 0, 0), value);
            //        if (IsFirstDependency())
            //        {
            //          //  var trsf = BuildTranslation(new Point3D(0, 0, 0), value);
            //            if (builder.FunctionName == FunctionNames.Point)
            //            {
            //                var axisLocation =
            //                    builder.Dependency[0].Reference.Children[1].Get<Axis3DInterpreter>().GpAxis.Location;
            //                trsf =
            //                    BuildTranslation(
            //                        new Point3D(
            //                            builder.Dependency[0].Reference.Children[1].Get<Axis3DInterpreter>().GpAxis.
            //                                Location), value);
            //            }
                       
            //            var transform = builder.Node.Set<TransformationInterpreter>();
            //            transform.CurrTransform = trsf;
            //            transform.ResetPivot();
            //            transform.OnModified();
            //            geometryPoint.Value = new Point3D();
            //        }
            //        else
            //        {
            //            var currentTransform = builder.Node.Set<TransformationInterpreter>().CurrTransform;
            //            var destPoint = new Point3D(value.GpPnt.Transformed(currentTransform.Inverted));
            //            geometryPoint.Value = destPoint;
            //        }
            //    }
            //}

            public Point3D RefTransformedPoint3D
            {
                set
                {
                    var builder = ReferenceBuilder;
                    builder[1].TransformedPoint3D = value;
                }
                get
                {
                    var builder = ReferenceBuilder;
                    return builder[1].TransformedPoint3D;
                }
            }

            /// <summary>
            ///   Gets the attached 3d point
            /// </summary>
            public Point3D TransformedPoint3D
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Point3D);
                    var geometryPoint = Node.Get<Point3DInterpreter>();
                    if (geometryPoint == null)
                        return new Point3D();
                    var builder = new NodeBuilder(Node.Parent);
                    var translatedPoint = geometryPoint.Value.GpPnt;

                    if (builder.FunctionName == FunctionNames.Point)
                    {
                        var sketchNode = builder.Dependency[0].ReferenceBuilder;
                        var pointtrsf = builder.Node.Get<TransformationInterpreter>().CurrTransform;
                       // var sketchTrsf = NodeBuilderUtils.GetGlobalTransformation(sketchNode);
                        var sketchTrsf = sketchNode.Node.Get<TransformationInterpreter>().CurrTransform;
                        var multiplied = pointtrsf.Multiplied(sketchTrsf);
                        translatedPoint = new gpPnt(0, 0, 0).Transformed(multiplied); 
                    }
                    return new Point3D(translatedPoint);
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Point3D);
                    var builder = new NodeBuilder(Node.Parent);
                    var geometryPoint = Node.Set<Point3DInterpreter>();
                    //create default transformation to the current point position
                    var trsf = BuildTranslation(new Point3D(0, 0, 0), value);
                    if (IsFirstDependency())
                    {
                        // calculate the transformation relative to the current sketch's axis
                        if (builder.FunctionName == FunctionNames.Point)
                        {
                            //var axisLocation =
                            //   builder.Dependency[0].Reference.Children[1].Get<Axis3DInterpreter>().GpAxis.Location;
                            //axisLocation =
                            //    axisLocation.Transformed(
                            //         builder.Dependency[0].Reference.Get<TransformationInterpreter>().CurrTransform);
                            //if (builder.Dependency[0].ReferenceBuilder.Dependency[2].Node != null &&
                            //   builder.Dependency[0].ReferenceBuilder.Dependency[2].ReferenceBuilder.Node != null)
                            //{
                            //    var sketchNode = builder.Dependency[0].ReferenceBuilder.Dependency[2].ReferenceBuilder.Dependency[0].ReferenceBuilder.Node;
                            //    var sketchTrsf = sketchNode.Get<TransformationInterpreter>().CurrTransform;
                            //    axisLocation = axisLocation.Transformed(sketchTrsf);
                            //}
                            var sketchNode = builder.Dependency[0].ReferenceBuilder;
                            if (sketchNode.Node != null)
                            {
                                var transformedAxis = NodeBuilderUtils.GetTransformedAxis(sketchNode);
                                var location = transformedAxis.Location;
                                trsf = BuildTranslation(new Point3D(location), value);
                            }
                        }

                        var transform = builder.Node.Set<TransformationInterpreter>();
                        transform.CurrTransform = trsf;
                        transform.ResetPivot();
                        transform.OnModified();
                        geometryPoint.Value = new Point3D();
                    }
                    else
                    {
                        var currentTransform = builder.Node.Set<TransformationInterpreter>().CurrTransform;
                        var destPoint = new Point3D(value.GpPnt.Transformed(currentTransform.Inverted));
                        geometryPoint.Value = destPoint;
                    }
                }
            }


            public string ConstraintType
            {
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Reference);
                    Node.Set<ReferenceInterpreter>().ConstraintType = value;
                }
            }

            public bool IsValid
            {
                get
                {
                    if (Node == null)
                        return false;
                    var refInterpreter = Node.Get<ReferenceInterpreter>();
                    var result = true;
                    if (refInterpreter != null && refInterpreter.Node != null)
                    {
                        if (string.IsNullOrEmpty(refInterpreter.ConstraintType))
                            return true;
                        var refShapeName = FunctionUtils.GetFunctionName(refInterpreter.Node);
                        result = ReferencedShapeConstraints.Instance.IsOperationPossible(refShapeName,
                                                                                         refInterpreter.ConstraintType);
                        if (result)
                            result = Node.Parent.Get<FunctionInterpreter>().ValidateReferences();
                    }
                    return result;
                }
            }

            public gpAx1 TransformedAxis3D
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Axis3D);
                    var geometryPoint = Node.Get<Axis3DInterpreter>();
                    if (geometryPoint == null)
                        return null;
                    var builder = new NodeBuilder(Node.Parent);
                    return geometryPoint.GpAxis.Transformed(builder.Node.Get<TransformationInterpreter>().CurrTransform);
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Axis3D);
                    var geometry = Node.Set<Axis3DInterpreter>();
                    geometry.GpAxis = value;
                }
            }

            public Axis Axis3D
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Axis3D);
                    var geometryPoint = Node.Get<Axis3DInterpreter>();
                    return geometryPoint.Axis;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Axis3D);
                    var builder = new NodeBuilder(Node.Parent);
                    var geometryPoint = Node.Set<Axis3DInterpreter>();
                    var transform = builder.Node.Set<TransformationInterpreter>();

                    if (IsFirstDependency())
                    {
                        var axisLocation = new Point3D(value.GpAxis.Location);
                        var trsf = BuildTranslation(new Point3D(0, 0, 0), axisLocation);
                        transform.CurrTransform = trsf;
                        transform.ResetPivot();
                  //      var setValue = new gpAx1(new gpPnt(), value.GpAxis.Direction);
                   //     setValue.Transform(trsf);
                        var setValue = new gpAx1(axisLocation.GpPnt, value.GpAxis.Direction);
                        geometryPoint.GpAxis = setValue;
                    }
                    else
                    {
                        var currentTransform = transform.CurrTransform;
                        var destPoint = new Point3D(value.GpAxis.Location.Transformed(currentTransform.Inverted));
                        var setValue = new gpAx1(destPoint.GpPnt, value.GpAxis.Direction);
                        geometryPoint.GpAxis = setValue;
                    }
                }
            }

            public string Text
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Text);
                    var interpreter = Node.Get<StringInterpreter>();
                    if (interpreter == null)
                        return string.Empty;
                    return interpreter.Value;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Text);
                    Node.Set<StringInterpreter>().Value = value;
                }
            }

            /// <summary>
            ///   Gets the attached real
            /// </summary>
            public double Real
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Real);
                    var stdResult = Node.Get<RealInterpreter>();
                    return stdResult == null ? 0 : stdResult.Value;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Real);
                    var stdResult = Node.Set<RealInterpreter>();
                    stdResult.Value = value;
                }
            }


            /// <summary>
            ///   Gets the attached integer
            /// </summary>
            public int Integer
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Integer);
                    var stdResult = Node.Get<IntegerInterpreter>();
                    return stdResult == null ? 0 : stdResult.Value;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Integer);
                    var stdResult = Node.Set<IntegerInterpreter>();
                    stdResult.Value = value;
                }
            }


            /// <summary>
            ///   Gets the attached reference node
            /// </summary>
            public Node Reference
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Reference);
                    var stdResult = Node.Get<ReferenceInterpreter>();
                    return null == stdResult ? null : stdResult.Node;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Reference);
                    Node.Set<ReferenceInterpreter>().Node = value;
                }
            }

            public NodeBuilder ReferenceBuilder
            {
                get { return new NodeBuilder(Reference); }
                set { Reference = value.Node; }
            }

            /// <summary>
            ///   Gets the attached reference node
            /// </summary>
            public SceneSelectedEntity ReferenceData
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.Reference);
                    var stdResult = Node.Get<ReferenceInterpreter>();
                    return null == stdResult ? null : stdResult.Data;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.Reference);
                    Node.Set<ReferenceInterpreter>().Data = value;
                }
            }

            /// <summary>
            ///   Gets the attached reference list
            /// </summary>
            public List<SceneSelectedEntity> ReferenceList
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.ReferenceList);
                    var stdResult = Node.Set<ReferenceListInterpreter>();

                    return stdResult.Nodes;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.ReferenceList);
                    Node.Set<ReferenceListInterpreter>().Disable();
                    Node.Set<ReferenceListInterpreter>().Nodes = value;
                    Node.Set<ReferenceListInterpreter>().Enable();
                }
            }

            /// <summary>
            ///   Access the attached shape of the dependency
            /// </summary>
            public TopoDSShape Shape
            {
                get
                {
                    HasAttributeOrThrow(InterpreterNames.MeshTopoShape);
                    var shape = Node.Get<MeshTopoShapeInterpreter>();
                    return shape == null ? null : shape.Shape;
                }
                set
                {
                    HasAttributeOrThrow(InterpreterNames.MeshTopoShape);
                    Node.Set<MeshTopoShapeInterpreter>().Shape = value;
                }
            }

            /// <summary>
            ///   Access the attached refered shape of the dependency
            /// </summary>
            public TopoDSShape ReferedShape
            {
                get
                {
                    var sn = Reference;
                    var interpreter = sn.Get<TopoDsShapeInterpreter>();
                    return interpreter == null ? null : interpreter.Shape;
                }
            }

            private bool IsFirstDependency()
            {
                var index = Node.Index;
                var builder = new NodeBuilder(Node.Parent);
                var pos = 1;
                var children = builder.Node.Get<FunctionInterpreter>().Dependency.Children;
                foreach (var child in children)
                {
                    if (child.Name == InterpreterNames.Point3D || child.Name == InterpreterNames.Axis3D)
                        return pos == index;
                    pos++;
                }
                return true;
            }

            private static gpTrsf BuildTranslation(Point3D point1, Point3D point2)
            {
                var vector = new gpVec(point1.GpPnt, point2.GpPnt);
                var transformation = new gpTrsf();
                transformation.SetTranslation(vector);//{Translation = vector};
                return transformation;
            }

            #endregion

            #region Methods

            /// <summary>
            ///   Is an assert method and checks if the given parameter is with value Name. If is not, it will throw an exception
            /// </summary>
            /// <param name = "typeName">name of the checked type</param>
            private void HasAttributeOrThrow(string typeName)
            {
                if (Name != typeName)
                    throw new Exception("Invalid attribute type usage: Expected: " + Name + " but get actual type: " +
                                        typeName);
            }

            #endregion
        }

        #endregion
    }
}