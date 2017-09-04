#region Usings

using System.Text;

#endregion

namespace NaroSetup.Pages.Rendering.Logic
{
    public class Shader
    {
        public Shader(string name)
        {
            Name = name;
        }

        public string SunflowDescription
        {
            get { return ComputeDescription(); }
        }

        public string Name { get; private set; }
        public string Definition { get; set; }

        private string ComputeDescription()
        {
            var sb = new StringBuilder();
            sb.AppendLine("shader {");
            sb.Append("name \"");
            sb.Append(Name);
            sb.AppendLine("\"");
            sb.AppendLine(Definition);
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}