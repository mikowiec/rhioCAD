#region Usings

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.IO;
using Boo.Lang.Compiler.Pipelines;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace Naro.Infrastructure.Interface.Boo
{
    public static class BooUtil
    {
        public const string BooScrptClassName = "Test";

        public static CompilerContext CompileCode(string script)
        {
            var compiler = new BooCompiler();
            compiler.Parameters.Input.Add(new StringInput("<script>", script));
            compiler.Parameters.Pipeline = new Run();

            return compiler.Run();
        }

        public static CompilerContext CompileScript(IEnumerable<string> scriptLines)
        {
            var scriptBuilder = BuildScriptBuilderFromLines(scriptLines);

            return CompileCode(scriptBuilder.ToString());
        }

        public static CompilerContext GetCompilerContext(string script, bool isScript)
        {
            CompilerContext context;
            if (isScript)
            {
                var lines = script.Split('\n');
                context = CompileScript(new List<string>(lines));
            }
            else
                context = CompileCode(script);
            return context;
        }

        private static StringBuilder BuildScriptBuilderFromLines(IEnumerable<string> scriptLines)
        {
            var originalScriptLines = File.ReadAllLines(NaroAppConstantNames.BooScriptTemplate);
            var scriptBuilder = new StringBuilder();
            foreach (var scriptLine in originalScriptLines)
                scriptBuilder.AppendLine(scriptLine);

            var isInMethodBody = true;
            foreach (var scriptLine in scriptLines)
            {
                if (scriptLine.Contains("class ") || scriptLine.Contains("def "))
                    isInMethodBody = false;
                if (isInMethodBody)
                    scriptBuilder.Append("\t\t");
                scriptBuilder.AppendLine(scriptLine);
            }
            return scriptBuilder;
        }

        /// <summary>
        /// </summary>
        /// <param name = "assembly"></param>
        /// <param name = "classNameInstance"></param>
        /// <param name = "methodName"></param>
        /// <param name = "arguments"></param>
        /// <returns>The instance that was calling the method</returns>
        public static object CallMethodFromAssembly(Assembly assembly, string classNameInstance, string methodName,
                                                    object[] arguments)
        {
            var type = assembly.GetType(classNameInstance);
            var instance = assembly.CreateInstance(classNameInstance);
            var runTestMethod = type.GetMethod(methodName);
            runTestMethod.Invoke(instance, arguments);
            return instance;
        }

        public static void CallInstanceMethod(Assembly assembly, string classNameInstance, object instance,
                                              string methodName)
        {
            var type = assembly.GetType(classNameInstance);
            var runTestMethod = type.GetMethod(methodName);
            runTestMethod.Invoke(instance, new object[0]);
        }

        public static void CallInstanceMethod(Assembly assembly, string classNameInstance, object instance,
                                              string methodName, object argument)
        {
            var type = assembly.GetType(classNameInstance);
            var runTestMethod = type.GetMethod(methodName);
            runTestMethod.Invoke(instance, new[] {argument});
        }

        public static void ExecuteBooProgram(ActionsGraph actionsGraph, string fileName)
        {
            var scriptLines = File.ReadAllText(fileName);
            var context = CompileCode(scriptLines);

            ExecuteBooProgram(fileName, context, actionsGraph);
        }

        public static void ExecuteBooProgram(string fileName, CompilerContext context, ActionsGraph actionsGraph)
        {
            if (context.Errors.Count > 0)
            {
                Ensure.AreEqual(0, context.Errors.Count,
                                string.Format(
                                    "The compile script should have no error. The file {0} have this eroor {1}",
                                    fileName, context.Errors[0]));
            }
            var assembly = context.GeneratedAssembly;
            Ensure.IsNotNull(assembly);
            const string classNameInstance = "Test";
            const string methodName = "Do";
            var arguments = new object[] {actionsGraph};
            CallMethodFromAssembly(assembly, classNameInstance, methodName, arguments);
        }

        public static void ExecuteBooScript(ActionsGraph actionsGraph, string fileName)
        {
            var scriptLines = new List<string>(File.ReadAllLines(fileName));
            var context = CompileScript(scriptLines);
            ExecuteBooScript(fileName, context, actionsGraph);
        }

        private static ActionsGraph GetCurrentActionGraph(ActionsGraph actionsGraph)
        {
            return actionsGraph[InputNames.CurrentDocumentInput].GetData(NotificationNames.GetContainer).Get
                <ActionsGraph>();
        }

        public static void ExecuteBooScript(string fileName, CompilerContext context, ActionsGraph actionsGraph)
        {
            if (context.Errors.Count > 0)
            {
                Ensure.AreEqual(0, context.Errors.Count,
                                string.Format(
                                    "The compile script should have no error. The file {0} have this eroor {1}",
                                    fileName, context.Errors[0]));
            }
            var assembly = context.GeneratedAssembly;
            var currentGraph = GetCurrentActionGraph(actionsGraph);
            var document = currentGraph.InputContainer[InputNames.Document].Get<Document>();
            var instance = CallMethodFromAssembly(assembly, BooScrptClassName, "SetInternalData",
                                                  new object[] {actionsGraph});
            document.Transact();
            CallInstanceMethod(assembly, BooScrptClassName, instance, "Do");
            document.Commit(string.Format("Executed scripts from file: {0}", fileName));
        }
    }
}