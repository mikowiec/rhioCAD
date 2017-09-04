#region Usings

using System;
using System.Windows.Forms;
using System.Windows.Input;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Interface.Views;
using Naro.Infrastructure.Library.Qos;
//using NaroCAD.SolverModule.Rules;
using NaroConstants.Names;
using NaroPipes.Constants;
using NaroSetup;
using NaroSetup.Pages.Solver;
using NaroSketchAdapter.Rules;
using NaroSketchAdapter.Rules.Naro;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using Naro.Infrastructure.Library.Geometry;

#endregion

namespace Naro.PartModeling
{
    public partial class MultiViewWorkItemController
    {
        private void SwitchUserAction(string actionType)
        {
            Log.InfoFormat("Switching action to {0}", actionType);

            _actionGraph.SwitchAction(actionType);
        }

        private void UpdateSolverOptions()
        {
            var solver = _solver;

            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);
            solver.RuleSet = new RuleSet();
            var rules = solver.RuleSet.Rules;
            var pointPrecision = optionsSection.GetDoubleValue(1);

            // Rules are added in priority order
            if (optionsSection.GetBoolValue(1))
            {
                rules[SolverRuleNames.PointMatch] = new PointMatch(solver, pointPrecision);
                QosFactory.Instance.Create(QosNames.PointMatchLock, 120,
                                           "Point Matching works too slow! Do you want to disable it?").Payload +=
                    PointMatchLockPayload;
            }

            if (optionsSection.GetBoolValue(4))
            {
                rules[SolverRuleNames.EdgeMatch] = new EdgeMatch(solver, pointPrecision);
                QosFactory.Instance.Create(QosNames.EdgeMatchLock, 120,
                                           "Edge Matching works too slow! Do you want to disable it?").Payload +=
                    EdgeMatchLockPayload;
            }

            if (optionsSection.GetBoolValue(5))
            {
                rules[SolverRuleNames.EdgeContinuationMatch] = new EdgeContinuationMatch(solver, pointPrecision);
                QosFactory.Instance.Create(QosNames.EdgeContinuationMatchLock, 120,
                                           "Edge Continuation Matching works too slow! Do you want to disable it?").
                    Payload += EdgeContinuationMatchLockPayload;
            }

            if (optionsSection.GetBoolValue(3))
            {
                rules[SolverRuleNames.PlaneMatch] = new PlaneMatch(solver, pointPrecision);
                QosFactory.Instance.Create(QosNames.PlaneMatchLock, 120,
                                           "Plane Matching works too slow! Do you want to disable it?").Payload +=
                    PlaneMatchLockPayload;
            }

            if (optionsSection.GetBoolValue(2))
            {
                var precision = optionsSection.GetDoubleValue((int)HinterOptionFields.ParallelMatch);
                rules[SolverRuleNames.ParallelLineMatch] = new ParallelLineMatch(solver, precision);
                rules[SolverRuleNames.OrthogonalLineMatch] = new OrthogonalLineMatch(solver, precision);
                QosFactory.Instance.Create(QosNames.ParallelLineLock, 120,
                                           "Parallel Line Matching works too slow! Do you want to disable it?").Payload
                    += ParallelLineLockPayload;
            }
            if (optionsSection.GetBoolValue(6))
            {
                rules[SolverRuleNames.VerticalLineMatch] = new VerticalLineMatch(solver,
                                                                                 optionsSection.GetDoubleValue(6));
                rules[SolverRuleNames.HorizontalLineMatch] = new HorizontalLineMatch(solver,
                                                                                     optionsSection.GetDoubleValue(6));
                QosFactory.Instance.Create(QosNames.VerticalLineMatchLock, 120,
                                           "Vertical Line Matching works too slow! Do you want to disable it?").Payload
                    += VerticalLineMatchLockPayload;
                QosFactory.Instance.Create(QosNames.HorizontalLineMatchLock, 120,
                                           "Horizontal Line Matching works too slow! Do you want to disable it?").
                    Payload += HorizontalLineMatchLockPayload;
            }
            if (optionsSection.GetBoolValue(7))
            {
                QosFactory.Instance.Create(QosNames.EdgeIntersectionLock, 120,
                                           "Edge Intersection precomputation works too slow! Do you want to disable it?")
                    .Payload += EdgeIntersectionMatchLockPayload;
            }
            if (optionsSection.GetBoolValue(10))
            {
                //rules[SolverRuleNames.OrthogonalAxis] = new OrthogonalLineMatch(solver);
            }
            if (optionsSection.GetBoolValue(12))
            {
                rules[SolverRuleNames.PolarAxis] = new PolarLineMatch(solver, optionsSection.GetDoubleValue(11));
            }
            if (optionsSection.GetBoolValue(13))
            {
                rules[SolverRuleNames.SameCoordinateMatch] = new SameCoordinatePoints(solver, pointPrecision);
            }
            solver.Refresh();
        }

