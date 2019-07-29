namespace RPDP.UI
{
    partial class CreateActForm
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
            this.txtPositionChief = new System.Windows.Forms.TextBox();
            this.cmbChief = new System.Windows.Forms.ComboBox();
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.lblPositionChief = new System.Windows.Forms.Label();
            this.lblChief = new System.Windows.Forms.Label();
            this.lblMechanic = new System.Windows.Forms.Label();
            this.txtDescriptionFoul = new System.Windows.Forms.TextBox();
            this.lblDescriptionFoul = new System.Windows.Forms.Label();
            this.lblTimeFoul = new System.Windows.Forms.Label();
            this.labeTimelAnalysis = new System.Windows.Forms.Label();
            this.cmbCar6 = new System.Windows.Forms.ComboBox();
            this.cmbCar5 = new System.Windows.Forms.ComboBox();
            this.cmbCar4 = new System.Windows.Forms.ComboBox();
            this.cmbCar3 = new System.Windows.Forms.ComboBox();
            this.cmbCar2 = new System.Windows.Forms.ComboBox();
            this.cmbCar1 = new System.Windows.Forms.ComboBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbAmountCar = new System.Windows.Forms.ComboBox();
            this.lblAmountCar = new System.Windows.Forms.Label();
            this.radioBtnCar = new System.Windows.Forms.RadioButton();
            this.radioBtnComposition = new System.Windows.Forms.RadioButton();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblDateTranscript = new System.Windows.Forms.Label();
            this.lblDateAct = new System.Windows.Forms.Label();
            this.txtNumberAct = new System.Windows.Forms.TextBox();
            this.lblNumberAct = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.datePickerStartAnalysis = new System.Windows.Forms.DateTimePicker();
            this.timePickerEndAnalysis = new System.Windows.Forms.DateTimePicker();
            this.timePickerStartAnalysis = new System.Windows.Forms.DateTimePicker();
            this.datePickerEndAnalysis = new System.Windows.Forms.DateTimePicker();
            this.timePickerStartViolation = new System.Windows.Forms.DateTimePicker();
            this.timePickerEndViolation = new System.Windows.Forms.DateTimePicker();
            this.datePickerCreateAct = new System.Windows.Forms.DateTimePicker();
            this.datePickerTranscript = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCancel.Location = new System.Drawing.Point(1005, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 104;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(869, 553);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 103;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPositionChief
            // 
            this.txtPositionChief.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtPositionChief.Location = new System.Drawing.Point(130, 508);
            this.txtPositionChief.Name = "txtPositionChief";
            this.txtPositionChief.Size = new System.Drawing.Size(595, 29);
            this.txtPositionChief.TabIndex = 102;
            // 
            // cmbChief
            // 
            this.cmbChief.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbChief.FormattingEnabled = true;
            this.cmbChief.Location = new System.Drawing.Point(267, 463);
            this.cmbChief.Name = "cmbChief";
            this.cmbChief.Size = new System.Drawing.Size(285, 29);
            this.cmbChief.TabIndex = 101;
            this.cmbChief.SelectedIndexChanged += new System.EventHandler(this.cmbChief_SelectedIndexChanged);
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(267, 416);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(285, 29);
            this.cmbMechanic.TabIndex = 100;
            this.cmbMechanic.SelectedIndexChanged += new System.EventHandler(this.cmbMechanic_SelectedIndexChanged);
            // 
            // lblPositionChief
            // 
            this.lblPositionChief.AutoSize = true;
            this.lblPositionChief.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblPositionChief.Location = new System.Drawing.Point(12, 511);
            this.lblPositionChief.Name = "lblPositionChief";
            this.lblPositionChief.Size = new System.Drawing.Size(101, 21);
            this.lblPositionChief.TabIndex = 99;
            this.lblPositionChief.Text = "Должность";
            // 
            // lblChief
            // 
            this.lblChief.AutoSize = true;
            this.lblChief.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblChief.Location = new System.Drawing.Point(12, 466);
            this.lblChief.Name = "lblChief";
            this.lblChief.Size = new System.Drawing.Size(225, 21);
            this.lblChief.TabIndex = 98;
            this.lblChief.Text = "Лицо, подписывающее акт";
            // 
            // lblMechanic
            // 
            this.lblMechanic.AutoSize = true;
            this.lblMechanic.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblMechanic.Location = new System.Drawing.Point(12, 419);
            this.lblMechanic.Name = "lblMechanic";
            this.lblMechanic.Size = new System.Drawing.Size(244, 21);
            this.lblMechanic.TabIndex = 97;
            this.lblMechanic.Text = "Специалист по расшифровке";
            // 
            // txtDescriptionFoul
            // 
            this.txtDescriptionFoul.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDescriptionFoul.Location = new System.Drawing.Point(16, 332);
            this.txtDescriptionFoul.Multiline = true;
            this.txtDescriptionFoul.Name = "txtDescriptionFoul";
            this.txtDescriptionFoul.Size = new System.Drawing.Size(1097, 62);
            this.txtDescriptionFoul.TabIndex = 96;
            // 
            // lblDescriptionFoul
            // 
            this.lblDescriptionFoul.AutoSize = true;
            this.lblDescriptionFoul.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDescriptionFoul.Location = new System.Drawing.Point(80, 296);
            this.lblDescriptionFoul.Name = "lblDescriptionFoul";
            this.lblDescriptionFoul.Size = new System.Drawing.Size(936, 21);
            this.lblDescriptionFoul.TabIndex = 95;
            this.lblDescriptionFoul.Text = "Краткое описание случая нарушения и показатели параметров движения поезда в привя" +
    "зке ко времени нарушения";
            // 
            // lblTimeFoul
            // 
            this.lblTimeFoul.AutoSize = true;
            this.lblTimeFoul.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTimeFoul.Location = new System.Drawing.Point(434, 251);
            this.lblTimeFoul.Name = "lblTimeFoul";
            this.lblTimeFoul.Size = new System.Drawing.Size(316, 21);
            this.lblTimeFoul.TabIndex = 94;
            this.lblTimeFoul.Text = "Время начала и окончания нарушения";
            // 
            // labeTimelAnalysis
            // 
            this.labeTimelAnalysis.AutoSize = true;
            this.labeTimelAnalysis.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.labeTimelAnalysis.Location = new System.Drawing.Point(434, 161);
            this.labeTimelAnalysis.Name = "labeTimelAnalysis";
            this.labeTimelAnalysis.Size = new System.Drawing.Size(510, 21);
            this.labeTimelAnalysis.TabIndex = 93;
            this.labeTimelAnalysis.Text = "Временной интервал, в котором производился анализ данных";
            // 
            // cmbCar6
            // 
            this.cmbCar6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbCar6.FormattingEnabled = true;
            this.cmbCar6.Location = new System.Drawing.Point(1022, 111);
            this.cmbCar6.Name = "cmbCar6";
            this.cmbCar6.Size = new System.Drawing.Size(91, 29);
            this.cmbCar6.TabIndex = 92;
            // 
            // cmbCar5
            // 
            this.cmbCar5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbCar5.FormattingEnabled = true;
            this.cmbCar5.Location = new System.Drawing.Point(925, 111);
            this.cmbCar5.Name = "cmbCar5";
            this.cmbCar5.Size = new System.Drawing.Size(91, 29);
            this.cmbCar5.TabIndex = 91;
            // 
            // cmbCar4
            // 
            this.cmbCar4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbCar4.FormattingEnabled = true;
            this.cmbCar4.Location = new System.Drawing.Point(828, 111);
            this.cmbCar4.Name = "cmbCar4";
            this.cmbCar4.Size = new System.Drawing.Size(91, 29);
            this.cmbCar4.TabIndex = 90;
            // 
            // cmbCar3
            // 
            this.cmbCar3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbCar3.FormattingEnabled = true;
            this.cmbCar3.Location = new System.Drawing.Point(731, 111);
            this.cmbCar3.Name = "cmbCar3";
            this.cmbCar3.Size = new System.Drawing.Size(91, 29);
            this.cmbCar3.TabIndex = 89;
            // 
            // cmbCar2
            // 
            this.cmbCar2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbCar2.FormattingEnabled = true;
            this.cmbCar2.Location = new System.Drawing.Point(634, 111);
            this.cmbCar2.Name = "cmbCar2";
            this.cmbCar2.Size = new System.Drawing.Size(91, 29);
            this.cmbCar2.TabIndex = 88;
            // 
            // cmbCar1
            // 
            this.cmbCar1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbCar1.FormattingEnabled = true;
            this.cmbCar1.Location = new System.Drawing.Point(537, 111);
            this.cmbCar1.Name = "cmbCar1";
            this.cmbCar1.Size = new System.Drawing.Size(91, 29);
            this.cmbCar1.TabIndex = 87;
            this.cmbCar1.SelectedIndexChanged += new System.EventHandler(this.cmbCar1_SelectedIndexChanged);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCar.Location = new System.Drawing.Point(434, 114);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(81, 21);
            this.lblCar.TabIndex = 86;
            this.lblCar.Text = "Вагон №";
            // 
            // cmbAmountCar
            // 
            this.cmbAmountCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbAmountCar.FormattingEnabled = true;
            this.cmbAmountCar.Location = new System.Drawing.Point(705, 63);
            this.cmbAmountCar.Name = "cmbAmountCar";
            this.cmbAmountCar.Size = new System.Drawing.Size(143, 29);
            this.cmbAmountCar.TabIndex = 85;
            this.cmbAmountCar.SelectedIndexChanged += new System.EventHandler(this.cmbAmountCar_SelectedIndexChanged);
            // 
            // lblAmountCar
            // 
            this.lblAmountCar.AutoSize = true;
            this.lblAmountCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAmountCar.Location = new System.Drawing.Point(434, 66);
            this.lblAmountCar.Name = "lblAmountCar";
            this.lblAmountCar.Size = new System.Drawing.Size(254, 21);
            this.lblAmountCar.TabIndex = 84;
            this.lblAmountCar.Text = "Количество вагонов в составе";
            // 
            // radioBtnCar
            // 
            this.radioBtnCar.AutoSize = true;
            this.radioBtnCar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnCar.Location = new System.Drawing.Point(666, 14);
            this.radioBtnCar.Name = "radioBtnCar";
            this.radioBtnCar.Size = new System.Drawing.Size(182, 25);
            this.radioBtnCar.TabIndex = 83;
            this.radioBtnCar.TabStop = true;
            this.radioBtnCar.Text = "Повагонный набор";
            this.radioBtnCar.UseVisualStyleBackColor = true;
            this.radioBtnCar.CheckedChanged += new System.EventHandler(this.radioBtnCar_CheckedChanged);
            // 
            // radioBtnComposition
            // 
            this.radioBtnComposition.AutoSize = true;
            this.radioBtnComposition.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.radioBtnComposition.Location = new System.Drawing.Point(438, 14);
            this.radioBtnComposition.Name = "radioBtnComposition";
            this.radioBtnComposition.Size = new System.Drawing.Size(190, 25);
            this.radioBtnComposition.TabIndex = 82;
            this.radioBtnComposition.TabStop = true;
            this.radioBtnComposition.Text = "Посоставный набор";
            this.radioBtnComposition.UseVisualStyleBackColor = true;
            this.radioBtnComposition.CheckedChanged += new System.EventHandler(this.radioBtnComposition_CheckedChanged);
            // 
            // txtInstructor
            // 
            this.txtInstructor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtInstructor.Location = new System.Drawing.Point(130, 204);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(285, 29);
            this.txtInstructor.TabIndex = 81;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblInstructor.Location = new System.Drawing.Point(12, 207);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(50, 21);
            this.lblInstructor.TabIndex = 80;
            this.lblInstructor.Text = "ТЧМ";
            // 
            // cmbRoute
            // 
            this.cmbRoute.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(130, 111);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(126, 29);
            this.cmbRoute.TabIndex = 79;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRoute.Location = new System.Drawing.Point(12, 114);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(108, 21);
            this.lblRoute.TabIndex = 78;
            this.lblRoute.Text = "Маршрут №";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDriver.Location = new System.Drawing.Point(12, 161);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(95, 21);
            this.lblDriver.TabIndex = 77;
            this.lblDriver.Text = "Машинист";
            // 
            // lblDateTranscript
            // 
            this.lblDateTranscript.AutoSize = true;
            this.lblDateTranscript.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDateTranscript.Location = new System.Drawing.Point(12, 66);
            this.lblDateTranscript.Name = "lblDateTranscript";
            this.lblDateTranscript.Size = new System.Drawing.Size(163, 21);
            this.lblDateTranscript.TabIndex = 76;
            this.lblDateTranscript.Text = "Дата расшифровки";
            // 
            // lblDateAct
            // 
            this.lblDateAct.AutoSize = true;
            this.lblDateAct.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDateAct.Location = new System.Drawing.Point(187, 16);
            this.lblDateAct.Name = "lblDateAct";
            this.lblDateAct.Size = new System.Drawing.Size(28, 21);
            this.lblDateAct.TabIndex = 75;
            this.lblDateAct.Text = "от";
            // 
            // txtNumberAct
            // 
            this.txtNumberAct.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtNumberAct.Location = new System.Drawing.Point(81, 13);
            this.txtNumberAct.Name = "txtNumberAct";
            this.txtNumberAct.Size = new System.Drawing.Size(100, 29);
            this.txtNumberAct.TabIndex = 74;
            // 
            // lblNumberAct
            // 
            this.lblNumberAct.AutoSize = true;
            this.lblNumberAct.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumberAct.Location = new System.Drawing.Point(12, 16);
            this.lblNumberAct.Name = "lblNumberAct";
            this.lblNumberAct.Size = new System.Drawing.Size(63, 21);
            this.lblNumberAct.TabIndex = 73;
            this.lblNumberAct.Text = "Акт №";
            // 
            // cmbDriver
            // 
            this.cmbDriver.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(130, 158);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(285, 29);
            this.cmbDriver.TabIndex = 72;
            this.cmbDriver.SelectedIndexChanged += new System.EventHandler(this.cmbDriver_SelectedIndexChanged);
            // 
            // datePickerStartAnalysis
            // 
            this.datePickerStartAnalysis.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerStartAnalysis.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerStartAnalysis.Location = new System.Drawing.Point(438, 204);
            this.datePickerStartAnalysis.Name = "datePickerStartAnalysis";
            this.datePickerStartAnalysis.Size = new System.Drawing.Size(159, 29);
            this.datePickerStartAnalysis.TabIndex = 105;
            // 
            // timePickerEndAnalysis
            // 
            this.timePickerEndAnalysis.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.timePickerEndAnalysis.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.timePickerEndAnalysis.Location = new System.Drawing.Point(1003, 204);
            this.timePickerEndAnalysis.Name = "timePickerEndAnalysis";
            this.timePickerEndAnalysis.Size = new System.Drawing.Size(110, 29);
            this.timePickerEndAnalysis.TabIndex = 106;
            // 
            // timePickerStartAnalysis
            // 
            this.timePickerStartAnalysis.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.timePickerStartAnalysis.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.timePickerStartAnalysis.Location = new System.Drawing.Point(625, 204);
            this.timePickerStartAnalysis.Name = "timePickerStartAnalysis";
            this.timePickerStartAnalysis.Size = new System.Drawing.Size(110, 29);
            this.timePickerStartAnalysis.TabIndex = 107;
            // 
            // datePickerEndAnalysis
            // 
            this.datePickerEndAnalysis.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerEndAnalysis.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerEndAnalysis.Location = new System.Drawing.Point(818, 204);
            this.datePickerEndAnalysis.Name = "datePickerEndAnalysis";
            this.datePickerEndAnalysis.Size = new System.Drawing.Size(159, 29);
            this.datePickerEndAnalysis.TabIndex = 108;
            // 
            // timePickerStartViolation
            // 
            this.timePickerStartViolation.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePickerStartViolation.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.timePickerStartViolation.Location = new System.Drawing.Point(772, 245);
            this.timePickerStartViolation.Name = "timePickerStartViolation";
            this.timePickerStartViolation.Size = new System.Drawing.Size(110, 29);
            this.timePickerStartViolation.TabIndex = 109;
            // 
            // timePickerEndViolation
            // 
            this.timePickerEndViolation.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePickerEndViolation.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.timePickerEndViolation.Location = new System.Drawing.Point(952, 245);
            this.timePickerEndViolation.Name = "timePickerEndViolation";
            this.timePickerEndViolation.Size = new System.Drawing.Size(110, 29);
            this.timePickerEndViolation.TabIndex = 110;
            // 
            // datePickerCreateAct
            // 
            this.datePickerCreateAct.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerCreateAct.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerCreateAct.Location = new System.Drawing.Point(219, 13);
            this.datePickerCreateAct.Name = "datePickerCreateAct";
            this.datePickerCreateAct.Size = new System.Drawing.Size(159, 29);
            this.datePickerCreateAct.TabIndex = 111;
            // 
            // datePickerTranscript
            // 
            this.datePickerTranscript.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerTranscript.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.datePickerTranscript.Location = new System.Drawing.Point(191, 63);
            this.datePickerTranscript.Name = "datePickerTranscript";
            this.datePickerTranscript.Size = new System.Drawing.Size(159, 29);
            this.datePickerTranscript.TabIndex = 112;
            // 
            // CreateActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 604);
            this.Controls.Add(this.datePickerTranscript);
            this.Controls.Add(this.datePickerCreateAct);
            this.Controls.Add(this.timePickerEndViolation);
            this.Controls.Add(this.timePickerStartViolation);
            this.Controls.Add(this.datePickerEndAnalysis);
            this.Controls.Add(this.timePickerStartAnalysis);
            this.Controls.Add(this.timePickerEndAnalysis);
            this.Controls.Add(this.datePickerStartAnalysis);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPositionChief);
            this.Controls.Add(this.cmbChief);
            this.Controls.Add(this.cmbMechanic);
            this.Controls.Add(this.lblPositionChief);
            this.Controls.Add(this.lblChief);
            this.Controls.Add(this.lblMechanic);
            this.Controls.Add(this.txtDescriptionFoul);
            this.Controls.Add(this.lblDescriptionFoul);
            this.Controls.Add(this.lblTimeFoul);
            this.Controls.Add(this.labeTimelAnalysis);
            this.Controls.Add(this.cmbCar6);
            this.Controls.Add(this.cmbCar5);
            this.Controls.Add(this.cmbCar4);
            this.Controls.Add(this.cmbCar3);
            this.Controls.Add(this.cmbCar2);
            this.Controls.Add(this.cmbCar1);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.cmbAmountCar);
            this.Controls.Add(this.lblAmountCar);
            this.Controls.Add(this.radioBtnCar);
            this.Controls.Add(this.radioBtnComposition);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.lblDateTranscript);
            this.Controls.Add(this.lblDateAct);
            this.Controls.Add(this.txtNumberAct);
            this.Controls.Add(this.lblNumberAct);
            this.Controls.Add(this.cmbDriver);
            this.Name = "CreateActForm";
            this.Load += new System.EventHandler(this.CreateActForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPositionChief;
        private System.Windows.Forms.ComboBox cmbChief;
        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label lblPositionChief;
        private System.Windows.Forms.Label lblChief;
        private System.Windows.Forms.Label lblMechanic;
        private System.Windows.Forms.TextBox txtDescriptionFoul;
        private System.Windows.Forms.Label lblDescriptionFoul;
        private System.Windows.Forms.Label lblTimeFoul;
        private System.Windows.Forms.Label labeTimelAnalysis;
        private System.Windows.Forms.ComboBox cmbCar6;
        private System.Windows.Forms.ComboBox cmbCar5;
        private System.Windows.Forms.ComboBox cmbCar4;
        private System.Windows.Forms.ComboBox cmbCar3;
        private System.Windows.Forms.ComboBox cmbCar2;
        private System.Windows.Forms.ComboBox cmbCar1;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbAmountCar;
        private System.Windows.Forms.Label lblAmountCar;
        private System.Windows.Forms.RadioButton radioBtnCar;
        private System.Windows.Forms.RadioButton radioBtnComposition;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblDateTranscript;
        private System.Windows.Forms.Label lblDateAct;
        private System.Windows.Forms.TextBox txtNumberAct;
        private System.Windows.Forms.Label lblNumberAct;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.DateTimePicker datePickerStartAnalysis;
        private System.Windows.Forms.DateTimePicker timePickerEndAnalysis;
        private System.Windows.Forms.DateTimePicker timePickerStartAnalysis;
        private System.Windows.Forms.DateTimePicker datePickerEndAnalysis;
        private System.Windows.Forms.DateTimePicker timePickerStartViolation;
        private System.Windows.Forms.DateTimePicker timePickerEndViolation;
        private System.Windows.Forms.DateTimePicker datePickerCreateAct;
        private System.Windows.Forms.DateTimePicker datePickerTranscript;
    }
}