namespace RPDP.UI
{
    partial class ChangeAmountCarForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbAmountCar = new System.Windows.Forms.ComboBox();
            this.lblAmountCar = new System.Windows.Forms.Label();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(431, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(294, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbAmountCar
            // 
            this.cmbAmountCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbAmountCar.FormattingEnabled = true;
            this.cmbAmountCar.Location = new System.Drawing.Point(448, 11);
            this.cmbAmountCar.Name = "cmbAmountCar";
            this.cmbAmountCar.Size = new System.Drawing.Size(91, 29);
            this.cmbAmountCar.TabIndex = 75;
            // 
            // lblAmountCar
            // 
            this.lblAmountCar.AutoSize = true;
            this.lblAmountCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAmountCar.Location = new System.Drawing.Point(188, 14);
            this.lblAmountCar.Name = "lblAmountCar";
            this.lblAmountCar.Size = new System.Drawing.Size(254, 21);
            this.lblAmountCar.TabIndex = 74;
            this.lblAmountCar.Text = "Количество вагонов в составе";
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnDelete.Location = new System.Drawing.Point(12, 51);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(101, 25);
            this.radioBtnDelete.TabIndex = 73;
            this.radioBtnDelete.TabStop = true;
            this.radioBtnDelete.Text = "Удаление";
            this.radioBtnDelete.UseVisualStyleBackColor = true;
            this.radioBtnDelete.CheckedChanged += new System.EventHandler(this.radioBtnDelete_CheckedChanged_1);
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnAdd.Location = new System.Drawing.Point(12, 12);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(123, 25);
            this.radioBtnAdd.TabIndex = 71;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Добавление";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged_1);
            // 
            // ChangeAmountCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 123);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbAmountCar);
            this.Controls.Add(this.lblAmountCar);
            this.Controls.Add(this.radioBtnDelete);
            this.Controls.Add(this.radioBtnAdd);
            this.Name = "ChangeAmountCarForm";
            this.Load += new System.EventHandler(this.ChangeAmountCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbAmountCar;
        private System.Windows.Forms.Label lblAmountCar;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.RadioButton radioBtnAdd;
    }
}