#region Usings

using System.Collections.Generic;
using System.IO;
using System.Text;
using Boo.Lang.Interpreter;
using NaroPipes.Actions;
using TreeData.Utils;

#endregion

namespace BooEvaluator.Boo
{
    public class BooEvaluatorSingleton
    {
        private static readonly BooEvaluatorSingleton Singletoninstance = new BooEvaluatorSingleton();
        private readonly List<string> _scriptIntLines;
        private readonly List<string> _scriptLines;

        private BooEvaluatorSingleton()
        {
            _scriptLines = new List<string>(File.ReadAllLines(@"Boo\BooEvaluator.boo"));
            _scriptIntLines = new List<string>(File.ReadAllLines(@"Boo\BooEvaluatorInt.boo"));
        }

        public static BooEvaluatorSingleton Instance
        {
            get { return Singletoninstance; }
        }

        public double EvaluateInterpreted(DataPackage data)
        {
            var scriptLines = new List<string>(_scriptLines);
            var val = InterpretScriptLines(scriptLines, data);

            var evaluatedData = (double) val;
            return evaluatedData;
        }

        public int EvaluateInterpretedInt(DataPackage data)
        {
            var scriptLines = new List<string>(_scriptIntLines);
            var val = InterpretScriptLines(scriptLines, data);

            var evaluatedData = (int) val;
            return evaluatedData;
        }

        private static object InterpretScriptLines(IEnumerable<string> scriptLines, DataPackage data)
        {
            var interpreter = new InteractiveInterpreter {RememberLastValue = true};
            const string exprText = "%Expression%";
            var sb = new StringBuilder();
            foreach (var line in scriptLines)
            {
                var newLine = line;
                var pos = line.IndexOf(exprText);
                if (pos == -1)
                {
                    sb.AppendLine(newLine);
                    continue;
                }
                newLine = line.Substring(0, pos) + data.Text + line.Substring(pos + exprText.Length);
                sb.AppendLine(newLine);
            }
            sb.AppendLine("expr = BooEvaluator()");
            sb.AppendLine("result = expr.Evaluate()");
            var interpreterContext = interpreter.Eval(sb.ToString());
            Ensure.IsZero(interpreterContext.Errors.Count);
            return interpreter.GetValue("result");
        }
    }
}