#region Usings

using System.Collections.Generic;
using BooDocumentImportExport.Modifiers.BooExport.Interpreters;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport
{
    internal class BooExportInterpreterFactory
    {
        private static readonly BooExportInterpreterFactory SingletonInstance = new BooExportInterpreterFactory();
        private readonly SortedDictionary<int, IHandleBooExportInterpreter> _handlers;

        private BooExportInterpreterFactory()
        {
            _handlers = new SortedDictionary<int, IHandleBooExportInterpreter>();
            Register<FunctionInterpreter>(new ExportFunctionInterpreter());
            Register<IntegerInterpreter>(new ExportIntegerInterpreter());
            Register<RealInterpreter>(new ExportRealInterpreter());
            Register<Axis3DInterpreter>(new ExportAxisInterpreter());
            Register<Point3DInterpreter>(new ExportPoint3DInterpreter());

            Register<ReferenceInterpreter>(new ExportReferenceInterpreter());
            Register<ReferenceListInterpreter>(new ExportReferenceListInterpreter());
        }

        public static BooExportInterpreterFactory Instance
        {
            get { return SingletonInstance; }
        }

        public void Register<T>(IHandleBooExportInterpreter interpreter) where T : AttributeInterpreterBase
        {
            var typeId = typeof (T).GetHashCode();
            _handlers[typeId] = interpreter;
        }

        public void PreHandle(AttributeInterpreterBase interpreter, AttachedNodeData data, List<string> lines)
        {
            var typeId = interpreter.GetType().GetHashCode();
            IHandleBooExportInterpreter item;
            if (!_handlers.TryGetValue(typeId, out item)) return;
            item.PreconditionCode(data, lines, interpreter);
        }

        public void PostHandle(AttributeInterpreterBase interpreter, AttachedNodeData data, List<string> lines)
        {
            var typeId = interpreter.GetType().GetHashCode();
            IHandleBooExportInterpreter item;
            if (!_handlers.TryGetValue(typeId, out item)) return;
            item.PostconditionCode(data, lines);
        }
    }
}