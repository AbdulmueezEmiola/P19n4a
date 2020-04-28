namespace Hashing_GUI
{
    partial class FormAddEmployeeInfo
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
            this.TextBoxEmployeeNumber = new System.Windows.Forms.TextBox();
            this.TextBoxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.TextBoxEmployeeEmployee = new System.Windows.Forms.TextBox();
            this.LabelEmployeeNumber = new System.Windows.Forms.Label();
            this.LabelEmployeeSalary = new System.Windows.Forms.Label();
            this.LabelEmployeeEmployee = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxEmployeeNumber
            // 
            this.TextBoxEmployeeNumber.Location = new System.Drawing.Point(53, 53);
            this.TextBoxEmployeeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmployeeNumber.Name = "TextBoxEmployeeNumber";
            this.TextBoxEmployeeNumber.Size = new System.Drawing.Size(252, 22);
            this.TextBoxEmployeeNumber.TabIndex = 0;
           
            // 
            // TextBoxEmployeeSalary
            // 
            this.TextBoxEmployeeSalary.Location = new System.Drawing.Point(53, 107);
            this.TextBoxEmployeeSalary.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmployeeSalary.Name = "TextBoxEmployeeSalary";
            this.TextBoxEmployeeSalary.Size = new System.Drawing.Size(252, 22);
            this.TextBoxEmployeeSalary.TabIndex = 1;
            // 
            // TextBoxEmployeeEmployee
            // 
            this.TextBoxEmployeeEmployee.Location = new System.Drawing.Point(53, 161);
            this.TextBoxEmployeeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmployeeEmployee.Name = "TextBoxEmployeeEmployee";
            this.TextBoxEmployeeEmployee.Size = new System.Drawing.Size(252, 22);
            this.TextBoxEmployeeEmployee.TabIndex = 2;
            // 
            // LabelEmployeeNumber
            // 
            this.LabelEmployeeNumber.AutoSize = true;
            this.LabelEmployeeNumber.Location = new System.Drawing.Point(53, 30);
            this.LabelEmployeeNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmployeeNumber.Name = "LabelEmployeeNumber";
            this.LabelEmployeeNumber.Size = new System.Drawing.Size(51, 17);
            this.LabelEmployeeNumber.TabIndex = 1;
            this.LabelEmployeeNumber.Text = "Номер";
            // 
            // LabelEmployeeSalary
            // 
            this.LabelEmployeeSalary.AutoSize = true;
            this.LabelEmployeeSalary.Location = new System.Drawing.Point(53, 87);
            this.LabelEmployeeSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmployeeSalary.Name = "LabelEmployeeSalary";
            this.LabelEmployeeSalary.Size = new System.Drawing.Size(29, 17);
            this.LabelEmployeeSalary.TabIndex = 1;
            this.LabelEmployeeSalary.Text = "З/п";
            // 
            // LabelEmployeeEmployee
            // 
            this.LabelEmployeeEmployee.AutoSize = true;
            this.LabelEmployeeEmployee.Location = new System.Drawing.Point(53, 142);
            this.LabelEmployeeEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmployeeEmployee.Name = "LabelEmployeeEmployee";
            this.LabelEmployeeEmployee.Size = new System.Drawing.Size(122, 17);
            this.LabelEmployeeEmployee.TabIndex = 1;
            this.LabelEmployeeEmployee.Text = "ФИО сотрудника";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(127, 207);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(100, 28);
            this.ButtonSubmit.TabIndex = 2;
            this.ButtonSubmit.Text = "Готово";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // FormAddEmployeeInfo
            // 
            this.AcceptButton = this.ButtonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelEmployeeEmployee);
            this.Controls.Add(this.LabelEmployeeSalary);
            this.Controls.Add(this.LabelEmployeeNumber);
            this.Controls.Add(this.TextBoxEmployeeEmployee);
            this.Controls.Add(this.TextBoxEmployeeSalary);
            this.Controls.Add(this.TextBoxEmployeeNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAddEmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmployeeNumber;
        private System.Windows.Forms.TextBox TextBoxEmployeeSalary;
        private System.Windows.Forms.TextBox TextBoxEmployeeEmployee;
        private System.Windows.Forms.Label LabelEmployeeNumber;
        private System.Windows.Forms.Label LabelEmployeeSalary;
        private System.Windows.Forms.Label LabelEmployeeEmployee;
        private System.Windows.Forms.Button ButtonSubmit;
    }
}