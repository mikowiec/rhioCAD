#region Usings

using System.Collections.Generic;
using BooEvaluator.Boo;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;

using PartModellingLogic.Inputs.Naro.Infrastructure;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    public class CoordinateParser : PipeBase
    {
        public CoordinateParser()
            : base(InputNames.CoordinateParser)
        {
            DefineTokens();
        }

        private ParserStage Stage { get; set; }
        private string[] Tokens { get; set; }
        private List<char> Separators { get; set; }

        private string CommandName
        {
            get { return Tokens == null || Tokens.Length == 0 ? string.Empty : Tokens[0]; }
        }

        public override void OnRegister()
        {
            DependsOn(InputNames.CommandLineView, SourceCommandLineHandler);
            AddNotificationHandler(CoordinatateParserNames.SetStage, OnSetStage);
            AddNotificationHandler(CoordinatateParserNames.SetLastReal, OnSetLastReal);
            AddNotificationHandler(NotificationNames.SetLastPoint, OnSetLastPoint);
            AddNotificationHandler(CoordinatateParserNames.SetHint, OnSetHint);
            AddNotificationHandler(CoordinatateParserNames.SetEditingText, OnSetEditingText);
        }

        private void OnSetEditingText(DataPackage data)
        {
            Inputs[InputNames.CommandLineView].Send(CoordinatateParserNames.SetEditingText, data);
        }

        private void OnSetHint(DataPackage data)
        {
            ActionsGraph[InputNames.CommandLineView].Send(CoordinatateParserNames.SetHint, data);
        }

        private void OnSetLastPoint(DataPackage data)
        {
            _lastPoint = data.Get<Point3D>();
        }

        private void OnSetLastReal(DataPackage data)
        {
            _lastReal = data.Get<double>();
        }

        private void OnSetStage(DataPackage data)
        {
            Stage = data.Get<ParserStage>();
        }

        public override void OnDisconnect()
        {
            Stage = ParserStage.None;
        }

        private static object ParseIntegerValue(string command)
        {
            object data = null;
            int result;
            if (int.TryParse(command, out result))
                data = result;
            return data;
        }

        private object ParseAxisValue(string command)
        {
            object result = null;
            var words = command.Split(',');
            switch (words.Length)
            {
                case 2:
                    _lastPoint.X = ParseDoubleArgument(_lastPoint.X, words[0]);
                    _lastPoint.Y = ParseDoubleArgument(_lastPoint.Y, words[1]);
                    _lastPoint.Z = 0;
                    result = new gpAx1(_lastPoint.GpPnt, new gpDir(0, 0, 1));
                    break;
                case 3:
                    _lastPoint.X = ParseDoubleArgument(_lastPoint.X, words[0]);
                    _lastPoint.Y = ParseDoubleArgument(_lastPoint.Y, words[1]);
                    _lastPoint.Z = ParseDoubleArgument(_lastPoint.Z, words[2]);
                    result = new gpAx1(_lastPoint.GpPnt, new gpDir(0, 0, 1));
                    break;
                case 6:
                    {
                        _lastPoint.X = ParseDoubleArgument(_lastPoint.X, words[0]);
                        _lastPoint.Y = ParseDoubleArgument(_lastPoint.Y, words[1]);
                        _lastPoint.Z = ParseDoubleArgument(_lastPoint.Z, words[2]);
                        var dir = new Point3D
                                      {
                                          X = ParseDoubleArgument(_lastPoint.X, words[3]),
                                          Y = ParseDoubleArgument(_lastPoint.Y, words[4]),
                                          Z = ParseDoubleArgument(_lastPoint.Z, words[5])
                                      };
                        result = new gpAx1(_lastPoint.GpPnt, new gpDir(dir.X, dir.Y, dir.Z));
                    }
                    break;
            }
            return result;
        }

        public static Point3D ParsePointValue(string command, Point3D lastPoint)
        {
            var data = new Point3D();
            var words = command.Split(',');
            switch (words.Length)
            {
                case 3:
                    lastPoint.X = ParseDoubleArgument(lastPoint.X, words[0]);
                    lastPoint.Y = ParseDoubleArgument(lastPoint.Y, words[1]);
                    lastPoint.Z = ParseDoubleArgument(lastPoint.Z, words[2]);
                    data = lastPoint;
                    break;
                case 2:
                    lastPoint.X = ParseDoubleArgument(lastPoint.X, words[0]);
                    lastPoint.Y = ParseDoubleArgument(lastPoint.Y, words[1]);
                    lastPoint.Z = 0;
                    data = lastPoint;
                    break;
            }
            return data;
        }

        public static double ParseDoubleArgument(double refValue, string word)
        {
            var relative = refValue;

            word = word.Trim();
            if (string.IsNullOrEmpty(word))
                return relative;
            if (word[word.Length - 1] == 'r')
            {
                word = word.Remove(word.Length - 1);
                try
                {
                    var result = BooEval.GetDouble(word);
                    relative += result;
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    var result = BooEval.GetDouble(word);
                    relative = result;
                }
                catch
                {
                }
            }
            return relative;
        }

        private void HandleParserStage(string command)
        {
            object data = null;
            switch (Stage)
            {
                case ParserStage.None:
                    AddData(CoordinatateParserNames.ChangeCommand, CommandName);
                    return;
                case ParserStage.IntegerAsked:
                    data = ParseIntegerValue(command);
                    break;
                case ParserStage.RealAsked:
                    data = ParseDoubleArgument(_lastReal, command);
                    break;
                case ParserStage.PointAsked:
                    _lastPoint = ParsePointValue(command, _lastPoint);
                    data = _lastPoint;
                    break;
                case ParserStage.AxisAsked:
                    data = ParseAxisValue(command);
                    break;
                case ParserStage.Unknown:
                    AddData(CoordinatateParserNames.ChangeCommand, command);
                    return;
            }
            if (data != null)
                AddData(CoordinatateParserNames.ParsedValue, data);
        }

        private void SourceCommandLineHandler(DataPackage data)
        {
            var command = data.Get<string>();
            Tokens = command.Split(Separators.ToArray());
            HandleParserStage(command);
        }

        #region Tokens initialization

        //latest parsed point, defaults to (0, 0, 0)
        private Point3D _lastPoint;
        private double _lastReal;

        private void DefineTokens()
        {
            BuildSeparatorList();
            Tokens = new string[0];
        }

        private void BuildSeparatorList()
        {
            Separators = new List<char> {',', '(', ')'};
        }

        #endregion
    }
}