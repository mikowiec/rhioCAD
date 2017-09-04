#region Usings

using Naro.Infrastructure.Interface.Boo;
using TreeData.AttributeInterpreter;

#endregion

namespace BooGearPlugin.Modifiers
{
    public abstract class BooLibraryShape : LibraryShape
    {
        protected void AddPoint3DDependency()
        {
            AddDependency<Point3D>();
        }

        protected void AddRealDependency()
        {
            AddDependency<double>();
        }

        protected void AddIntDependency()
        {
            AddDependency<int>();
        }

        protected void AddPoint3DDependency(Point3D value)
        {
            AddDependency(value);
        }

        protected void AddRealDependency(double value)
        {
            AddDependency(value);
        }

        protected void AddIntDependency(int value)
        {
            AddDependency(value);
        }
    }
}