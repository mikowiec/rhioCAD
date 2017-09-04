namespace OpenCascadeResearch
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regenerateShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ocView = new OpenCascadeResearch.View();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testCommandsToolStripMenuItem,
            this.viToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testCommandsToolStripMenuItem
            // 
            this.testCommandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regenerateShapeToolStripMenuItem,
            this.extrudeToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.testCommandsToolStripMenuItem.Name = "testCommandsToolStripMenuItem";
            this.testCommandsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.testCommandsToolStripMenuItem.Text = "TestCommands";
            // 
            // regenerateShapeToolStripMenuItem
            // 
            this.regenerateShapeToolStripMenuItem.Name = "regenerateShapeToolStripMenuItem";
            this.regenerateShapeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.regenerateShapeToolStripMenuItem.Text = "RegenerateShape";
            //this.regenerateShapeToolStripMenuItem.Click += new System.EventHandler(this.regenerateShapeToolStripMenuItem_Click);
            // 
            // extrudeToolStripMenuItem
            // 
            this.extrudeToolStripMenuItem.Name = "extrudeToolStripMenuItem";
            this.extrudeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.extrudeToolStripMenuItem.Text = "Extrude";
            //this.extrudeToolStripMenuItem.Click += new System.EventHandler(this.extrudeToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            //this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            //this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // viToolStripMenuItem
            // 
            this.viToolStripMenuItem.Name = "viToolStripMenuItem";
            this.viToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.viToolStripMenuItem.Text = "View AF Tree";
            //this.viToolStripMenuItem.Click += new System.EventHandler(this.viToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ocView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(847, 579);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ocView
            // 
            this.ocView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocView.Location = new System.Drawing.Point(3, 3);
            this.ocView.Name = "ocView";
            this.ocView.Size = new System.Drawing.Size(417, 283);
            this.ocView.TabIndex = 1;
            this.ocView.Text = "ocView1";
            this.ocView.Paint += new System.Windows.Forms.PaintEventHandler(this.ocView_Paint);
            this.ocView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewMouseMove);
            this.ocView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewMouseDown);
            this.ocView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OpenCascadeTestApp";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpHandler);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintHandler);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownHandler);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveHandler);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regenerateShapeToolStripMenuItem;
        private View ocView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viToolStripMenuItem;
    }
}

