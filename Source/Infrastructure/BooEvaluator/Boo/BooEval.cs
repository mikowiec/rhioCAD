#region Usings

using System;
using System.Globalization;
using NaroPipes.Actions;

#endregion

namespace BooEvaluator.Boo
{
    public static class BooEval
    {
        public static bool IsInterpreted { private get; set; }

        public static double GetDouble(string text)
        {
            try
            {
                return Convert.ToDouble(text, CultureInfo.CurrentCulture);//CultureInfo.InvariantCulture);
            }
            catch
            {
                return IsInterpreted ? BooEvaluatorSingleton.Instance.EvaluateInterpreted(new DataPackage(text)) : 0;
            }
        }

        public static double GetDouble(string text, CultureInfo cultureInfo)
        {
            try
            {
                return Convert.ToDouble(text, cultureInfo);
            }
            catch
            {
                return IsInterpreted ? BooEvaluatorSingleton.Instance.EvaluateInterpreted(new DataPackage(text)) : 0;
            }
        }

        public static int GetInt32(string text)
        {
            try
            {
                return Convert.ToInt32(text, CultureInfo.InvariantCulture);
            }
            catch
            {
                return IsInterpreted ? BooEvaluatorSingleton.Instance.EvaluateInterpretedInt(new DataPackage(text)) : 0;
            }
        }
    }
}