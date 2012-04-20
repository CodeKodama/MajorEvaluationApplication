namespace MajorEvaluation
{
    partial class Creator
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
            this.testbox = new System.Windows.Forms.TextBox();
            this.test_json = new System.Windows.Forms.Button();
            this.req_list = new System.Windows.Forms.ListView();
            this.SUBJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COURSE_NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CREDITS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.REQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject_box = new System.Windows.Forms.TextBox();
            this.subject_label = new System.Windows.Forms.Label();
            this.add_class_group = new System.Windows.Forms.GroupBox();
            this.remove = new System.Windows.Forms.Button();
            this.add_class = new System.Windows.Forms.Button();
            this.req_or_elec = new System.Windows.Forms.TextBox();
            this.req_or_elec_label = new System.Windows.Forms.Label();
            this.credits_box = new System.Windows.Forms.TextBox();
            this.credits_label = new System.Windows.Forms.Label();
            this.course_num_box = new System.Windows.Forms.TextBox();
            this.course_num_label = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.DEPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.and_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.and_button = new System.Windows.Forms.Button();
            this.or_button = new System.Windows.Forms.Button();
            this.add_class_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // testbox
            // 
            this.testbox.Location = new System.Drawing.Point(365, 176);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(307, 20);
            this.testbox.TabIndex = 1;
            // 
            // test_json
            // 
            this.test_json.Location = new System.Drawing.Point(678, 173);
            this.test_json.Name = "test_json";
            this.test_json.Size = new System.Drawing.Size(75, 23);
            this.test_json.TabIndex = 2;
            this.test_json.Text = "test_json";
            this.test_json.UseVisualStyleBackColor = true;
            this.test_json.Click += new System.EventHandler(this.button1_Click);
            // 
            // req_list
            // 
            this.req_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SUBJ,
            this.COURSE_NUM,
            this.CREDITS,
            this.REQ});
            this.req_list.FullRowSelect = true;
            this.req_list.Location = new System.Drawing.Point(9, 132);
            this.req_list.MultiSelect = false;
            this.req_list.Name = "req_list";
            this.req_list.Size = new System.Drawing.Size(325, 135);
            this.req_list.TabIndex = 7;
            this.req_list.UseCompatibleStateImageBehavior = false;
            this.req_list.View = System.Windows.Forms.View.Details;
            // 
            // SUBJ
            // 
            this.SUBJ.Text = "Subject";
            // 
            // COURSE_NUM
            // 
            this.COURSE_NUM.Text = "Course Number";
            this.COURSE_NUM.Width = 100;
            // 
            // CREDITS
            // 
            this.CREDITS.Text = "Credits";
            // 
            // REQ
            // 
            this.REQ.Text = "Required or Elective";
            this.REQ.Width = 125;
            // 
            // subject_box
            // 
            this.subject_box.Location = new System.Drawing.Point(58, 34);
            this.subject_box.Name = "subject_box";
            this.subject_box.Size = new System.Drawing.Size(68, 20);
            this.subject_box.TabIndex = 8;
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(6, 37);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(46, 13);
            this.subject_label.TabIndex = 9;
            this.subject_label.Text = "Subject:";
            // 
            // add_class_group
            // 
            this.add_class_group.Controls.Add(this.remove);
            this.add_class_group.Controls.Add(this.add_class);
            this.add_class_group.Controls.Add(this.req_or_elec);
            this.add_class_group.Controls.Add(this.req_or_elec_label);
            this.add_class_group.Controls.Add(this.credits_box);
            this.add_class_group.Controls.Add(this.credits_label);
            this.add_class_group.Controls.Add(this.course_num_box);
            this.add_class_group.Controls.Add(this.course_num_label);
            this.add_class_group.Controls.Add(this.subject_box);
            this.add_class_group.Controls.Add(this.subject_label);
            this.add_class_group.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_class_group.Location = new System.Drawing.Point(0, 24);
            this.add_class_group.Name = "add_class_group";
            this.add_class_group.Size = new System.Drawing.Size(764, 88);
            this.add_class_group.TabIndex = 10;
            this.add_class_group.TabStop = false;
            this.add_class_group.Text = "Class Attributes";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(638, 32);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 17;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add_class
            // 
            this.add_class.Location = new System.Drawing.Point(548, 32);
            this.add_class.Name = "add_class";
            this.add_class.Size = new System.Drawing.Size(75, 23);
            this.add_class.TabIndex = 16;
            this.add_class.Text = "Add";
            this.add_class.UseVisualStyleBackColor = true;
            this.add_class.Click += new System.EventHandler(this.add_class_Click);
            // 
            // req_or_elec
            // 
            this.req_or_elec.Location = new System.Drawing.Point(488, 34);
            this.req_or_elec.Name = "req_or_elec";
            this.req_or_elec.Size = new System.Drawing.Size(37, 20);
            this.req_or_elec.TabIndex = 14;
            // 
            // req_or_elec_label
            // 
            this.req_or_elec_label.AutoSize = true;
            this.req_or_elec_label.Location = new System.Drawing.Point(386, 37);
            this.req_or_elec_label.Name = "req_or_elec_label";
            this.req_or_elec_label.Size = new System.Drawing.Size(96, 13);
            this.req_or_elec_label.TabIndex = 15;
            this.req_or_elec_label.Text = "Required/Elective:";
            // 
            // credits_box
            // 
            this.credits_box.Location = new System.Drawing.Point(343, 34);
            this.credits_box.Name = "credits_box";
            this.credits_box.Size = new System.Drawing.Size(37, 20);
            this.credits_box.TabIndex = 12;
            // 
            // credits_label
            // 
            this.credits_label.AutoSize = true;
            this.credits_label.Location = new System.Drawing.Point(295, 37);
            this.credits_label.Name = "credits_label";
            this.credits_label.Size = new System.Drawing.Size(42, 13);
            this.credits_label.TabIndex = 13;
            this.credits_label.Text = "Credits:";
            // 
            // course_num_box
            // 
            this.course_num_box.Location = new System.Drawing.Point(221, 34);
            this.course_num_box.Name = "course_num_box";
            this.course_num_box.Size = new System.Drawing.Size(68, 20);
            this.course_num_box.TabIndex = 10;
            // 
            // course_num_label
            // 
            this.course_num_label.AutoSize = true;
            this.course_num_label.Location = new System.Drawing.Point(132, 37);
            this.course_num_label.Name = "course_num_label";
            this.course_num_label.Size = new System.Drawing.Size(83, 13);
            this.course_num_label.TabIndex = 11;
            this.course_num_label.Text = "Course Number:";
            // 
            // data
            // 
            this.data.AllowUserToOrderColumns = true;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEPT,
            this.course_number,
            this.creds,
            this.required,
            this.and_level,
            this.or_level});
            this.data.Location = new System.Drawing.Point(9, 284);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(753, 272);
            this.data.TabIndex = 11;
            this.data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.data_RowsAdded);
            // 
            // DEPT
            // 
            this.DEPT.HeaderText = "Department";
            this.DEPT.Name = "DEPT";
            this.DEPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // course_number
            // 
            this.course_number.HeaderText = "Course Number";
            this.course_number.Name = "course_number";
            // 
            // creds
            // 
            this.creds.HeaderText = "Credits";
            this.creds.Name = "creds";
            // 
            // required
            // 
            this.required.HeaderText = "Required or Elective";
            this.required.Name = "required";
            // 
            // and_level
            // 
            this.and_level.HeaderText = "AND Level";
            this.and_level.Name = "and_level";
            // 
            // or_level
            // 
            this.or_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.or_level.HeaderText = "OR Level";
            this.or_level.Name = "or_level";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(764, 24);
            this.menu.TabIndex = 12;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save as";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // save
            // 
            this.save.Filter = "\"JSON files|*.json|All files|*.*\"";
            // 
            // open
            // 
            this.open.Filter = "\"JSON files|*.json|All files|*.*\"";
            // 
            // and_button
            // 
            this.and_button.Location = new System.Drawing.Point(438, 244);
            this.and_button.Name = "and_button";
            this.and_button.Size = new System.Drawing.Size(75, 23);
            this.and_button.TabIndex = 13;
            this.and_button.Text = "AND";
            this.and_button.UseVisualStyleBackColor = true;
            this.and_button.Click += new System.EventHandler(this.and_button_Click);
            // 
            // or_button
            // 
            this.or_button.Location = new System.Drawing.Point(533, 244);
            this.or_button.Name = "or_button";
            this.or_button.Size = new System.Drawing.Size(75, 23);
            this.or_button.TabIndex = 14;
            this.or_button.Text = "OR";
            this.or_button.UseVisualStyleBackColor = true;
            this.or_button.Click += new System.EventHandler(this.or_button_Click);
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 556);
            this.Controls.Add(this.or_button);
            this.Controls.Add(this.and_button);
            this.Controls.Add(this.data);
            this.Controls.Add(this.add_class_group);
            this.Controls.Add(this.req_list);
            this.Controls.Add(this.test_json);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.menu);
            this.Name = "Creator";
            this.Text = "Major Creator";
            this.add_class_group.ResumeLayout(false);
            this.add_class_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testbox;
        private System.Windows.Forms.Button test_json;
        private System.Windows.Forms.ListView req_list;
        private System.Windows.Forms.ColumnHeader SUBJ;
        private System.Windows.Forms.ColumnHeader COURSE_NUM;
        private System.Windows.Forms.ColumnHeader CREDITS;
        private System.Windows.Forms.ColumnHeader REQ;
        private System.Windows.Forms.TextBox subject_box;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.GroupBox add_class_group;
        private System.Windows.Forms.TextBox credits_box;
        private System.Windows.Forms.Label credits_label;
        private System.Windows.Forms.TextBox course_num_box;
        private System.Windows.Forms.Label course_num_label;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add_class;
        private System.Windows.Forms.TextBox req_or_elec;
        private System.Windows.Forms.Label req_or_elec_label;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.Button and_button;
        private System.Windows.Forms.Button or_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn creds;
        private System.Windows.Forms.DataGridViewTextBoxColumn required;
        private System.Windows.Forms.DataGridViewTextBoxColumn and_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_level;

    }
}