#region Usings

using System.Collections.Generic;
using ConstraintsModule.Views;
using NaroSketchAdapter.Views;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter
{
    public class SketchSolveUpdater
    {
        private readonly Document _document;
        private SortedDictionary<string, bool> _constraintNames;
        private ConstraintDocumentHelper _helper;
        private Node _sketchNode;

        public SketchSolveUpdater(Document document)
        {
            _document = document;
            document.BeforeChanged += OnPreModify;
        }

        private void PopulateConstraintNames(Document document)
        {
            _helper = new ConstraintDocumentHelper(document, _sketchNode);
            var constraintFunctions = _helper.ConstraintMapper.Constraints.Keys;
            _constraintNames = new SortedDictionary<string, bool>();
            foreach (var functionName in constraintFunctions)
                _constraintNames[functionName] = false;
        }

        private void OnPreModify()
        {
            _sketchNode = _document.Root.Get<DocumentContextInterpreter>().ActiveSketch == -1 ? new SketchCreator(_document, false).CurrentSketch :
                  _document.Root[_document.Root.Get<DocumentContextInterpreter>().ActiveSketch];
            if (_sketchNode == null)
                return;
            if (_constraintNames == null)
                PopulateConstraintNames(_document);

            _helper = new ConstraintDocumentHelper(_document, _sketchNode);
            _helper.ComputeSolverOnImpactedNodes(_constraintNames);
        }
    }
}