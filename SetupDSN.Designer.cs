namespace MajorEvaluation
{
    partial class SetupDSN
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
            this.DSNAccept = new System.Windows.Forms.Button();
            this.DSNOp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSNAccept
            // 
            this.DSNAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSNAccept.Location = new System.Drawing.Point(50, 89);
            this.DSNAccept.Name = "DSNAccept";
            this.DSNAccept.Size = new System.Drawing.Size(112, 28);
            this.DSNAccept.TabIndex = 9;
            this.DSNAccept.Text = "Ok";
            this.DSNAccept.UseVisualStyleBackColor = true;
            this.DSNAccept.Click += new System.EventHandler(this.DSNAccept_Click);
            // 
            // DSNOp
            // 
            this.DSNOp.AcceptsTab = true;
            this.DSNOp.Location = new System.Drawing.Point(6, 19);
            this.DSNOp.Name = "DSNOp";
            this.DSNOp.ShortcutsEnabled = false;
            this.DSNOp.Size = new System.Drawing.Size(170, 20);
            this.DSNOp.TabIndex = 12;
            this.DSNOp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Connect:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DSNOp);
            this.groupBox2.Location = new System.Drawing.Point(19, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 49);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Please enter valid DSN name:";
            // 
            // SetupDSN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 129);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSNAccept);
            this.Name = "SetupDSN";
            this.Text = "Connect";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DSNAccept;
        private System.Windows.Forms.TextBox DSNOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}