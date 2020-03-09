namespace WindowsFormsApp
{
    partial class StudentRegisterForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.btnDeleteById = new System.Windows.Forms.Button();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.btnSearchStudentId = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickerDateOfBirth
            // 
            this.pickerDateOfBirth.Location = new System.Drawing.Point(156, 203);
            this.pickerDateOfBirth.Name = "pickerDateOfBirth";
            this.pickerDateOfBirth.Size = new System.Drawing.Size(203, 26);
            this.pickerDateOfBirth.TabIndex = 3;
            this.pickerDateOfBirth.Value = new System.DateTime(2020, 3, 2, 0, 0, 0, 0);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(51, 207);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(97, 20);
            this.labelDateOfBirth.TabIndex = 16;
            this.labelDateOfBirth.Text = "Date of birth";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(131, 156);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(228, 26);
            this.textBoxSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(51, 156);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 20);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 109);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(251, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(51, 112);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 59);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Location = new System.Drawing.Point(55, 271);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(158, 59);
            this.btnShowAllStudents.TabIndex = 8;
            this.btnShowAllStudents.Text = "STUDENTS LIST";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // btnDeleteById
            // 
            this.btnDeleteById.Location = new System.Drawing.Point(524, 206);
            this.btnDeleteById.Name = "btnDeleteById";
            this.btnDeleteById.Size = new System.Drawing.Size(90, 41);
            this.btnDeleteById.TabIndex = 6;
            this.btnDeleteById.Text = "DELETE";
            this.btnDeleteById.UseVisualStyleBackColor = true;
            this.btnDeleteById.Click += new System.EventHandler(this.btnDeleteById_Click);
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(524, 151);
            this.textBoxStudentId.Multiline = true;
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(155, 40);
            this.textBoxStudentId.TabIndex = 5;
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Location = new System.Drawing.Point(529, 121);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(146, 20);
            this.labelSearchId.TabIndex = 23;
            this.labelSearchId.Text = "Student Data by ID";
            // 
            // btnSearchStudentId
            // 
            this.btnSearchStudentId.Location = new System.Drawing.Point(620, 206);
            this.btnSearchStudentId.Name = "btnSearchStudentId";
            this.btnSearchStudentId.Size = new System.Drawing.Size(59, 41);
            this.btnSearchStudentId.TabIndex = 24;
            this.btnSearchStudentId.Text = "GO";
            this.btnSearchStudentId.UseVisualStyleBackColor = true;
            this.btnSearchStudentId.Click += new System.EventHandler(this.btnSearchStudentId_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(524, 263);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(164, 59);
            this.btnUpdateStudent.TabIndex = 25;
            this.btnUpdateStudent.Text = "UPDATE STUDENT";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnSearchStudentId);
            this.Controls.Add(this.btnDeleteById);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.labelSearchId);
            this.Controls.Add(this.btnShowAllStudents);
            this.Controls.Add(this.pickerDateOfBirth);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnSave);
            this.Name = "formStudent";
            this.Text = "STUDENT REGISTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pickerDateOfBirth;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.Button btnDeleteById;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label labelSearchId;
        private System.Windows.Forms.Button btnSearchStudentId;
        private System.Windows.Forms.Button btnUpdateStudent;
    }
}

