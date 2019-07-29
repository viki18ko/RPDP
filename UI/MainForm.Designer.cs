namespace RPDP.UI
{
    partial class MainForm
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
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактированиеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вагоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классыМашинистовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоВагоновВСоставеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.регистраторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыВагоновToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.типыРегистраторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.btnCreateAct = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCreateReport.Location = new System.Drawing.Point(45, 139);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(138, 73);
            this.btnCreateReport.TabIndex = 3;
            this.btnCreateReport.Text = "Создание отчета по регистраторам";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(225, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStripChange";
            // 
            // редактированиеДанныхToolStripMenuItem
            // 
            this.редактированиеДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вагоныToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.классыМашинистовToolStripMenuItem,
            this.количествоВагоновВСоставеToolStripMenuItem,
            this.маршрутыToolStripMenuItem1,
            this.регистраторыToolStripMenuItem,
            this.составыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.типыВагоновToolStripMenuItem1,
            this.типыРегистраторовToolStripMenuItem});
            this.редактированиеДанныхToolStripMenuItem.Name = "редактированиеДанныхToolStripMenuItem";
            this.редактированиеДанныхToolStripMenuItem.Size = new System.Drawing.Size(216, 25);
            this.редактированиеДанныхToolStripMenuItem.Text = "Редактирование данных";
            // 
            // вагоныToolStripMenuItem
            // 
            this.вагоныToolStripMenuItem.Name = "вагоныToolStripMenuItem";
            this.вагоныToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.вагоныToolStripMenuItem.Text = "Вагоны";
            this.вагоныToolStripMenuItem.Click += new System.EventHandler(this.вагоныToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // классыМашинистовToolStripMenuItem
            // 
            this.классыМашинистовToolStripMenuItem.Name = "классыМашинистовToolStripMenuItem";
            this.классыМашинистовToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.классыМашинистовToolStripMenuItem.Text = "Классы машинистов";
            this.классыМашинистовToolStripMenuItem.Click += new System.EventHandler(this.классыМашинистовToolStripMenuItem_Click);
            // 
            // количествоВагоновВСоставеToolStripMenuItem
            // 
            this.количествоВагоновВСоставеToolStripMenuItem.Name = "количествоВагоновВСоставеToolStripMenuItem";
            this.количествоВагоновВСоставеToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.количествоВагоновВСоставеToolStripMenuItem.Text = "Количество вагонов в составе";
            this.количествоВагоновВСоставеToolStripMenuItem.Click += new System.EventHandler(this.количествоВагоновВСоставеToolStripMenuItem_Click);
            // 
            // маршрутыToolStripMenuItem1
            // 
            this.маршрутыToolStripMenuItem1.Name = "маршрутыToolStripMenuItem1";
            this.маршрутыToolStripMenuItem1.Size = new System.Drawing.Size(324, 26);
            this.маршрутыToolStripMenuItem1.Text = "Маршруты";
            this.маршрутыToolStripMenuItem1.Click += new System.EventHandler(this.маршрутыToolStripMenuItem1_Click);
            // 
            // регистраторыToolStripMenuItem
            // 
            this.регистраторыToolStripMenuItem.Name = "регистраторыToolStripMenuItem";
            this.регистраторыToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.регистраторыToolStripMenuItem.Text = "Регистраторы";
            this.регистраторыToolStripMenuItem.Click += new System.EventHandler(this.регистраторыToolStripMenuItem_Click);
            // 
            // составыToolStripMenuItem
            // 
            this.составыToolStripMenuItem.Name = "составыToolStripMenuItem";
            this.составыToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.составыToolStripMenuItem.Text = "Составы";
            this.составыToolStripMenuItem.Click += new System.EventHandler(this.составыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // типыВагоновToolStripMenuItem1
            // 
            this.типыВагоновToolStripMenuItem1.Name = "типыВагоновToolStripMenuItem1";
            this.типыВагоновToolStripMenuItem1.Size = new System.Drawing.Size(324, 26);
            this.типыВагоновToolStripMenuItem1.Text = "Типы вагонов";
            this.типыВагоновToolStripMenuItem1.Click += new System.EventHandler(this.типыВагоновToolStripMenuItem1_Click);
            // 
            // типыРегистраторовToolStripMenuItem
            // 
            this.типыРегистраторовToolStripMenuItem.Name = "типыРегистраторовToolStripMenuItem";
            this.типыРегистраторовToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.типыРегистраторовToolStripMenuItem.Text = "Типы регистраторов";
            this.типыРегистраторовToolStripMenuItem.Click += new System.EventHandler(this.типыРегистраторовToolStripMenuItem_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnExitApplication.Location = new System.Drawing.Point(45, 243);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(138, 39);
            this.btnExitApplication.TabIndex = 5;
            this.btnExitApplication.Text = "Выход";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // btnCreateAct
            // 
            this.btnCreateAct.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCreateAct.Location = new System.Drawing.Point(45, 44);
            this.btnCreateAct.Name = "btnCreateAct";
            this.btnCreateAct.Size = new System.Drawing.Size(138, 73);
            this.btnCreateAct.TabIndex = 6;
            this.btnCreateAct.Text = "Создание акта по нарушениям";
            this.btnCreateAct.UseVisualStyleBackColor = true;
            this.btnCreateAct.Click += new System.EventHandler(this.btnCreateAct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 294);
            this.Controls.Add(this.btnCreateAct);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnCreateAct;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактированиеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вагоныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классыМашинистовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоВагоновВСоставеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem регистраторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыВагоновToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem типыРегистраторовToolStripMenuItem;
        private System.Windows.Forms.Button btnExitApplication;
    }
}

