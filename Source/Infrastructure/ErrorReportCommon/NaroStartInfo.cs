#region Usings

using System.Text;

#endregion

namespace ErrorReportCommon
{
    public class NaroStartInfo
    {
        private static readonly NaroStartInfo SingletonInstance = new NaroStartInfo();

        private NaroStartInfo()
        {
        }

        public static NaroStartInfo Instance
        {
            get { return SingletonInstance; }
        }

        public string[] Arguments { get; set; }

        public string FullArguments
        {
            get
            {
                if (Arguments.Length == 0)
                    return string.Empty;
                var sb = new StringBuilder();
                sb.Append(Arguments[0]);
                for (var i = 1; i < Arguments.Length; i++)
                {
                    var arg = Arguments[i];
                    sb.Append(' ');
                    sb.Append(arg);
                }
                return sb.ToString();
            }
        }
    }
}