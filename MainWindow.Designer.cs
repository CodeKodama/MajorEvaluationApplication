namespace MajorEvaluator
{
    partial class MainWindow
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
            this.evalView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currStudent = new System.Windows.Forms.GroupBox();
            this.studentSelectionButton = new System.Windows.Forms.Button();
            this.majorName = new System.Windows.Forms.Label();
            this.evalPrintButton = new System.Windows.Forms.Button();
            this.evalPreviewButton = new System.Windows.Forms.Button();
            this.reqChangeButton = new System.Windows.Forms.Button();
            this.classSubstituteButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.newEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.openEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.majorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMajorJSONFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMajor = new System.Windows.Forms.OpenFileDialog();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currStudent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // evalView
            // 
            this.evalView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.evalView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.evalView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalView.FullRowSelect = true;
            this.evalView.Location = new System.Drawing.Point(12, 160);
            this.evalView.Name = "evalView";
            this.evalView.Size = new System.Drawing.Size(774, 302);
            this.evalView.TabIndex = 6;
            this.evalView.UseCompatibleStateImageBehavior = false;
            this.evalView.View = System.Windows.Forms.View.Details;
            this.evalView.SelectedIndexChanged += new System.EventHandler(this.evalView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Credits";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "GPA";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "Replacement";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 5;
            this.columnHeader3.Text = "Replacement Credits";
            this.columnHeader3.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 6;
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 105;
            // 
            // currStudent
            // 
            this.currStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.currStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.currStudent.Controls.Add(this.studentSelectionButton);
            this.currStudent.Controls.Add(this.majorName);
            this.currStudent.Controls.Add(this.evalPrintButton);
            this.currStudent.Controls.Add(this.evalPreviewButton);
            this.currStudent.Controls.Add(this.reqChangeButton);
            this.currStudent.Controls.Add(this.classSubstituteButton);
            this.currStudent.Controls.Add(this.richTextBox1);
            this.currStudent.Controls.Add(this.label2);
            this.currStudent.Controls.Add(this.label1);
            this.currStudent.Controls.Add(this.evalView);
            this.currStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currStudent.Location = new System.Drawing.Point(8, 33);
            this.currStudent.Name = "currStudent";
            this.currStudent.Size = new System.Drawing.Size(798, 509);
            this.currStudent.TabIndex = 7;
            this.currStudent.TabStop = false;
            this.currStudent.Text = "Please Select A Student";
            this.currStudent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // studentSelectionButton
            // 
            this.studentSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.studentSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSelectionButton.Location = new System.Drawing.Point(12, 468);
            this.studentSelectionButton.Name = "studentSelectionButton";
            this.studentSelectionButton.Size = new System.Drawing.Size(85, 35);
            this.studentSelectionButton.TabIndex = 17;
            this.studentSelectionButton.Text = "Select A Student";
            this.studentSelectionButton.UseVisualStyleBackColor = true;
            this.studentSelectionButton.Click += new System.EventHandler(this.studentSelectionButton_Click);
            // 
            // majorName
            // 
            this.majorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.majorName.AutoSize = true;
            this.majorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorName.Location = new System.Drawing.Point(476, 468);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(95, 31);
            this.majorName.TabIndex = 16;
            this.majorName.Text = "Major:";
            // 
            // evalPrintButton
            // 
            this.evalPrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.evalPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalPrintButton.Location = new System.Drawing.Point(376, 468);
            this.evalPrintButton.Name = "evalPrintButton";
            this.evalPrintButton.Size = new System.Drawing.Size(85, 35);
            this.evalPrintButton.TabIndex = 15;
            this.evalPrintButton.Text = "Print Evaluation";
            this.evalPrintButton.UseVisualStyleBackColor = true;
            this.evalPrintButton.Click += new System.EventHandler(this.evalPrintButton_Click);
            // 
            // evalPreviewButton
            // 
            this.evalPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.evalPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalPreviewButton.Location = new System.Drawing.Point(285, 468);
            this.evalPreviewButton.Name = "evalPreviewButton";
            this.evalPreviewButton.Size = new System.Drawing.Size(85, 35);
            this.evalPreviewButton.TabIndex = 14;
            this.evalPreviewButton.Text = "Preview Evaluation";
            this.evalPreviewButton.UseVisualStyleBackColor = true;
            this.evalPreviewButton.Click += new System.EventHandler(this.evalPreviewButton_Click);
            // 
            // reqChangeButton
            // 
            this.reqChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reqChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqChangeButton.Location = new System.Drawing.Point(194, 468);
            this.reqChangeButton.Name = "reqChangeButton";
            this.reqChangeButton.Size = new System.Drawing.Size(85, 35);
            this.reqChangeButton.TabIndex = 13;
            this.reqChangeButton.Text = "Change Requirements";
            this.reqChangeButton.UseVisualStyleBackColor = true;
            this.reqChangeButton.Click += new System.EventHandler(this.reqChangeButton_Click);
            // 
            // classSubstituteButton
            // 
            this.classSubstituteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.classSubstituteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSubstituteButton.Location = new System.Drawing.Point(103, 468);
            this.classSubstituteButton.Name = "classSubstituteButton";
            this.classSubstituteButton.Size = new System.Drawing.Size(85, 35);
            this.classSubstituteButton.TabIndex = 11;
            this.classSubstituteButton.Text = "Substitute A Class";
            this.classSubstituteButton.UseVisualStyleBackColor = true;
            this.classSubstituteButton.Click += new System.EventHandler(this.classSubstituteButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(17, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(769, 97);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Credits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Classes:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.majorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEvaluation,
            this.openEvaluation,
            this.saveEvaluation});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // newEvaluation
            // 
            this.newEvaluation.Name = "newEvaluation";
            this.newEvaluation.Size = new System.Drawing.Size(176, 22);
            this.newEvaluation.Text = "New evaluation";
            // 
            // openEvaluation
            // 
            this.openEvaluation.Name = "openEvaluation";
            this.openEvaluation.Size = new System.Drawing.Size(176, 22);
            this.openEvaluation.Text = "Open evaluation ....";
            this.openEvaluation.Click += new System.EventHandler(this.openEvaluation_Click);
            // 
            // saveEvaluation
            // 
            this.saveEvaluation.Name = "saveEvaluation";
            this.saveEvaluation.Size = new System.Drawing.Size(176, 22);
            this.saveEvaluation.Text = "Save evaluation ...";
            // 
            // majorToolStripMenuItem
            // 
            this.majorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMajorJSONFileToolStripMenuItem});
            this.majorToolStripMenuItem.Name = "majorToolStripMenuItem";
            this.majorToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.majorToolStripMenuItem.Text = "Major";
            // 
            // openMajorJSONFileToolStripMenuItem
            // 
            this.openMajorJSONFileToolStripMenuItem.Name = "openMajorJSONFileToolStripMenuItem";
            this.openMajorJSONFileToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openMajorJSONFileToolStripMenuItem.Text = "Open major JSON file ...";
            this.openMajorJSONFileToolStripMenuItem.Click += new System.EventHandler(this.openMajorJSONFileToolStripMenuItem_Click);
            // 
            // openMajor
            // 
            this.openMajor.FileName = "openFileDialog1";
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 3;
            this.columnHeader7.Text = "Type";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(818, 554);
            this.Controls.Add(this.currStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Major Evaluator";
            this.currStudent.ResumeLayout(false);
            this.currStudent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView evalView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox currStudent;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label majorName;
        private System.Windows.Forms.Button evalPrintButton;
        private System.Windows.Forms.Button evalPreviewButton;
        private System.Windows.Forms.Button reqChangeButton;
        private System.Windows.Forms.Button classSubstituteButton;
        private System.Windows.Forms.Button studentSelectionButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem newEvaluation;
        private System.Windows.Forms.ToolStripMenuItem openEvaluation;
        private System.Windows.Forms.ToolStripMenuItem saveEvaluation;
        private System.Windows.Forms.ToolStripMenuItem majorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMajorJSONFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openMajor;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

