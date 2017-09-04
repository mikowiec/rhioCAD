#region Usings

using System.Collections.Generic;
using System.Globalization;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal abstract class ExportRealBased : ExportBuilderBasedInterpreter
    {
        public override void PostconditionCode(AttachedNodeData data, List<string> lines)
        {
        }

        protected static string _(double val)
        {
            return "cast(double, " + val.ToString(CultureInfo.InvariantCulture) + ")";
        }
    }
}