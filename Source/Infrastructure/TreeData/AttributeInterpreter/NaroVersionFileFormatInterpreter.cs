#region Usings

using NaroConstants.Names;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class NaroVersionFileFormatInterpreter : AttributeInterpreterBase
    {
        public const string VersionFormatIndex = "1";

        public override void Serialize(AttributeData data)
        {
            data.WriteAttribute("NaroVersion", NaroAppConstantNames.Version);
            data.WriteAttribute("FormatVersion", VersionFormatIndex);
        }

        public override void Deserialize(AttributeData data)
        {
        }
    }
}