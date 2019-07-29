namespace RPDP.UI
{
    partial class ChangeRegistrarForm
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
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.cmbNumberRegistrar = new System.Windows.Forms.ComboBox();
            this.lblNumberRegistrar = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTypeRegistrar = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTypeRegistrar = new System.Windows.Forms.Label();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.radioBtnChange = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.datePickerManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerManufactureDateNew = new System.Windows.Forms.DateTimePicker();
            this.lblManufactureDateNew = new System.Windows.Forms.Label();
            this.cmbTypeRegistrarNew = new System.Windows.Forms.ComboBox();
            this.lblNumberRegistrarNew = new System.Windows.Forms.Label();
            this.txtNumberRegistrarNew = new System.Windows.Forms.TextBox();
            this.lblTypeRegistrarNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.AutoSize = true;
            this.lblManufactureDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblManufactureDate.Location = new System.Drawing.Point(187, 96);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(161, 21);
            this.lblManufactureDate.TabIndex = 123;
            this.lblManufactureDate.Text = "Дата изготовления";
            // 
            // cmbNumberRegistrar
            // 
            this.cmbNumberRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbNumberRegistrar.FormattingEnabled = true;
            this.cmbNumberRegistrar.Location = new System.Drawing.Point(354, 12);
            this.cmbNumberRegistrar.Name = "cmbNumberRegistrar";
            this.cmbNumberRegistrar.Size = new System.Drawing.Size(182, 29);
            this.cmbNumberRegistrar.TabIndex = 121;
            this.cmbNumberRegistrar.SelectedIndexChanged += new System.EventHandler(this.cmbNumberRegistrar_SelectedIndexChanged);
            // 
            // lblNumberRegistrar
            // 
            this.lblNumberRegistrar.AutoSize = true;
            this.lblNumberRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberRegistrar.Location = new System.Drawing.Point(173, 14);
            this.lblNumberRegistrar.Name = "lblNumberRegistrar";
            this.lblNumberRegistrar.Size = new System.Drawing.Size(175, 21);
            this.lblNumberRegistrar.TabIndex = 120;
            this.lblNumberRegistrar.Text = "Номер регистратора";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(426, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 119;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(285, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTypeRegistrar
            // 
            this.txtTypeRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTypeRegistrar.Location = new System.Drawing.Point(354, 53);
            this.txtTypeRegistrar.Name = "txtTypeRegistrar";
            this.txtTypeRegistrar.Size = new System.Drawing.Size(182, 29);
            this.txtTypeRegistrar.TabIndex = 117;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblChange.Location = new System.Drawing.Point(299, 147);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(108, 21);
            this.lblChange.TabIndex = 116;
            this.lblChange.Text = "Заменить на";
            // 
            // lblTypeRegistrar
            // 
            this.lblTypeRegistrar.AutoSize = true;
            this.lblTypeRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeRegistrar.Location = new System.Drawing.Point(194, 55);
            this.lblTypeRegistrar.Name = "lblTypeRegistrar";
            this.lblTypeRegistrar.Size = new System.Drawing.Size(154, 21);
            this.lblTypeRegistrar.TabIndex = 114;
            this.lblTypeRegistrar.Text = "Тип регистратора";
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnDelete.Location = new System.Drawing.Point(12, 94);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(101, 25);
            this.radioBtnDelete.TabIndex = 113;
            this.radioBtnDelete.TabStop = true;
            this.radioBtnDelete.Text = "Удаление";
            this.radioBtnDelete.UseVisualStyleBackColor = true;
            this.radioBtnDelete.CheckedChanged += new System.EventHandler(this.radioBtnDelete_CheckedChanged);
            // 
            // radioBtnChange
            // 
            this.radioBtnChange.AutoSize = true;
            this.radioBtnChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnChange.Location = new System.Drawing.Point(12, 53);
            this.radioBtnChange.Name = "radioBtnChange";
            this.radioBtnChange.Size = new System.Drawing.Size(115, 25);
            this.radioBtnChange.TabIndex = 112;
            this.radioBtnChange.TabStop = true;
            this.radioBtnChange.Text = "Изменение";
            this.radioBtnChange.UseVisualStyleBackColor = true;
            this.radioBtnChange.CheckedChanged += new System.EventHandler(this.radioBtnChange_CheckedChanged);
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnAdd.Location = new System.Drawing.Point(12, 12);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(123, 25);
            this.radioBtnAdd.TabIndex = 111;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Добавление";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // datePickerManufactureDate
            // 
            this.datePickerManufactureDate.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerManufactureDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerManufactureDate.Location = new System.Drawing.Point(354, 94);
            this.datePickerManufactureDate.Name = "datePickerManufactureDate";
            this.datePickerManufactureDate.Size = new System.Drawing.Size(182, 29);
            this.datePickerManufactureDate.TabIndex = 129;
            // 
            // datePickerManufactureDateNew
            // 
            this.datePickerManufactureDateNew.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerManufactureDateNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerManufactureDateNew.Location = new System.Drawing.Point(354, 271);
            this.datePickerManufactureDateNew.Name = "datePickerManufactureDateNew";
            this.datePickerManufactureDateNew.Size = new System.Drawing.Size(182, 29);
            this.datePickerManufactureDateNew.TabIndex = 135;
            // 
            // lblManufactureDateNew
            // 
            this.lblManufactureDateNew.AutoSize = true;
            this.lblManufactureDateNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblManufactureDateNew.Location = new System.Drawing.Point(187, 273);
            this.lblManufactureDateNew.Name = "lblManufactureDateNew";
            this.lblManufactureDateNew.Size = new System.Drawing.Size(161, 21);
            this.lblManufactureDateNew.TabIndex = 134;
            this.lblManufactureDateNew.Text = "Дата изготовления";
            // 
            // cmbTypeRegistrarNew
            // 
            this.cmbTypeRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbTypeRegistrarNew.FormattingEnabled = true;
            this.cmbTypeRegistrarNew.Location = new System.Drawing.Point(354, 229);
            this.cmbTypeRegistrarNew.Name = "cmbTypeRegistrarNew";
            this.cmbTypeRegistrarNew.Size = new System.Drawing.Size(182, 29);
            this.cmbTypeRegistrarNew.TabIndex = 133;
            // 
            // lblNumberRegistrarNew
            // 
            this.lblNumberRegistrarNew.AutoSize = true;
            this.lblNumberRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberRegistrarNew.Location = new System.Drawing.Point(173, 191);
            this.lblNumberRegistrarNew.Name = "lblNumberRegistrarNew";
            this.lblNumberRegistrarNew.Size = new System.Drawing.Size(175, 21);
            this.lblNumberRegistrarNew.TabIndex = 132;
            this.lblNumberRegistrarNew.Text = "Номер регистратора";
            // 
            // txtNumberRegistrarNew
            // 
            this.txtNumberRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtNumberRegistrarNew.Location = new System.Drawing.Point(352, 188);
            this.txtNumberRegistrarNew.Name = "txtNumberRegistrarNew";
            this.txtNumberRegistrarNew.Size = new System.Drawing.Size(182, 29);
            this.txtNumberRegistrarNew.TabIndex = 131;
            // 
            // lblTypeRegistrarNew
            // 
            this.lblTypeRegistrarNew.AutoSize = true;
            this.lblTypeRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeRegistrarNew.Location = new System.Drawing.Point(194, 232);
            this.lblTypeRegistrarNew.Name = "lblTypeRegistrarNew";
            this.lblTypeRegistrarNew.Size = new System.Drawing.Size(154, 21);
            this.lblTypeRegistrarNew.TabIndex = 130;
            this.lblTypeRegistrarNew.Text = "Тип регистратора";
            // 
            // ChangeRegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 371);
            this.Controls.Add(this.datePickerManufactureDateNew);
            this.Controls.Add(this.lblManufactureDateNew);
            this.Controls.Add(this.cmbTypeRegistrarNew);
            this.Controls.Add(this.lblNumberRegistrarNew);
            this.Controls.Add(this.txtNumberRegistrarNew);
            this.Controls.Add(this.lblTypeRegistrarNew);
            this.Controls.Add(this.datePickerManufactureDate);
            this.Controls.Add(this.lblManufactureDate);
            this.Controls.Add(this.cmbNumberRegistrar);
            this.Controls.Add(this.lblNumberRegistrar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTypeRegistrar);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTypeRegistrar);
            this.Controls.Add(this.radioBtnDelete);
            this.Controls.Add(this.radioBtnChange);
            this.Controls.Add(this.radioBtnAdd);
            this.Name = "ChangeRegistrarForm";
            this.Load += new System.EventHandler(this.ChangeRegistrarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.ComboBox cmbNumberRegistrar;
        private System.Windows.Forms.Label lblNumberRegistrar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTypeRegistrar;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTypeRegistrar;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.RadioButton radioBtnChange;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.DateTimePicker datePickerManufactureDate;
        private System.Windows.Forms.DateTimePicker datePickerManufactureDateNew;
        private System.Windows.Forms.Label lblManufactureDateNew;
        private System.Windows.Forms.ComboBox cmbTypeRegistrarNew;
        private System.Windows.Forms.Label lblNumberRegistrarNew;
        private System.Windows.Forms.TextBox txtNumberRegistrarNew;
        private System.Windows.Forms.Label lblTypeRegistrarNew;
    }
}