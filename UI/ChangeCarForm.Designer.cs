namespace RPDP.UI
{
    partial class ChangeCarForm
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
            this.txtTypeCar = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.cmbTypeCarNew = new System.Windows.Forms.ComboBox();
            this.lblTypeCar = new System.Windows.Forms.Label();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.radioBtnChange = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.cmbNumberCar = new System.Windows.Forms.ComboBox();
            this.lblNumberCar = new System.Windows.Forms.Label();
            this.txtNumberRegistrar = new System.Windows.Forms.TextBox();
            this.lblNumberRegistrar = new System.Windows.Forms.Label();
            this.lblNumberRegistrarNew = new System.Windows.Forms.Label();
            this.cmbNumberRegistrarNew = new System.Windows.Forms.ComboBox();
            this.lblNumberCarNew = new System.Windows.Forms.Label();
            this.txtNumberCarNew = new System.Windows.Forms.TextBox();
            this.lblTypeCarNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(426, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 100;
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
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTypeCar
            // 
            this.txtTypeCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTypeCar.Location = new System.Drawing.Point(352, 53);
            this.txtTypeCar.Name = "txtTypeCar";
            this.txtTypeCar.Size = new System.Drawing.Size(182, 29);
            this.txtTypeCar.TabIndex = 98;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblChange.Location = new System.Drawing.Point(299, 147);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(108, 21);
            this.lblChange.TabIndex = 97;
            this.lblChange.Text = "Заменить на";
            // 
            // cmbTypeCarNew
            // 
            this.cmbTypeCarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbTypeCarNew.FormattingEnabled = true;
            this.cmbTypeCarNew.Location = new System.Drawing.Point(352, 233);
            this.cmbTypeCarNew.Name = "cmbTypeCarNew";
            this.cmbTypeCarNew.Size = new System.Drawing.Size(182, 29);
            this.cmbTypeCarNew.TabIndex = 95;
            // 
            // lblTypeCar
            // 
            this.lblTypeCar.AutoSize = true;
            this.lblTypeCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeCar.Location = new System.Drawing.Point(234, 55);
            this.lblTypeCar.Name = "lblTypeCar";
            this.lblTypeCar.Size = new System.Drawing.Size(100, 21);
            this.lblTypeCar.TabIndex = 94;
            this.lblTypeCar.Text = "Тип вагона";
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnDelete.Location = new System.Drawing.Point(12, 94);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(101, 25);
            this.radioBtnDelete.TabIndex = 93;
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
            this.radioBtnChange.TabIndex = 92;
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
            this.radioBtnAdd.TabIndex = 91;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Добавление";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // cmbNumberCar
            // 
            this.cmbNumberCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbNumberCar.FormattingEnabled = true;
            this.cmbNumberCar.Location = new System.Drawing.Point(352, 11);
            this.cmbNumberCar.Name = "cmbNumberCar";
            this.cmbNumberCar.Size = new System.Drawing.Size(182, 29);
            this.cmbNumberCar.TabIndex = 102;
            this.cmbNumberCar.SelectedIndexChanged += new System.EventHandler(this.cmbNumberCar_SelectedIndexChanged);
            // 
            // lblNumberCar
            // 
            this.lblNumberCar.AutoSize = true;
            this.lblNumberCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberCar.Location = new System.Drawing.Point(213, 14);
            this.lblNumberCar.Name = "lblNumberCar";
            this.lblNumberCar.Size = new System.Drawing.Size(121, 21);
            this.lblNumberCar.TabIndex = 101;
            this.lblNumberCar.Text = "Номер вагона";
            // 
            // txtNumberRegistrar
            // 
            this.txtNumberRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtNumberRegistrar.Location = new System.Drawing.Point(352, 94);
            this.txtNumberRegistrar.Name = "txtNumberRegistrar";
            this.txtNumberRegistrar.Size = new System.Drawing.Size(182, 29);
            this.txtNumberRegistrar.TabIndex = 103;
            // 
            // lblNumberRegistrar
            // 
            this.lblNumberRegistrar.AutoSize = true;
            this.lblNumberRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberRegistrar.Location = new System.Drawing.Point(159, 96);
            this.lblNumberRegistrar.Name = "lblNumberRegistrar";
            this.lblNumberRegistrar.Size = new System.Drawing.Size(175, 21);
            this.lblNumberRegistrar.TabIndex = 104;
            this.lblNumberRegistrar.Text = "Номер регистратора";
            // 
            // lblNumberRegistrarNew
            // 
            this.lblNumberRegistrarNew.AutoSize = true;
            this.lblNumberRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberRegistrarNew.Location = new System.Drawing.Point(159, 278);
            this.lblNumberRegistrarNew.Name = "lblNumberRegistrarNew";
            this.lblNumberRegistrarNew.Size = new System.Drawing.Size(175, 21);
            this.lblNumberRegistrarNew.TabIndex = 110;
            this.lblNumberRegistrarNew.Text = "Номер регистратора";
            // 
            // cmbNumberRegistrarNew
            // 
            this.cmbNumberRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbNumberRegistrarNew.FormattingEnabled = true;
            this.cmbNumberRegistrarNew.Location = new System.Drawing.Point(352, 275);
            this.cmbNumberRegistrarNew.Name = "cmbNumberRegistrarNew";
            this.cmbNumberRegistrarNew.Size = new System.Drawing.Size(182, 29);
            this.cmbNumberRegistrarNew.TabIndex = 108;
            // 
            // lblNumberCarNew
            // 
            this.lblNumberCarNew.AutoSize = true;
            this.lblNumberCarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberCarNew.Location = new System.Drawing.Point(213, 193);
            this.lblNumberCarNew.Name = "lblNumberCarNew";
            this.lblNumberCarNew.Size = new System.Drawing.Size(121, 21);
            this.lblNumberCarNew.TabIndex = 107;
            this.lblNumberCarNew.Text = "Номер вагона";
            // 
            // txtNumberCarNew
            // 
            this.txtNumberCarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtNumberCarNew.Location = new System.Drawing.Point(352, 190);
            this.txtNumberCarNew.Name = "txtNumberCarNew";
            this.txtNumberCarNew.Size = new System.Drawing.Size(182, 29);
            this.txtNumberCarNew.TabIndex = 106;
            // 
            // lblTypeCarNew
            // 
            this.lblTypeCarNew.AutoSize = true;
            this.lblTypeCarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeCarNew.Location = new System.Drawing.Point(234, 236);
            this.lblTypeCarNew.Name = "lblTypeCarNew";
            this.lblTypeCarNew.Size = new System.Drawing.Size(100, 21);
            this.lblTypeCarNew.TabIndex = 105;
            this.lblTypeCarNew.Text = "Тип вагона";
            // 
            // ChangeCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 373);
            this.Controls.Add(this.lblNumberRegistrarNew);
            this.Controls.Add(this.cmbNumberRegistrarNew);
            this.Controls.Add(this.lblNumberCarNew);
            this.Controls.Add(this.txtNumberCarNew);
            this.Controls.Add(this.lblTypeCarNew);
            this.Controls.Add(this.lblNumberRegistrar);
            this.Controls.Add(this.txtNumberRegistrar);
            this.Controls.Add(this.cmbNumberCar);
            this.Controls.Add(this.lblNumberCar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTypeCar);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.cmbTypeCarNew);
            this.Controls.Add(this.lblTypeCar);
            this.Controls.Add(this.radioBtnDelete);
            this.Controls.Add(this.radioBtnChange);
            this.Controls.Add(this.radioBtnAdd);
            this.Name = "ChangeCarForm";
            this.Load += new System.EventHandler(this.ChangeCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTypeCar;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.ComboBox cmbTypeCarNew;
        private System.Windows.Forms.Label lblTypeCar;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.RadioButton radioBtnChange;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.ComboBox cmbNumberCar;
        private System.Windows.Forms.Label lblNumberCar;
        private System.Windows.Forms.TextBox txtNumberRegistrar;
        private System.Windows.Forms.Label lblNumberRegistrar;
        private System.Windows.Forms.Label lblNumberRegistrarNew;
        private System.Windows.Forms.ComboBox cmbNumberRegistrarNew;
        private System.Windows.Forms.Label lblNumberCarNew;
        private System.Windows.Forms.TextBox txtNumberCarNew;
        private System.Windows.Forms.Label lblTypeCarNew;
    }
}