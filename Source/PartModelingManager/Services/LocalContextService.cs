using System;
using Naro.Infrastructure.Interface.Services;
using OCNaroWrappers;
using TreeData.NaroData;

namespace Naro.PartModelingManager
{
    public class LocalContextService : ILocalContextService
    {
        Document _ocafDocument;
        Node _rootLabel;
        OCTopoDS_Shape _currentSelectedShape;
        OCgp_Vec _projectionVector;
        OCgp_Pnt _viewPointPosition;
        OCgp_Vec _highPointVector;
        private bool _isPerspective;

        public Document CurrentOcafDocument
        {
            get { return _ocafDocument; }
            set { _ocafDocument = value; }
        }

        public Node RootLabel
        {
            get { return _rootLabel; }
            set { _rootLabel = value; }
        }

        public OCTopoDS_Shape CurrentSelectedShape
        {
            get { return _currentSelectedShape; }
            set { _currentSelectedShape = value; }
        }

        // Projection vector Proj(DX,DY,DZ)
        public OCgp_Vec ProjectionVector
        {
            get { return _projectionVector; }
            set { _projectionVector = value; }
        }

        // Position of the view point At(XAt,YAt,ZAt)
        public OCgp_Pnt ViewPointPosition
        {
            get { return _viewPointPosition; }
            set { _viewPointPosition = value; }
        }

        // Vector giving the position of the high point Up(Vx,Vy,Vz)
        public OCgp_Vec HighPointVector
        {
            get { return _highPointVector; }
            set { _highPointVector = value; }
        }

        public bool IsPerspective
        {
            get { return _isPerspective; }
            set { _isPerspective = value; }
        }
    }
}
