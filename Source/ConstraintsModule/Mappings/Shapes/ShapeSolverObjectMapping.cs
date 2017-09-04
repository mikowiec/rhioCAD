#region Usings

using System.Collections.Generic;
using ConstraintsModule.Primitives;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace ConstraintsModule.Mappings.Shapes
{
    public abstract class ShapeSolverObjectMapping : ISolverObjectMapping
    {
        protected NodeBuilder _builder;
      //  protected Sketch3DTo2DTranslator _coordinateTranslator;
        protected Dictionary<int, object> _globalObjectMapping;
        protected List<DoubleRefObject> _parameters;

        #region ISolverObjectMapping Members

        //public void Map(NodeBuilder builder, List<DoubleRefObject> parameters,
        //                Dictionary<int, object> globalObjectMapping, Sketch3DTo2DTranslator coordinateTranslator)
        //{
        //    SetParameters(builder, parameters, globalObjectMapping, coordinateTranslator);
        //    MapToSolver();
        //}

        //public void Unmap(NodeBuilder builder, List<DoubleRefObject> parameters,
        //                  Dictionary<int, object> globalObjectMapping, Sketch3DTo2DTranslator coordinateTranslator)
        //{
        //    SetParameters(builder, parameters, globalObjectMapping, coordinateTranslator);
        //    UnmapFromSolver();
        //}

        #endregion

        //private void SetParameters(NodeBuilder builder, List<DoubleRefObject> parameters,
        //                           Dictionary<int, object> globalObjectMapping,
        //                           Sketch3DTo2DTranslator coordinateTranslator)
        //{
        //    _builder = builder;
        //    _parameters = parameters;
        //    _globalObjectMapping = globalObjectMapping;
        //    _coordinateTranslator = coordinateTranslator;
        //}

        //protected Point BuildCoordinate(Point3D originalCoordinate)
        //{
        //    var parameters = _parameters;
        //    var translate = _coordinateTranslator.Translate(originalCoordinate);
        //    var refX = new DoubleRefObject(translate.X);
        //    var refY = new DoubleRefObject(translate.Y);
        //    parameters.Add(refX);
        //    parameters.Add(refY);
        //    return new Point(refX, refY);
        //}

        protected T MappedObject<T>(int referencePoint0)
        {
            return (T) _globalObjectMapping[referencePoint0];
        }

        protected T MappedReference<T>(int referenceIndex)
        {
            var referenceData = _builder[referenceIndex].Reference.Index;
            return MappedObject<T>(referenceData);
        }

        protected abstract void MapToSolver();
        protected abstract void UnmapFromSolver();

        protected void MapSelf(object line)
        {
            _globalObjectMapping[_builder.Node.Index] = line;
        }

        protected T UnmapSelf<T>()
        {
            return (T) _globalObjectMapping[_builder.Node.Index];
        }
    }
}