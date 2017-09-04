#region Usings

#endregion

#region Usages

using System.Text;

#endregion

namespace ApiCommon.Generator
{
    public class TypeUtil
    {
        private readonly DataNode _dataNode;

        public TypeUtil(DataNode dataNode)
        {
            _dataNode = dataNode.Root;
        }

        public string Type(string typeName)
        {
            return GetItemType(typeName);
        }


        public static string ToCppNativeType(string value)
        {
            switch (value)
            {
                case "string":
                    return "char*";
                case "IntPtr":
                    return "void*";
                default:
                    return value;
            }
        }


        private string GetItemType(string name)
        {
            var dataNode = _dataNode;
            if (OccApiGenerator.IsPrimitiveType(name))
                return string.Empty;

            var generator = dataNode.Root.Set(Consts.Occ, Consts.Generator);
            var ns = generator.Set(Consts.NaroCppCore, Consts.Namespace);
            var occ = ns.Set(Consts.Occ, Consts.Namespace);
            var packageName = OccApiGenerator.PackageName(name);
            var packageNode = occ.Get(packageName, Consts.Namespace);
            if (packageNode == null) return string.Empty;
            foreach (var packageItem in packageNode.Children)
            {
                if (packageItem.Name == name)
                    return packageItem.NodeType;
            }
            return string.Empty;
        }

        private bool IsHandleType(DataNode dataNode, string name)
        {
            if (GetItemType(name) != Consts.Klass) return false;
            var generator = dataNode.Root.Set(Consts.Occ, Consts.Generator);
            var ns = generator.Set(Consts.NaroCppCore, Consts.Namespace);
            var occ = ns.Set(Consts.Occ, Consts.Namespace);
            var packageName = OccApiGenerator.PackageName(name);
            var packageNode = occ.Get(packageName, Consts.Namespace);
            var result = packageNode.Get(name, Consts.Klass);
            if (result == null) return false;
            if (name == "Standard_Transient") return true;
            if (name == "Prs3d_BasicAspect" || name == "Prs3d_CompositeAspect") return true;
            var implementsNode = result.Get(Consts.Implements);
            if (implementsNode == null) return false;
            var implementsTypeName = implementsNode.Name;
            if (implementsTypeName == "MMgt_TShared") return true;
            if (implementsTypeName == "Prs3d_BasicAspect") return true;
            if (implementsTypeName == "Prs3d_CompositeAspect") return true;
            return IsHandleType(dataNode, implementsTypeName);
        }

        public bool IsHandle(string name)
        {
            return IsHandleType(_dataNode, name);
        }

        public static string InstanceToPtr(string klassName, bool isHandle)
        {
            var sb = new StringBuilder();
            sb.Append(klassName);
            sb.Append("* result = (");
            sb.Append(klassName);
            sb.Append("*)");
            if (isHandle)
            {
                sb.Append("(((Handle_");
                sb.Append(klassName);
                sb.Append("*)instance)->Access())");
            }
            else
            {
                sb.Append("instance");
            }
            return sb.ToString();
        }
    }
}