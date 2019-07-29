namespace RPDP.UI
{
    partial class ChangeRouteForm
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
            this.txtRouteNew = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblRouteNew = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.radioBtnChange = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(292, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(156, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRouteNew
            // 
            this.txtRouteNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtRouteNew.Location = new System.Drawing.Point(309, 96);
            this.txtRouteNew.Name = "txtRouteNew";
            this.txtRouteNew.Size = new System.Drawing.Size(91, 29);
            this.txtRouteNew.TabIndex = 68;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblChange.Location = new System.Drawing.Point(240, 58);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(108, 21);
            this.lblChange.TabIndex = 67;
            this.lblChange.Text = "Заменить на";
            // 
            // lblRouteNew
            // 
            this.lblRouteNew.AutoSize = true;
            this.lblRouteNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRouteNew.Location = new System.Drawing.Point(191, 99);
            this.lblRouteNew.Name = "lblRouteNew";
            this.lblRouteNew.Size = new System.Drawing.Size(108, 21);
            this.lblRouteNew.TabIndex = 66;
            this.lblRouteNew.Text = "Маршрут №";
            // 
            // cmbRoute
            // 
            this.cmbRoute.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(309, 14);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(91, 29);
            this.cmbRoute.TabIndex = 65;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRoute.Location = new System.Drawing.Point(191, 17);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(108, 21);
            this.lblRoute.TabIndex = 64;
            this.lblRoute.Text = "Маршрут №";
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnDelete.Location = new System.Drawing.Point(15, 97);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(101, 25);
            this.radioBtnDelete.TabIndex = 63;
            this.radioBtnDelete.TabStop = true;
            this.radioBtnDelete.Text = "Удаление";
            this.radioBtnDelete.UseVisualStyleBackColor = true;
            this.radioBtnDelete.CheckedChanged += new System.EventHandler(this.radioBtnDelete_CheckedChanged);
            // 
            // radioBtnChange
            // 
            this.radioBtnChange.AutoSize = true;
            this.radioBtnChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnChange.Location = new System.Drawing.Point(15, 56);
            this.radioBtnChange.Name = "radioBtnChange";
            this.radioBtnChange.Size = new System.Drawing.Size(115, 25);
            this.radioBtnChange.TabIndex = 62;
            this.radioBtnChange.TabStop = true;
            this.radioBtnChange.Text = "Изменение";
            this.radioBtnChange.UseVisualStyleBackColor = true;
            this.radioBtnChange.CheckedChanged += new System.EventHandler(this.radioBtnChange_CheckedChanged);
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnAdd.Location = new System.Drawing.Point(15, 15);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(123, 25);
            this.radioBtnAdd.TabIndex = 61;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Добавление";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // ChangeRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRouteNew);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblRouteNew);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.radioBtnDelete);
            this.Controls.Add(this.radioBtnChange);
            this.Controls.Add(this.radioBtnAdd);
            this.Name = "ChangeRouteForm";
            this.Load += new System.EventHandler(this.ChangeRouteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRouteNew;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblRouteNew;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.RadioButton radioBtnChange;
        private System.Windows.Forms.RadioButton radioBtnAdd;
    }
}