namespace RPDP.UI
{
    partial class ChangeTypeCarForm
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
            this.txtTypeCarNew = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTypeCarNew = new System.Windows.Forms.Label();
            this.cmbTypeCar = new System.Windows.Forms.ComboBox();
            this.lblTypeCar = new System.Windows.Forms.Label();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.radioBtnChange = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(371, 143);
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
            this.btnSave.Location = new System.Drawing.Point(235, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTypeCarNew
            // 
            this.txtTypeCarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTypeCarNew.Location = new System.Drawing.Point(299, 93);
            this.txtTypeCarNew.Name = "txtTypeCarNew";
            this.txtTypeCarNew.Size = new System.Drawing.Size(180, 29);
            this.txtTypeCarNew.TabIndex = 78;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblChange.Location = new System.Drawing.Point(289, 55);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(108, 21);
            this.lblChange.TabIndex = 77;
            this.lblChange.Text = "Заменить на";
            // 
            // lblTypeCarNew
            // 
            this.lblTypeCarNew.AutoSize = true;
            this.lblTypeCarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeCarNew.Location = new System.Drawing.Point(188, 96);
            this.lblTypeCarNew.Name = "lblTypeCarNew";
            this.lblTypeCarNew.Size = new System.Drawing.Size(100, 21);
            this.lblTypeCarNew.TabIndex = 76;
            this.lblTypeCarNew.Text = "Тип вагона";
            // 
            // cmbTypeCar
            // 
            this.cmbTypeCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbTypeCar.FormattingEnabled = true;
            this.cmbTypeCar.Location = new System.Drawing.Point(299, 11);
            this.cmbTypeCar.Name = "cmbTypeCar";
            this.cmbTypeCar.Size = new System.Drawing.Size(180, 29);
            this.cmbTypeCar.TabIndex = 75;
            // 
            // lblTypeCar
            // 
            this.lblTypeCar.AutoSize = true;
            this.lblTypeCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeCar.Location = new System.Drawing.Point(188, 14);
            this.lblTypeCar.Name = "lblTypeCar";
            this.lblTypeCar.Size = new System.Drawing.Size(100, 21);
            this.lblTypeCar.TabIndex = 74;
            this.lblTypeCar.Text = "Тип вагона";
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnDelete.Location = new System.Drawing.Point(12, 94);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(101, 25);
            this.radioBtnDelete.TabIndex = 73;
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
            this.radioBtnChange.TabIndex = 72;
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
            this.radioBtnAdd.TabIndex = 71;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Добавление";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // ChangeTypeCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTypeCarNew);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTypeCarNew);
            this.Controls.Add(this.cmbTypeCar);
            this.Controls.Add(this.lblTypeCar);
            this.Controls.Add(this.radioBtnDelete);
            this.Controls.Add(this.radioBtnChange);
            this.Controls.Add(this.radioBtnAdd);
            this.Name = "ChangeTypeCarForm";
            this.Load += new System.EventHandler(this.ChangeTypeCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTypeCarNew;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTypeCarNew;
        private System.Windows.Forms.ComboBox cmbTypeCar;
        private System.Windows.Forms.Label lblTypeCar;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.RadioButton radioBtnChange;
        private System.Windows.Forms.RadioButton radioBtnAdd;
    }
}