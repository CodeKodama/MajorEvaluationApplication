namespace MajorEvaluation
{
    partial class ClassSubstitute
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
            this.repCancelButton = new System.Windows.Forms.Button();
            this.repSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repSubject = new System.Windows.Forms.TextBox();
            this.repUniversity = new System.Windows.Forms.TextBox();
            this.repCredits = new System.Windows.Forms.TextBox();
            this.repNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // repCancelButton
            // 
            this.repCancelButton.Location = new System.Drawing.Point(126, 112);
            this.repCancelButton.Name = "repCancelButton";
            this.repCancelButton.Size = new System.Drawing.Size(112, 25);
            this.repCancelButton.TabIndex = 0;
            this.repCancelButton.Text = "Cancel";
            this.repCancelButton.UseVisualStyleBackColor = true;
            this.repCancelButton.Click += new System.EventHandler(this.repCancelButton_Click);
            // 
            // repSaveButton
            // 
            this.repSaveButton.Location = new System.Drawing.Point(8, 112);
            this.repSaveButton.Name = "repSaveButton";
            this.repSaveButton.Size = new System.Drawing.Size(112, 25);
            this.repSaveButton.TabIndex = 1;
            this.repSaveButton.Text = "Save";
            this.repSaveButton.UseVisualStyleBackColor = true;
            this.repSaveButton.Click += new System.EventHandler(this.repSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "University";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Credits";
            // 
            // repSubject
            // 
            this.repSubject.Location = new System.Drawing.Point(8, 28);
            this.repSubject.Name = "repSubject";
            this.repSubject.Size = new System.Drawing.Size(112, 20);
            this.repSubject.TabIndex = 6;
            // 
            // repUniversity
            // 
            this.repUniversity.Location = new System.Drawing.Point(8, 70);
            this.repUniversity.Name = "repUniversity";
            this.repUniversity.Size = new System.Drawing.Size(112, 20);
            this.repUniversity.TabIndex = 7;
            // 
            // repCredits
            // 
            this.repCredits.Location = new System.Drawing.Point(126, 70);
            this.repCredits.Name = "repCredits";
            this.repCredits.Size = new System.Drawing.Size(112, 20);
            this.repCredits.TabIndex = 8;
            // 
            // repNumber
            // 
            this.repNumber.Location = new System.Drawing.Point(126, 28);
            this.repNumber.Name = "repNumber";
            this.repNumber.Size = new System.Drawing.Size(112, 20);
            this.repNumber.TabIndex = 9;
            // 
            // ClassSubstitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 146);
            this.Controls.Add(this.repNumber);
            this.Controls.Add(this.repCredits);
            this.Controls.Add(this.repUniversity);
            this.Controls.Add(this.repSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repSaveButton);
            this.Controls.Add(this.repCancelButton);
            this.Name = "ClassSubstitute";
            this.Text = "Coure Substitution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button repCancelButton;
        private System.Windows.Forms.Button repSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repSubject;
        private System.Windows.Forms.TextBox repUniversity;
        private System.Windows.Forms.TextBox repCredits;
        private System.Windows.Forms.TextBox repNumber;
    }
}