#region Usings

using System.Collections.Generic;
using System.IO;
using System.Reflection;

#endregion

namespace Naro.Infrastructure.Interface.Boo
{
    public class GlobalLibraryShapeFactory
    {
        private static readonly GlobalLibraryShapeFactory SingletonInstance = new GlobalLibraryShapeFactory();
        private readonly SortedDictionary<string, LibraryShape> _shapes = new SortedDictionary<string, LibraryShape>();

        private GlobalLibraryShapeFactory()
        {
        }

        public static GlobalLibraryShapeFactory Instance
        {
            get { return SingletonInstance; }
        }

        public bool Register<T>(string name) where T : LibraryShape, new()
        {
            return Register(name, new T());
        }

        private bool Register(string name, LibraryShape shape)
        {
            _shapes[name] = shape;
            return true;
        }

        public bool Register(string shapeName, string booScriptFileName, string className)
        {
            var a = CompileScriptToAssembly(booScriptFileName);
            var instanceObject = (LibraryShape) a.CreateInstance(className);
            return Register(shapeName, instanceObject);
        }

        public bool Register(string shapeName, string booScriptFileName)
        {
            var a = CompileScriptToAssembly(booScriptFileName);

            foreach (var type in a.GetTypes())
            {
                if (!type.IsClass) continue;
                if (type.IsAbstract) continue;
                if (!typeof (LibraryShape).IsAssignableFrom(type)) continue;
                var obj = a.CreateInstance(type.Name);
                if (obj is LibraryShape)
                    return Register(shapeName, (LibraryShape) obj);
            }
            return false;
        }

        private static Assembly CompileScriptToAssembly(string booScriptFileName)
        {
            if (!File.Exists(booScriptFileName)) return null;
            var fileContent = File.ReadAllText(booScriptFileName);
            var compilerContext = BooUtil.CompileCode(fileContent);
            return compilerContext.GeneratedAssembly;
        }

        public LibraryShape Get(string shapeName)
        {
            LibraryShape value;
            return !_shapes.TryGetValue(shapeName, out value) ? null : value;
        }
    }
}