        private void EdgeContinuationMatchLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(5, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private void VerticalLineMatchLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(6, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private void HorizontalLineMatchLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(6, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private void ParallelLineLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(2, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private void PlaneMatchLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(3, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private void EdgeMatchLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(4, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private void PointMatchLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(1, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private void EdgeIntersectionMatchLockPayload()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(7, false);
            optionsSetup.Document.Commit("Changed options");
        }

        #region Events

        private int _prevX, _prevY;

        /// <summary>
        ///   The Controller is notified about resize events
        /// </summary>
        private void ResizeView(object sender, EventArgs e)
        {
            _actionGraph[InputNames.View].Send(NotificationNames.Resize);
        }

        private void EscHandler()
        {
            SwitchUserAction(ModifierNames.None);
        }

        /// <summary>
        ///   The Controller is notified about key down events
        /// </summary>
        private void InputKeys(KeyEventArgs e, bool controlDown,
                               bool shiftDown)
        {
            var anyKeyConverter = new KeyConverter();
            Log.Info(anyKeyConverter.ConvertToString(e.Key) + " Pressed");

            if ((controlDown) || (shiftDown) || (!_attachedView.ActiveControlFocused())) return;
            var isNumeric = (e.Key >= Key.D0 && e.Key <= Key.D9);
            var isNumPad = (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Decimal;
            var value = string.Empty;
            if (isNumeric)
            {
                var converter = new KeyConverter();
                value = converter.ConvertToString(e.Key);
            }

            if (e.Key == Key.OemComma)
                value = ",";
            if (e.Key == Key.OemPeriod)
                value = ".";
            if (e.Key == Key.R)
                value = "r";
            if (e.Key == Key.OemMinus)
                value = "-";
            if (isNumPad)
            {
                var converter = new KeyConverter();
                var result = converter.ConvertToString(e.Key);
                if (result != null)
                {
                    var numKey = result[6];
                    value = numKey.ToString();
                }
            }
            _commandLineView.EditTextBox.Text += value;
            if (e.Key == Key.Back)
            {
                if (_commandLineView.EditTextBox.Text != "")
                {
                    _commandLineView.EditTextBox.Text = _commandLineView.EditTextBox.Text.Substring(0,
                                                                                                    _commandLineView.
                                                                                                        EditTextBox.Text
                                                                                                        .Length - 1);
                }
            }
            if (e.Key == Key.Enter)
                _commandLineView.TextBoxKeyDown(this, e);
        }

        public void KeyDownHandler(KeyEventArgs e)
        {
            _controlDown = (Keyboard.Modifiers & ModifierKeys.Control) != 0;
            _shiftDown = (Keyboard.Modifiers & ModifierKeys.Shift) != 0;

            KeysMappingSingleton.Instance.UpdateKeys(e);

            InputKeys(e, _controlDown, _shiftDown);

            switch (e.Key)
            {
                case Key.Escape:
                    EscHandler();
                    break;
                case Key.Delete:
                    {
                        // Delete the currently selected shape then 
                        SwitchUserAction(_shiftDown ? ModifierNames.DeleteHidden : ModifierNames.Delete);
                        _shiftDown = false;
                        SwitchUserAction(ModifierNames.None);

                        _lastLabelAdded = null;
                    }
                    break;
                case Key.OemTilde:
                    {
                        // Delete the currently selected shape then 
                        SwitchUserAction(ModifierNames.AddSelectedTool);
                        _shiftDown = false;

                        _lastLabelAdded = null;
                    }
                    break;
                case Key.C:
                    if (_controlDown)
                        SwitchUserAction(ModifierNames.NaroDocumentCopy);
                    break;
                case Key.V:
                    if (_controlDown)
                        SwitchUserAction(ModifierNames.NaroDocumentPaste);
                    break;
                case Key.O:
                    if (_controlDown)
                        SwitchUserAction(ModifierNames.FileOpen);
                    break;
                case Key.S:
                    if (_controlDown)
                        SwitchUserAction(ModifierNames.FileSave);
                    break;
                case Key.Z:
                    if (_controlDown)
                    {
                        // undo if we're not drawing
                        //if (!e.IsToggled)
                        {
                            SwitchUserAction(ModifierNames.Undo);
                        }
                        //else
                        //{
                        //    // if we're drawing, cancel the current drawing
                        //    EscHandler();
                        //}
                    }
                    break;
                case Key.Y:
                    if (_controlDown)
                        SwitchUserAction(ModifierNames.Redo);
                    break;

                default:
                    if (_currentAction == null)
                        break;
                    break;
            }
        }

        public void KeyUpHandler(KeyEventArgs e)
        {
            _controlDown = (e.KeyboardDevice.Modifiers & ModifierKeys.Control) != 0;
            _shiftDown = (e.KeyboardDevice.Modifiers & ModifierKeys.Shift) != 0;
            KeysMappingSingleton.Instance.UpdateKeys(e);
        }

        /// <summary>
        ///   Called when a MouseDown event is generated
        /// </summary>
        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            var activeView = _view;

            // Store the current mouse position
            _prevX = e.X;
            _prevY = e.Y;

            switch (e.Button)
            {
                case MouseButtons.Middle:
                    if (!_shiftDown)
                    {
                        activeView.StartRotation(e.X, e.Y, 0.0);
                        // Deactivate the priviledged plane
                        _viewer.DeactivateGrid();
                        _viewer.DisplayPrivilegedPlane(false, 1);
                    }
                    break;
                case MouseButtons.Left:
                    _mouseInput.MouseDown(e.X, e.Y, e.Clicks, _shiftDown, _controlDown);
                    break;
            }
        }

        /// <summary>
        ///   Called when a MouseUp event is generated
        /// </summary>
        private void MouseUpHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mouseInput.MouseUp(e.X, e.Y, _shiftDown, _controlDown);

            _prevX = e.X;
            _prevY = e.Y;
        }

        /// <summary>
        ///   Called when a MouseMove event is generated
        /// </summary>
        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            var activeView = _view;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    activeView.Pan(e.X - _prevX, _prevY - e.Y, 1);
                    break;
                case MouseButtons.Middle:
                    if (_shiftDown)
                        activeView.Pan(e.X - _prevX, _prevY - e.Y, 1);
                    else
                        activeView.Rotation(e.X, e.Y);
                    break;
                case MouseButtons.Left:
                    _mouseInput.MouseMove(e.X, e.Y, true, _shiftDown, _controlDown);
                    break;
                case MouseButtons.XButton1:
                    activeView.Scale = (activeView.Scale * 1.25);
                    break;
                case MouseButtons.XButton2:
                    activeView.Scale = (activeView.Scale * 0.8);
                    break;
                default:
                    _mouseInput.MouseMove(e.X, e.Y, false, _shiftDown, _controlDown);
                    break;
            }

            _prevX = e.X;
            _prevY = e.Y;
        }

        private void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            var activeView = _view;
            var viewHostControl = _attachedView.GetActiveView();

            var windowWidth = viewHostControl.Width;
            var windowHeight = viewHostControl.Height;

            var xCenter = windowWidth/2;
            var yCenter = windowHeight/2;

            var xDifference = e.X - xCenter;
            var yDifference = e.Y - yCenter;

            double xNewCenter, yNewCenter;

            if (e.Delta > 0)
            {
                xNewCenter = xCenter + xDifference*2*_zoomRatio;
                yNewCenter = yCenter + yDifference*2*_zoomRatio;
                activeView.SetCenter((int) xNewCenter, (int) yNewCenter);
            }
            else
            {
                xNewCenter = xCenter - xDifference*2*_zoomRatio;
                yNewCenter = yCenter - yDifference*2*_zoomRatio;
                activeView.SetCenter((int) xNewCenter, (int) yNewCenter);
            }

            double oldActiveViewX = 0;
            double oldActiveViewY = 0;
            activeView.Size(ref oldActiveViewX, ref oldActiveViewY);

            activeView.Zoom(0, 0,
                            0 + (int) (e.Delta*2*_zoomRatio),
                            0 + (int) (e.Delta*2*_zoomRatio));

            ModifySolverZoomLevel(oldActiveViewX, oldActiveViewY);
        }

        private void ModifySolverZoomLevel(double oldActiveViewX, double oldActiveViewY)
        {
            var activeView = _view;
            double newActiveViewX = 0;
            double newActiveViewY = 0;
            activeView.Size(ref newActiveViewX, ref newActiveViewY);
            var previousValue = Math.Min(oldActiveViewX, oldActiveViewY);
            var currentValue = Math.Min(newActiveViewX, newActiveViewY);
            var ratio = currentValue/previousValue;
            CoreGlobalPreferencesSingleton.Instance.ZoomLevel *= ratio;
            _actionGraph[InputNames.SelectionContainerPipe].Send(NotificationNames.SetZoomLevel);
            _actionGraph[InputNames.EditingToolsInput].Send(NotificationNames.SetEditor);
        }

        #endregion
    }
}