namespace OpenCascadeResearch
{
    partial class OutputDebug
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
            this.ObjectsTreeList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ObjectsTreeList
            // 
            this.ObjectsTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectsTreeList.Location = new System.Drawing.Point(0, 0);
            this.ObjectsTreeList.Name = "ObjectsTreeList";
            this.ObjectsTreeList.Size = new System.Drawing.Size(360, 619);
            this.ObjectsTreeList.TabIndex = 0;
            // 
            // OutputDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 619);
            this.Controls.Add(this.ObjectsTreeList);
            this.Name = "OutputDebug";
            this.Text = "OutputDebug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ObjectsTreeList;
    }
}