#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NaroConstants.Names;

#endregion

namespace PluginInterface
{
    public static class PluginUtil
    {
        public static bool IsNaroPlugin(string assemblyName)
        {
            Assembly assembly;
            try
            {
                assembly = Assembly.LoadFile(assemblyName);
            }
            catch (Exception)
            {
                return false;
            }
            try
            {
                foreach (var type in assembly.GetTypes())
                {
                    var customAttributes = type.GetCustomAttributes(typeof (NaroRegisterAttribute), true);
                    if (customAttributes.Length <= 0) continue;
                    try
                    {
                        var method = type.GetMethod("Register");

                        return method != null;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static Dictionary<string, bool> AutoLoadPlugins()
        {
            var result = new Dictionary<string, bool>();
            var autoLoadPluginsFileName = NaroAppConstantNames.PluginFileDescription;
            if (!File.Exists(autoLoadPluginsFileName)) return result;
            var fileLines = File.ReadAllLines(autoLoadPluginsFileName);
            foreach (var line in fileLines)
            {
                var trimLine = line.Trim();
                if (string.IsNullOrEmpty(trimLine))
                    continue;
                if (trimLine[0] == ';' || trimLine[0] == '#')
                {
                    trimLine = trimLine.Remove(0, 1).Trim();
                    result[trimLine] = false;
                    continue;
                }
                result[trimLine] = true;
            }

            return result;
        }
    }
}