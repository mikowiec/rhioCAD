#region Usings

using System;
using System.Reflection;
using ErrorReportCommon.Messages;
using log4net;
using NaroPipes.Actions;
using PluginInterface;
using TreeData.Utils;

#endregion

namespace BooCoreScript
{
    public class BooPluginLoader
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (BooPluginLoader));
        private readonly ActionsGraph _actionsGraph;

        public BooPluginLoader(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
        }

        public bool RegisterPlugin(string assemblyName, bool onDocumentStartup)
        {
            Assembly assembly;
            try
            {
                assembly = Assembly.Load(assemblyName);
            }
            catch (Exception)
            {
                NaroMessage.Show(@"Plugin cannot be loaded");
                return false;
            }
            return PluginModifierRegister(assembly, onDocumentStartup);
        }


        private bool PluginModifierRegister(Assembly otherAssembly, bool onDocumentStartup)
        {
            foreach (var type in otherAssembly.GetTypes())
            {
                var customAttributes = type.GetCustomAttributes(typeof (NaroRegisterAttribute), true);
                if (customAttributes.Length <= 0) continue;
                var attr = (NaroRegisterAttribute) customAttributes[0];
                if (!attr.OnDocumentSpawn || !onDocumentStartup) continue;
                try
                {
                    var registeringInstance = otherAssembly.CreateInstance(type.FullName);

                    Ensure.IsNotNull(registeringInstance, "Cannot create registering class. Did you made it abstract?");
                    var method = type.GetMethod("Register");
                    method.Invoke(registeringInstance, new[] {_actionsGraph});
                    //ifc.Register(_actionsGraph);
                    return true;
                }
                catch
                {
                    Log.Info("Error on loading plugin");
                }
            }
            return true;
        }
    }
}