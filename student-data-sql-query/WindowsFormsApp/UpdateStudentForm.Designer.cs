namespace WindowsFormsApp
{
    partial class UpdateStudentForm
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
            this.pickerUpdateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxUpdateSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickerUpdateDateOfBirth
            // 
            this.pickerUpdateDateOfBirth.Location = new System.Drawing.Point(324, 194);
            this.pickerUpdateDateOfBirth.Name = "pickerUpdateDateOfBirth";
            this.pickerUpdateDateOfBirth.Size = new System.Drawing.Size(203, 26);
            this.pickerUpdateDateOfBirth.TabIndex = 19;
            this.pickerUpdateDateOfBirth.Value = new System.DateTime(2020, 3, 2, 0, 0, 0, 0);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(219, 198);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(97, 20);
            this.labelDateOfBirth.TabIndex = 23;
            this.labelDateOfBirth.Text = "Date of birth";
            // 
            // textBoxUpdateSurname
            // 
            this.textBoxUpdateSurname.Location = new System.Drawing.Point(299, 147);
            this.textBoxUpdateSurname.Name = "textBoxUpdateSurname";
            this.textBoxUpdateSurname.Size = new System.Drawing.Size(228, 26);
            this.textBoxUpdateSurname.TabIndex = 18;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(219, 147);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 20);
            this.labelSurname.TabIndex = 22;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(276, 100);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(251, 26);
            this.textBoxUpdateName.TabIndex = 17;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(219, 103);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(403, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 59);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "SAVE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(312, 57);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.ReadOnly = true;
            this.textBoxStudentId.Size = new System.Drawing.Size(215, 26);
            this.textBoxStudentId.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student ID";
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickerUpdateDateOfBirth);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxUpdateSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxUpdateName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateStudentForm";
            this.Text = "UpdateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pickerUpdateDateOfBirth;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxUpdateSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label label1;
    }
}