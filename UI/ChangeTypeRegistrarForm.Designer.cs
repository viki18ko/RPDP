namespace RPDP.UI
{
    partial class ChangeTypeRegistrarForm
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
            this.txtTypeRegistrarNew = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTypeRegistrarNew = new System.Windows.Forms.Label();
            this.cmbTypeRegistrar = new System.Windows.Forms.ComboBox();
            this.lblTypeRegistrar = new System.Windows.Forms.Label();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.radioBtnChange = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(420, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(280, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTypeRegistrarNew
            // 
            this.txtTypeRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTypeRegistrarNew.Location = new System.Drawing.Point(346, 93);
            this.txtTypeRegistrarNew.Name = "txtTypeRegistrarNew";
            this.txtTypeRegistrarNew.Size = new System.Drawing.Size(182, 29);
            this.txtTypeRegistrarNew.TabIndex = 88;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblChange.Location = new System.Drawing.Point(304, 55);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(108, 21);
            this.lblChange.TabIndex = 87;
            this.lblChange.Text = "Заменить на";
            // 
            // lblTypeRegistrarNew
            // 
            this.lblTypeRegistrarNew.AutoSize = true;
            this.lblTypeRegistrarNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeRegistrarNew.Location = new System.Drawing.Point(188, 96);
            this.lblTypeRegistrarNew.Name = "lblTypeRegistrarNew";
            this.lblTypeRegistrarNew.Size = new System.Drawing.Size(154, 21);
            this.lblTypeRegistrarNew.TabIndex = 86;
            this.lblTypeRegistrarNew.Text = "Тип регистратора";
            // 
            // cmbTypeRegistrar
            // 
            this.cmbTypeRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbTypeRegistrar.FormattingEnabled = true;
            this.cmbTypeRegistrar.Location = new System.Drawing.Point(346, 11);
            this.cmbTypeRegistrar.Name = "cmbTypeRegistrar";
            this.cmbTypeRegistrar.Size = new System.Drawing.Size(182, 29);
            this.cmbTypeRegistrar.TabIndex = 85;
            // 
            // lblTypeRegistrar
            // 
            this.lblTypeRegistrar.AutoSize = true;
            this.lblTypeRegistrar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTypeRegistrar.Location = new System.Drawing.Point(188, 14);
            this.lblTypeRegistrar.Name = "lblTypeRegistrar";
            this.lblTypeRegistrar.Size = new System.Drawing.Size(154, 21);
            this.lblTypeRegistrar.TabIndex = 84;
            this.lblTypeRegistrar.Text = "Тип регистратора";
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnDelete.Location = new System.Drawing.Point(12, 94);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(101, 25);
            this.radioBtnDelete.TabIndex = 83;
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
            this.radioBtnChange.TabIndex = 82;
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
            this.radioBtnAdd.TabIndex = 81;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Добавление";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // ChangeTypeRegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 196);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTypeRegistrarNew);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTypeRegistrarNew);
            this.Controls.Add(this.cmbTypeRegistrar);
            this.Controls.Add(this.lblTypeRegistrar);
            this.Controls.Add(this.radioBtnDelete);
            this.Controls.Add(this.radioBtnChange);
            this.Controls.Add(this.radioBtnAdd);
            this.Name = "ChangeTypeRegistrarForm";
            this.Load += new System.EventHandler(this.ChangeTypeRegistrarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTypeRegistrarNew;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTypeRegistrarNew;
        private System.Windows.Forms.ComboBox cmbTypeRegistrar;
        private System.Windows.Forms.Label lblTypeRegistrar;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.RadioButton radioBtnChange;
        private System.Windows.Forms.RadioButton radioBtnAdd;
    }
}