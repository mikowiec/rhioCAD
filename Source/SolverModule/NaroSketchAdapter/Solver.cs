#region Usings

using System.Collections.Generic;
using Naro.PartModeling;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.gp;
using NaroSketchAdapter.Rules;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter
{
    public class Solver : GeometricSolver
    {
        #region Constructor

        public Solver(Document document)
        {
            Geometry = new List<SolverGeometricObject>();
            LastGeometry = new List<SolverGeometricObject>();
            _solverDocument = new Document();
            SetDocument(document);
            document.Changed += OnDocumentCommit;

            RuleSet = new RuleSet();
        }

        #endregion

        #region Overriden Methods

        public override List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView,
                                                                              Point3D coordinate)
        {
            return RuleSet.GetInterestingCloseGeometry(planeOfTheView, coordinate);
        }

        public override List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView,
                                                                              Point3D currentPoint,
                                                                              Point3D initialPosition)
        {
            return RuleSet.GetInterestingCloseGeometry(planeOfTheView, currentPoint, initialPosition);
        }

        public override void Refresh()
        {
            var solverExtractLogic = new SolverExtractLogic(Document, this);
            solverExtractLogic.ComputeSolverGeometry();
        }

        #endregion

        #region Public methods

        private void SetDocument(Document document)
        {
            RegisterToDocumentCommit(document);
            _solverDocument.Root.Set<DocumentContextInterpreter>().Context =
                Document.Root.Set<DocumentContextInterpreter>().Context;
            _solverDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph =
                Document.Root.Set<ActionGraphInterpreter>().ActionsGraph;
        }

        public void EnableRule(string ruleName)
        {
            if (!RuleSet.Rules.ContainsKey(ruleName)) return;
            RuleSet.Rules[ruleName].Enabled = true;
            Refresh();
        }

        public void DisableRule(string ruleName)
        {
            if (!RuleSet.Rules.ContainsKey(ruleName)) return;
            RuleSet.Rules[ruleName].Enabled = false;
            Refresh();
        }

        public void EnableAllRules()
        {
            foreach (var rule in RuleSet.Rules.Values)
                rule.Enabled = true;
            Refresh();
        }

        public void DisableAllRules()
        {
            foreach (var rule in RuleSet.Rules.Values)
                rule.Enabled = false;
            Refresh();
        }

        #endregion

        #region Methods

        private void RegisterToDocumentCommit(Document document)
        {
            Document = document;
        }

        private void OnDocumentCommit()
        {
            Refresh();
        }

        #endregion

        #region Data members

        private readonly Document _solverDocument;

        #endregion
    }
}