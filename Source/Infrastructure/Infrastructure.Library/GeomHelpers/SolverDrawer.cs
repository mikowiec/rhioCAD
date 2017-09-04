#region Usings

using Naro.PartModeling;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.AIS;
using NaroPipes.Actions;

using ShapeFunctionsInterface.Interpreters;
using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Library.GeomHelpers
{
    public class SolverDrawer
    {
        private readonly Document _solverDrawerDocument = new Document();
        private AISInteractiveContext _context;

        public SolverDrawer(AISInteractiveContext context)
        {
            SetContext(context);
        }

        public Document Document
        {
            get { return _solverDrawerDocument; }
        }

        private void SetContext(AISInteractiveContext context)
        {
            _context = context;
            _solverDrawerDocument.Root.Set<DocumentContextInterpreter>().Context = _context;
        }

        public void Show(SolverPreviewObject geometry)
        {
            geometry.Preview(_solverDrawerDocument);
        }

        public void SetActionGraph(ActionsGraph actionsGraph)
        {
            _solverDrawerDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = actionsGraph;
        }

        public void Transact()
        {
            _solverDrawerDocument.Transact();
        }
    }
}