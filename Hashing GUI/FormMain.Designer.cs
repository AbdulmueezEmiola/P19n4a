namespace Hashing_GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHashTable = new System.Windows.Forms.DataGridView();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.TextBoxEmployeeNumber = new System.Windows.Forms.TextBox();
            this.LabelEmployeeNumber = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHashTable
            // 
            this.dgvHashTable.AllowUserToAddRows = false;
            this.dgvHashTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHashTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHashTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHashTable.Location = new System.Drawing.Point(24, 21);
            this.dgvHashTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHashTable.Name = "dgvHashTable";
            this.dgvHashTable.RowHeadersVisible = false;
            this.dgvHashTable.Size = new System.Drawing.Size(585, 448);
            this.dgvHashTable.TabIndex = 0;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(659, 372);
            this.ButtonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(161, 42);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Открыть файл";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(659, 250);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 42);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(659, 188);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(161, 42);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonFind
            // 
            this.ButtonFind.Location = new System.Drawing.Point(659, 128);
            this.ButtonFind.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(161, 42);
            this.ButtonFind.TabIndex = 3;
            this.ButtonFind.Text = "Найти";
            this.ButtonFind.UseVisualStyleBackColor = true;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // TextBoxEmployeeNumber
            // 
            this.TextBoxEmployeeNumber.Location = new System.Drawing.Point(659, 85);
            this.TextBoxEmployeeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmployeeNumber.Name = "TextBoxEmployeeNumber";
            this.TextBoxEmployeeNumber.Size = new System.Drawing.Size(160, 22);
            this.TextBoxEmployeeNumber.TabIndex = 4;
            // 
            // LabelEmployeeNumber
            // 
            this.LabelEmployeeNumber.AutoSize = true;
            this.LabelEmployeeNumber.Location = new System.Drawing.Point(706, 64);
            this.LabelEmployeeNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmployeeNumber.Name = "LabelEmployeeNumber";
            this.LabelEmployeeNumber.Size = new System.Drawing.Size(51, 17);
            this.LabelEmployeeNumber.TabIndex = 5;
            this.LabelEmployeeNumber.Text = "Номер";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(659, 311);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(161, 42);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelEmployeeNumber);
            this.Controls.Add(this.TextBoxEmployeeNumber);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.dgvHashTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Хеширование";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHashTable;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.TextBox TextBoxEmployeeNumber;
        private System.Windows.Forms.Label LabelEmployeeNumber;
        private System.Windows.Forms.Button ButtonSave;
    }
}

