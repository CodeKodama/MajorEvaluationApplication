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
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currStudent = new System.Windows.Forms.GroupBox();
            this.studentInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.newEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.openEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.majorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMajorJSONFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMajor = new System.Windows.Forms.OpenFileDialog();
            this.classSubstituteButton = new System.Windows.Forms.Button();
            this.reqChangeButton = new System.Windows.Forms.Button();
            this.majorName = new System.Windows.Forms.Label();
            this.studentSelectionButton = new System.Windows.Forms.Button();
            this.sequenceButton = new System.Windows.Forms.Button();
            this.uDivCreds = new System.Windows.Forms.Label();
            this.elecCreds = new System.Windows.Forms.Label();
            this.seqCreds = new System.Windows.Forms.Label();
            this.totCreds = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currStudent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.columnHeader5,
            this.columnHeader8});
            this.evalView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalView.FullRowSelect = true;
            this.evalView.Location = new System.Drawing.Point(11, 52);
            this.evalView.Name = "evalView";
            this.evalView.Size = new System.Drawing.Size(818, 375);
            this.evalView.TabIndex = 6;
            this.evalView.UseCompatibleStateImageBehavior = false;
            this.evalView.View = System.Windows.Forms.View.Details;
            this.evalView.SelectedIndexChanged += new System.EventHandler(this.evalView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Credits";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "GPA";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Type";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 5;
            this.columnHeader4.Text = "Replacement";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 6;
            this.columnHeader3.Text = "Replacement Credits";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 7;
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 4;
            this.columnHeader8.Text = "In Sequence";
            this.columnHeader8.Width = 162;
            // 
            // currStudent
            // 
            this.currStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.currStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.currStudent.Controls.Add(this.studentInfo);
            this.currStudent.Controls.Add(this.evalView);
            this.currStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currStudent.Location = new System.Drawing.Point(8, 33);
            this.currStudent.Name = "currStudent";
            this.currStudent.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.currStudent.Size = new System.Drawing.Size(842, 433);
            this.currStudent.TabIndex = 7;
            this.currStudent.TabStop = false;
            this.currStudent.Text = "Classes";
            this.currStudent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // studentInfo
            // 
            this.studentInfo.AutoSize = true;
            this.studentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentInfo.Location = new System.Drawing.Point(7, 25);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(202, 24);
            this.studentInfo.TabIndex = 7;
            this.studentInfo.Text = "No Student Selected";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.majorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
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
            this.newEvaluation.Click += new System.EventHandler(this.newEvaluation_Click);
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
            this.saveEvaluation.Click += new System.EventHandler(this.saveEvaluation_Click);
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
            // classSubstituteButton
            // 
            this.classSubstituteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.classSubstituteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSubstituteButton.Location = new System.Drawing.Point(338, 20);
            this.classSubstituteButton.Name = "classSubstituteButton";
            this.classSubstituteButton.Size = new System.Drawing.Size(104, 35);
            this.classSubstituteButton.TabIndex = 11;
            this.classSubstituteButton.Text = "Substitute A Class";
            this.classSubstituteButton.UseVisualStyleBackColor = true;
            this.classSubstituteButton.Click += new System.EventHandler(this.classSubstituteButton_Click);
            // 
            // reqChangeButton
            // 
            this.reqChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reqChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqChangeButton.Location = new System.Drawing.Point(9, 22);
            this.reqChangeButton.Name = "reqChangeButton";
            this.reqChangeButton.Size = new System.Drawing.Size(104, 35);
            this.reqChangeButton.TabIndex = 13;
            this.reqChangeButton.Text = "Edit Major";
            this.reqChangeButton.UseVisualStyleBackColor = true;
            this.reqChangeButton.Click += new System.EventHandler(this.reqChangeButton_Click);
            // 
            // majorName
            // 
            this.majorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.majorName.AutoSize = true;
            this.majorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.majorName.Location = new System.Drawing.Point(111, 16);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(231, 29);
            this.majorName.TabIndex = 16;
            this.majorName.Text = "No Major Selected";
            // 
            // studentSelectionButton
            // 
            this.studentSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.studentSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSelectionButton.Location = new System.Drawing.Point(119, 22);
            this.studentSelectionButton.Name = "studentSelectionButton";
            this.studentSelectionButton.Size = new System.Drawing.Size(104, 35);
            this.studentSelectionButton.TabIndex = 17;
            this.studentSelectionButton.Text = "Select A Student";
            this.studentSelectionButton.UseVisualStyleBackColor = true;
            this.studentSelectionButton.Click += new System.EventHandler(this.studentSelectionButton_Click);
            // 
            // sequenceButton
            // 
            this.sequenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sequenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequenceButton.Location = new System.Drawing.Point(229, 20);
            this.sequenceButton.Name = "sequenceButton";
            this.sequenceButton.Size = new System.Drawing.Size(104, 35);
            this.sequenceButton.TabIndex = 18;
            this.sequenceButton.Text = "View Sequences";
            this.sequenceButton.UseVisualStyleBackColor = true;
            this.sequenceButton.Click += new System.EventHandler(this.sequenceButton_Click);
            // 
            // uDivCreds
            // 
            this.uDivCreds.AutoSize = true;
            this.uDivCreds.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uDivCreds.Location = new System.Drawing.Point(7, 22);
            this.uDivCreds.Name = "uDivCreds";
            this.uDivCreds.Size = new System.Drawing.Size(168, 16);
            this.uDivCreds.TabIndex = 19;
            this.uDivCreds.Text = "Upper Division Credits:";
            // 
            // elecCreds
            // 
            this.elecCreds.AutoSize = true;
            this.elecCreds.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.elecCreds.Location = new System.Drawing.Point(7, 45);
            this.elecCreds.Name = "elecCreds";
            this.elecCreds.Size = new System.Drawing.Size(121, 16);
            this.elecCreds.TabIndex = 20;
            this.elecCreds.Text = "Elective Credits:";
            // 
            // seqCreds
            // 
            this.seqCreds.AutoSize = true;
            this.seqCreds.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.seqCreds.Location = new System.Drawing.Point(7, 67);
            this.seqCreds.Name = "seqCreds";
            this.seqCreds.Size = new System.Drawing.Size(135, 16);
            this.seqCreds.TabIndex = 21;
            this.seqCreds.Text = "Sequence Credits:";
            // 
            // totCreds
            // 
            this.totCreds.AutoSize = true;
            this.totCreds.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.totCreds.Location = new System.Drawing.Point(7, 90);
            this.totCreds.Name = "totCreds";
            this.totCreds.Size = new System.Drawing.Size(101, 16);
            this.totCreds.TabIndex = 22;
            this.totCreds.Text = "Total Credits:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.uDivCreds);
            this.groupBox1.Controls.Add(this.elecCreds);
            this.groupBox1.Controls.Add(this.seqCreds);
            this.groupBox1.Controls.Add(this.totCreds);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 472);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 117);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.classSubstituteButton);
            this.groupBox2.Controls.Add(this.reqChangeButton);
            this.groupBox2.Controls.Add(this.sequenceButton);
            this.groupBox2.Controls.Add(this.studentSelectionButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(402, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 61);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Options";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.majorName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(410, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 50);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Major  Name";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 597);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Major Evaluator";
            this.currStudent.ResumeLayout(false);
            this.currStudent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label studentInfo;
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
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button classSubstituteButton;
        private System.Windows.Forms.Button reqChangeButton;
        private System.Windows.Forms.Label majorName;
        private System.Windows.Forms.Button studentSelectionButton;
        private System.Windows.Forms.Button sequenceButton;
        private System.Windows.Forms.Label uDivCreds;
        private System.Windows.Forms.Label elecCreds;
        private System.Windows.Forms.Label seqCreds;
        private System.Windows.Forms.Label totCreds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

