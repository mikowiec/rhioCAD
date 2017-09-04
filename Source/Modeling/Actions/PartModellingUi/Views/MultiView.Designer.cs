/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */
using System.Drawing;
using System.Windows.Forms;

namespace PartModellingUi.Views
{
    sealed partial class MultiView
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
			if (disposing)
            {
                if (Presenter != null)
                    Presenter.Dispose();

                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.multiviewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topRightCustomControl = new CustomMultiviewControl();
            this.topLeftCustomControl = new CustomMultiviewControl();
            this.bottomRightCustomControl = new CustomMultiviewControl();
            this.bottomLeftCustomControl = new CustomMultiviewControl();
            this.TaskTimer = new System.Windows.Forms.Timer(this.components);
            this.multiviewTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiviewTableLayoutPanel
            // 
            this.multiviewTableLayoutPanel.BackColor = SystemColors.Control;
            this.multiviewTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.multiviewTableLayoutPanel.ColumnCount = 2;
            this.multiviewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.multiviewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.multiviewTableLayoutPanel.Controls.Add(this.topRightCustomControl, 1, 0);
            this.multiviewTableLayoutPanel.Controls.Add(this.topLeftCustomControl, 0, 0);
            this.multiviewTableLayoutPanel.Controls.Add(this.bottomRightCustomControl, 1, 1);
            this.multiviewTableLayoutPanel.Controls.Add(this.bottomLeftCustomControl, 0, 1);
            this.multiviewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiviewTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.multiviewTableLayoutPanel.Name = "multiviewTableLayoutPanel";
            this.multiviewTableLayoutPanel.RowCount = 2;
            this.multiviewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.multiviewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.multiviewTableLayoutPanel.Size = new System.Drawing.Size(866, 609);
            this.multiviewTableLayoutPanel.TabIndex = 0;
            this.multiviewTableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.MultiviewTableCellPaint);
            // 
            // topRightCustomControl
            // 
            this.topRightCustomControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRightCustomControl.Location = new System.Drawing.Point(436, 4);
            this.topRightCustomControl.Name = "topRightCustomControl";
            this.topRightCustomControl.Size = new System.Drawing.Size(426, 297);
            this.topRightCustomControl.TabIndex = 1;
            this.topRightCustomControl.Text = "customMultiviewControl2";
            this.topRightCustomControl.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPaint);
            this.topRightCustomControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.topRightCustomControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.topRightCustomControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // topLeftCustomControl
            // 
            this.topLeftCustomControl.BackColor = System.Drawing.SystemColors.Control;
            this.topLeftCustomControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeftCustomControl.Location = new System.Drawing.Point(4, 4);
            this.topLeftCustomControl.Name = "topLeftCustomControl";
            this.topLeftCustomControl.Size = new System.Drawing.Size(425, 297);
            this.topLeftCustomControl.TabIndex = 0;
            this.topLeftCustomControl.Text = "customMultiviewControl1";
            this.topLeftCustomControl.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPaint);
            this.topLeftCustomControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.topLeftCustomControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.topLeftCustomControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // bottomRightCustomControl
            // 
            this.bottomRightCustomControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightCustomControl.Location = new System.Drawing.Point(436, 308);
            this.bottomRightCustomControl.Name = "bottomRightCustomControl";
            this.bottomRightCustomControl.Size = new System.Drawing.Size(426, 297);
            this.bottomRightCustomControl.TabIndex = 3;
            this.bottomRightCustomControl.Text = "customMultiviewControl4";
            this.bottomRightCustomControl.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPaint);
            this.bottomRightCustomControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.bottomRightCustomControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.bottomRightCustomControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // bottomLeftCustomControl
            // 
            this.bottomLeftCustomControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeftCustomControl.Location = new System.Drawing.Point(4, 308);
            this.bottomLeftCustomControl.Name = "bottomLeftCustomControl";
            this.bottomLeftCustomControl.Size = new System.Drawing.Size(425, 297);
            this.bottomLeftCustomControl.TabIndex = 2;
            this.bottomLeftCustomControl.Text = "customMultiviewControl3";
            this.bottomLeftCustomControl.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPaint);
            this.bottomLeftCustomControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.bottomLeftCustomControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.bottomLeftCustomControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // MultiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multiviewTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "MultiView";
            this.Size = new System.Drawing.Size(866, 609);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPaint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.Resize += new System.EventHandler(this.ResizeEvent);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            this.multiviewTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel multiviewTableLayoutPanel;
        private CustomMultiviewControl topLeftCustomControl;
        private CustomMultiviewControl topRightCustomControl;
        private CustomMultiviewControl bottomLeftCustomControl;
        private CustomMultiviewControl bottomRightCustomControl;

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        private Timer TaskTimer;
    }
}