namespace MajorEvaluation
{
    partial class SeqCreator
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
            this.components = new System.ComponentModel.Container();
            this.seqView = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seqView
            // 
            this.seqView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.seqView.Location = new System.Drawing.Point(12, 12);
            this.seqView.Name = "seqView";
            this.seqView.Size = new System.Drawing.Size(244, 350);
            this.seqView.TabIndex = 0;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(59, 376);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(154, 34);
            this.doneButton.TabIndex = 8;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // SeqCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 426);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.seqView);
            this.Name = "SeqCreator";
            this.Text = "Sequence Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView seqView;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button doneButton;
    }
}