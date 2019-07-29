namespace RPDP.UI
{
    partial class CreateReportRegistrarForm
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
            this.lblRepair = new System.Windows.Forms.Label();
            this.lblMaking = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtDefect = new System.Windows.Forms.TextBox();
            this.lblDefect = new System.Windows.Forms.Label();
            this.txtTypeRegistrar = new System.Windows.Forms.TextBox();
            this.txtNumberRegistrar = new System.Windows.Forms.TextBox();
            this.lblTypeRegistrar = new System.Windows.Forms.Label();
            this.lblNumberRegistrar = new System.Windows.Forms.Label();
            this.lblNumberCar = new System.Windows.Forms.Label();
            this.cmbNumberCar = new System.Windows.Forms.ComboBox();
            this.datePickerRepair = new System.Windows.Forms.DateTimePicker();
            this.datePickerManufacture = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(595, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(459, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRepair
            // 
            this.lblRepair.AutoSize = true;
            this.lblRepair.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRepair.Location = new System.Drawing.Point(383, 59);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Size = new System.Drawing.Size(118, 21);
            this.lblRepair.TabIndex = 41;
            this.lblRepair.Text = "Дата ремонта";
            // 
            // lblMaking
            // 
            this.lblMaking.AutoSize = true;
            this.lblMaking.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblMaking.Location = new System.Drawing.Point(383, 13);
            this.lblMaking.Name = "lblMaking";
            this.lblMaking.Size = new System.Drawing.Size(161, 21);
            this.lblMaking.TabIndex = 40;
            this.lblMaking.Text = "Дата изготовления";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRemark.Location = new System.Drawing.Point(9, 252);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(109, 21);
            this.lblRemark.TabIndex = 39;
            this.lblRemark.Text = "Примечание";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtRemark.Location = new System.Drawing.Point(149, 230);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(554, 59);
            this.txtRemark.TabIndex = 38;
            // 
            // txtDefect
            // 
            this.txtDefect.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDefect.Location = new System.Drawing.Point(149, 149);
            this.txtDefect.Multiline = true;
            this.txtDefect.Name = "txtDefect";
            this.txtDefect.Size = new System.Drawing.Size(554, 59);
            this.txtDefect.TabIndex = 36;
            // 
            // lblDefect
            // 
            this.lblDefect.AutoSize = true;
            this.lblDefect.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDefect.Location = new System.Drawing.Point(9, 169);
            this.lblDefect.Name = "lblDefect";
            this.lblDefect.Size = new System.Drawing.Size(134, 21);
            this.lblDefect.TabIndex = 37;
            this.lblDefect.Text = "Неисправности";
            // 
            // txtTypeRegistrar
            // 
            this.txtTypeRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTypeRegistrar.Location = new System.Drawing.Point(190, 102);
            this.txtTypeRegistrar.Name = "txtTypeRegistrar";
            this.txtTypeRegistrar.Size = new System.Drawing.Size(117, 29);
            this.txtTypeRegistrar.TabIndex = 35;
            // 
            // txtNumberRegistrar
            // 
            this.txtNumberRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtNumberRegistrar.Location = new System.Drawing.Point(190, 56);
            this.txtNumberRegistrar.Name = "txtNumberRegistrar";
            this.txtNumberRegistrar.Size = new System.Drawing.Size(117, 29);
            this.txtNumberRegistrar.TabIndex = 34;
            // 
            // lblTypeRegistrar
            // 
            this.lblTypeRegistrar.AutoSize = true;
            this.lblTypeRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeRegistrar.Location = new System.Drawing.Point(9, 105);
            this.lblTypeRegistrar.Name = "lblTypeRegistrar";
            this.lblTypeRegistrar.Size = new System.Drawing.Size(154, 21);
            this.lblTypeRegistrar.TabIndex = 33;
            this.lblTypeRegistrar.Text = "Тип регистратора";
            // 
            // lblNumberRegistrar
            // 
            this.lblNumberRegistrar.AutoSize = true;
            this.lblNumberRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberRegistrar.Location = new System.Drawing.Point(9, 59);
            this.lblNumberRegistrar.Name = "lblNumberRegistrar";
            this.lblNumberRegistrar.Size = new System.Drawing.Size(175, 21);
            this.lblNumberRegistrar.TabIndex = 32;
            this.lblNumberRegistrar.Text = "Номер регистратора";
            // 
            // lblNumberCar
            // 
            this.lblNumberCar.AutoSize = true;
            this.lblNumberCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberCar.Location = new System.Drawing.Point(9, 13);
            this.lblNumberCar.Name = "lblNumberCar";
            this.lblNumberCar.Size = new System.Drawing.Size(121, 21);
            this.lblNumberCar.TabIndex = 31;
            this.lblNumberCar.Text = "Номер вагона";
            // 
            // cmbNumberCar
            // 
            this.cmbNumberCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbNumberCar.FormattingEnabled = true;
            this.cmbNumberCar.Location = new System.Drawing.Point(190, 10);
            this.cmbNumberCar.Name = "cmbNumberCar";
            this.cmbNumberCar.Size = new System.Drawing.Size(117, 29);
            this.cmbNumberCar.TabIndex = 30;
            this.cmbNumberCar.SelectedIndexChanged += new System.EventHandler(this.cmbNumberCar_SelectedIndexChanged);
            // 
            // datePickerRepair
            // 
            this.datePickerRepair.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerRepair.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerRepair.Location = new System.Drawing.Point(550, 56);
            this.datePickerRepair.Name = "datePickerRepair";
            this.datePickerRepair.Size = new System.Drawing.Size(149, 29);
            this.datePickerRepair.TabIndex = 45;
            // 
            // datePickerManufacture
            // 
            this.datePickerManufacture.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerManufacture.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerManufacture.Location = new System.Drawing.Point(550, 7);
            this.datePickerManufacture.Name = "datePickerManufacture";
            this.datePickerManufacture.Size = new System.Drawing.Size(149, 29);
            this.datePickerManufacture.TabIndex = 46;
            // 
            // CreateReportRegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 363);
            this.Controls.Add(this.datePickerManufacture);
            this.Controls.Add(this.datePickerRepair);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRepair);
            this.Controls.Add(this.lblMaking);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtDefect);
            this.Controls.Add(this.lblDefect);
            this.Controls.Add(this.txtTypeRegistrar);
            this.Controls.Add(this.txtNumberRegistrar);
            this.Controls.Add(this.lblTypeRegistrar);
            this.Controls.Add(this.lblNumberRegistrar);
            this.Controls.Add(this.lblNumberCar);
            this.Controls.Add(this.cmbNumberCar);
            this.Name = "CreateReportRegistrarForm";
            this.Load += new System.EventHandler(this.CreateReportRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRepair;
        private System.Windows.Forms.Label lblMaking;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtDefect;
        private System.Windows.Forms.Label lblDefect;
        private System.Windows.Forms.TextBox txtTypeRegistrar;
        private System.Windows.Forms.TextBox txtNumberRegistrar;
        private System.Windows.Forms.Label lblTypeRegistrar;
        private System.Windows.Forms.Label lblNumberRegistrar;
        private System.Windows.Forms.Label lblNumberCar;
        private System.Windows.Forms.ComboBox cmbNumberCar;
        private System.Windows.Forms.DateTimePicker datePickerRepair;
        private System.Windows.Forms.DateTimePicker datePickerManufacture;
    }
}