#region Usings

using System.Collections.Generic;
using System.Linq;
using NaroConstants.Names;

#endregion

namespace ShapeFunctionsInterface.Utils
{
    public class AutoNumbering
    {
        #region Constructor

        public AutoNumbering()
        {
            Indexes = new SortedDictionary<string, int>();
        }

        #endregion

        #region Properties

        public SortedDictionary<string, int> Indexes { get; internal set; }

        public bool Freeze { get; set; }

        #endregion

        #region Public Methods

        public string GetNextIndexName(string shapeName)
        {
            if (!FunctionNames.GetSketchShapes().Contains(shapeName) && !FunctionNames.GetSolids().Contains(shapeName) && shapeName != FunctionNames.Sketch)
                return shapeName;
            if (!Indexes.ContainsKey(shapeName))
            {
                Indexes[shapeName] = 1;
            }
            else
            {
                if (!Freeze)
                {
                    Indexes[shapeName] ++;
                }
            }
            return shapeName + "-" + Indexes[shapeName];
        }

        public int GetNextIndexNumber(string shapeName)
        {
            if (!Indexes.ContainsKey(shapeName))
            {
                Indexes[shapeName] = 1;
            }
            else
            {
                if (!Freeze)
                {
                    Indexes[shapeName]++;
                }
            }
            return Indexes[shapeName];
        }


        #endregion
    }
}