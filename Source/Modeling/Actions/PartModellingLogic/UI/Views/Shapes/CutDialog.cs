#region Usings

using System;
using System.Drawing;
using System.Windows.Forms;
using BooEvaluator.Boo;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Algo;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.V3d;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.UI.Views.Shapes
{
    public partial class CutDialog : Form
    {
        #region Delegates

        public delegate void CutDialogFinishedHandler(DialogResult result);

        #endregion

        private const string CutThroughAll = "Cut through all";
        private const string CutToDepth = "Cut to depth";

        private readonly Document _document;
        private readonly V3dView _view;

        public CutDialogFinishedHandler OnCutDialogFinished;
        private NodeBuilder _cutNode;

        public CutDialog(Document document, V3dView view, SceneSelectedEntity sceneSelectedEntity)
        {
            InitializeComponent();
            _document = document;
            _view = view;

            var selNode = sceneSelectedEntity.Node;
            var sketchNode = AutoGroupLogic.FindSketchNode(selNode);
            _cutNode = new NodeBuilder(document, FunctionNames.Cut);
            _cutNode[0].Reference = sketchNode;
          
            cutTypeComboBox.Items.Add(CutThroughAll);
            cutTypeComboBox.Items.Add(CutToDepth);
            cutTypeComboBox.SelectedIndex = 0;

            CutDepth = 100;


            UpdateView();
        }

        public CutTypes CutType { get; private set; }
        public double CutDepth { get; private set; }

        private void PreviewCut()
        {
            if (CutType == CutTypes.ThroughAll)
            {
                _cutNode[2].Integer = (int) ExtrusionTypes.MidPlane;
                _cutNode[1].Real = 10000;
            }
            if (CutType == CutTypes.ToDepth)
            {
                _cutNode[2].Integer = (int) ExtrusionTypes.ToDepth;
                _cutNode[1].Real = CutDepth;
            }
            _cutNode.Color = Color.White;
            _cutNode.ExecuteFunction();

            _view.Update();
        }

        private void UpdateView()
        {
        }

        private void OnCancel()
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OnOk()
        {
            CutType = cutTypeComboBox.Text == CutThroughAll ? CutTypes.ThroughAll : CutTypes.ToDepth;
            if (CutType == CutTypes.ToDepth)
            {
                CutDepth = BooEval.GetDouble(cutDepthTextBox.Text);
            }
            DialogResult = DialogResult.OK;
        }

        private void Button1Click1(object sender, EventArgs e)
        {
            OnOk();
            OnCutDialogFinished(DialogResult);
            Close();
        }

        private void GlassButton1Click(object sender, EventArgs e)
        {
            OnCancel();
            OnCutDialogFinished(DialogResult);
            Close();
        }

        private void CutTypeComboBoxSelectedIndexChanged1(object sender, EventArgs e)
        {
            var toDepthControls = cutTypeComboBox.SelectedIndex == 1;
            label2.Visible = toDepthControls;
            cutDepthTextBox.Visible = toDepthControls;
            CutType = CutTypes.ThroughAll;
            if (cutTypeComboBox.SelectedIndex == 1)
            {
                CutType = CutTypes.ToDepth;
            }

            UpdateView();
            PreviewCut();
        }

        private void CutDepthTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var depth = 0.0;
                if (double.TryParse(cutDepthTextBox.Text, out depth))
                {
                    CutDepth = BooEval.GetDouble(cutDepthTextBox.Text);
                
                PreviewCut();
                }
            }
            catch
            {
            }
        }
    }
}