using System;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Repository.Implementation;
using System.Collections.Generic;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;

namespace RPDP.UI
{
    public partial class CreateActForm : Form
    {

        public CreateActForm()
        {
            InitializeComponent();
        }

        String composition;
        IList<String> car = new List<String>();
        IList<ComboBox> cmbCar = new List<ComboBox>();
        Excel._Application excel = new Excel.Application();
        DateTime startDate;
        String initialsDriver;
        String initialsInstructor;
        String initialsChief;
        String initialsMechanic;
        Int32 classDriver;

        private void CreateActForm_Load(Object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            radioBtnComposition.Checked = true;

            var dateTimePicker = new List<DateTimePicker>();
            dateTimePicker.Add(datePickerStartAnalysis);
            dateTimePicker.Add(datePickerEndAnalysis);
            dateTimePicker.Add(datePickerCreateAct);
            dateTimePicker.Add(timePickerStartAnalysis);
            dateTimePicker.Add(timePickerEndAnalysis);
            dateTimePicker.Add(timePickerStartViolation);
            dateTimePicker.Add(timePickerEndViolation);
            dateTimePicker.Add(datePickerTranscript);

            for (int i = 0; i < dateTimePicker.Count; i++)
            {
                dateTimePicker[i].Format = DateTimePickerFormat.Custom;
                dateTimePicker[i].ShowUpDown = true;
                if (dateTimePicker[i].Name.StartsWith("timePicker"))
                    dateTimePicker[i].CustomFormat = "HH:mm";
            }

            var comboBox = new List<ComboBox>();
            comboBox.Add(cmbDriver);
            comboBox.Add(cmbMechanic);
            comboBox.Add(cmbChief);
            comboBox.Add(cmbRoute);

            cmbCar.Add(cmbCar1);
            cmbCar.Add(cmbCar2);
            cmbCar.Add(cmbCar3);
            cmbCar.Add(cmbCar4);
            cmbCar.Add(cmbCar5);
            cmbCar.Add(cmbCar6);

            cmbRoute.DataSource = RouteRepository.GetInstance(mainForm.SessionFactory).GetNumberRoute().ToList();
            cmbRoute.SelectedIndex = -1;

            cmbAmountCar.DataSource = AmountCarRepository.GetInstance(mainForm.SessionFactory).GetAmountCar();
            cmbAmountCar.SelectedIndex = -1;

            cmbDriver.DataSource = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                .GetNameEmployeeByNamePosition("Машинист");
            cmbDriver.SelectedIndex = -1;
            txtInstructor.Clear();
            cmbMechanic.DataSource = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                .GetNameEmployeeByNamePosition("Электромеханик РПДП");
            cmbMechanic.SelectedIndex = -1;
            cmbChief.DataSource = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                .GetNameChiefByNamePosition("Машинист", "ТЧМ", "Электромеханик РПДП")
                .OrderBy(x => x.Surname + x.name + x.Patronymic).ToList();
            cmbChief.SelectedIndex = -1;
            txtPositionChief.Clear();
         
            for (int i = 0; i < cmbCar.Count; i++)
            {
                cmbCar[i].Enabled = false;
            }
        }

        public void CreateCollectionCar(String type, Int32 k)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            var carList = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetCarByTypeCar(type);
            for (int i = 0; i < carList.Count; i++)
            {
                cmbCar[k].Items.Add(carList[i]);
            }
        }

        public void AddCar(Int32 number, String typeHead, String typeInterval)
        {
            //var amountCarsString = cmbAmountCar.Text.Trim();
            //Int32 amountCars;
            //if (!Int32.TryParse(amountCarsString, out amountCars))
            //    return;

            //if (amountCars == number)
            //{
            //    CreateCollectionCar(typeHead, 0);
            //    if (amountCars > 1)
            //    {
            //        CreateCollectionCar(typeHead, number - 1);
            //        for (int i = 1; i < number - 1; i++)
            //        {
            //            CreateCollectionCar(typeInterval, i);
            //        }
            //    }
            //}
        }

        private void AddComposition()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;
            if (!cmbAmountCar.Text.Equals(""))
            {
                var amountCar = Convert.ToInt32(cmbAmountCar.Text);
                var carList = TrainRepository.GetInstance(mainForm.SessionFactory)
                    .GetHeadByAmountCars(amountCar);
                for (int i = 0; i < carList.Count; i++)
                {
                    cmbCar[0].Items.Add(carList[i]);
                }
            }
        }

        private void cmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;
            if (!cmbDriver.Text.Equals(""))
            {
                var nameDriver = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbDriver.Text);
                txtInstructor.Text = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetNameInstructorByNameDriver(nameDriver);
                startDate = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetStartDateByName(nameDriver);
                initialsDriver = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetInitialsByName(nameDriver);
                var nameInstructor = RPDP.RepositoryLibrary.Entity.Name.ToName(txtInstructor.Text);
                initialsInstructor = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                .GetInitialsByName(nameInstructor);
                classDriver = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetClassByName(nameDriver);
            }
        }

        private void cmbChief_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;
            if (!cmbChief.Text.Equals(""))
            {
                var nameChief = RepositoryLibrary.Entity.Name.ToName(cmbChief.Text);
                txtPositionChief.Text = PositionRepository.GetInstance(mainForm.SessionFactory)
                    .GetPositionByEmploeeName(nameChief);
                initialsChief = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetInitialsByName(nameChief);
            }
        }

        private void cmbMechanic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (!cmbMechanic.Text.Equals(""))
            {
                var nameMechanic = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbMechanic.Text);
                initialsMechanic = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetInitialsByName(nameMechanic);
            }
        }

        private void ClearItemsCombobox()
        {
            for (int i = 0; i < cmbCar.Count; i++)
            {
                cmbCar[i].Items.Clear();
            }
        }

        private void ClearTextCombobox()
        {
            for (int i = 0; i < cmbCar.Count; i++)
            {
                cmbCar[i].Text = "";
            }
        }

        private void cmbAmountCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (!cmbAmountCar.Text.Equals(""))
            {
                ClearItemsCombobox();
                ClearTextCombobox();
                EnabledCombobox();
                if (radioBtnComposition.Checked)
                {
                    var amountCar = Convert.ToInt32(cmbAmountCar.Text);
                    var carList = TrainRepository.GetInstance(mainForm.SessionFactory)
                        .GetHeadByAmountCars(amountCar);
                    for (int i = 0; i < carList.Count; i++)
                    {
                        cmbCar[0].Items.Add(carList[i]);
                    }
                }
                if (radioBtnCar.Checked)
                {
                    AddCar(1, "МРТ", "");
                    AddCar(4, "81-740.1", "81-741.1");
                    AddCar(5, "81-740.1", "81-741.1");
                    AddCar(6, "81-717", "81-714");
                }
            }
        }

        private void radioBtnComposition_CheckedChanged(object sender, EventArgs e)
        {
            ClearItemsCombobox();
            AddComposition();
        }

        private void radioBtnCar_CheckedChanged(object sender, EventArgs e)
        {
            ClearItemsCombobox();
            if (radioBtnComposition.Checked)
            {
                ClearTextCombobox();
            }
            AddCar(1, "МРТ", "");
            AddCar(4, "81-740.1", "81-741.1");
            AddCar(5, "81-740.1", "81-741.1");
            AddCar(6, "81-717", "81-714");
        }

        private void cmbCar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnComposition.Checked)
            {
                var car1 = cmbCar1.Text;
                var carList = CarRepository.GetInstance(mainForm.SessionFactory).GetCarsByHead(car1);
                for (int i = 1; i < carList.Count; i++)
                {
                    cmbCar[i].Text = carList[i];
                }
            }
        }

        private void EnabledCombobox()
        {
            for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
            {
                cmbCar[i].Enabled = true;
            }
            for (int i = cmbCar.Count - 1; i >= Convert.ToInt32(cmbAmountCar.Text); i--)
            {
                cmbCar[i].Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
                "Закрытие формы создания акта по нарушениям", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var word = new Word.Application();
                var doc = word.Documents.Add();
                var paragraphs = doc.Paragraphs;
                var paragraph = paragraphs[1];
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Range.Font.Size = 18;
                var table = doc.Tables.Add(paragraph.Range, 1, 5);
                table.Range.ParagraphFormat.SpaceAfter = 0;
                table.Cell(1, 1).Width = 160;
                table.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                table.Cell(1, 2).Width = 85;
                table.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table.Cell(1, 3).Width = 30;
                table.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table.Cell(1, 4).Width = 140;
                table.Cell(1, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table.Cell(1, 5).Width = 50;
                table.Cell(1, 1).Range.Text = "Акт РПДП №";
                table.Cell(1, 2).Range.Text = txtNumberAct.Text;
                table.Cell(1, 2).Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Cell(1, 3).Range.Text = "от";
                table.Cell(1, 4).Range.Text = datePickerCreateAct.Text;
                table.Cell(1, 4).Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                paragraph.Range.ParagraphFormat.SpaceAfter = 0;
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph.Range.InsertAfter("по случаю допущенного нарушения в электродепо \n «Фили»");
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                paragraph.Range.Font.Size = 12;

                if (!cmbCar[0].Text.Equals(""))
                {
                    composition = String.Format(cmbCar[0].Text);
                }
                for (int i = 1; i < cmbCar.Count; i++)
                {
                    if (!cmbCar[i].Text.Equals(""))
                    {
                        composition = composition + String.Format("-" + cmbCar[i].Text);
                    }
                }

                var assets = doc.Content.Paragraphs.Add();

                assets.Range.ListFormat.ApplyNumberDefault();
                var bulletItems = new string[] {
                 "Дата расшифровки: " + datePickerTranscript.Text,
                 "Маршрут №: " + cmbRoute.Text,
                 "Вагон №: " + composition,
                 "Машинист: " + initialsDriver,
                 "ТЧМ: " + initialsInstructor,
                 "Временной интервал, в котором производился анализ данных регистратора: " +
                 String.Format("{0} {1} - {2} {3}", datePickerStartAnalysis.Text,
                 timePickerStartAnalysis.Text, datePickerEndAnalysis.Text, timePickerEndAnalysis.Text),
                 (String.Format("Время начала и окончания нарушения: {0} - {1}",
                 timePickerStartViolation.Text, timePickerEndViolation.Text)),
                 "Краткое описание случая нарушения и показатели параметров движения поезда в привязке ко времени нарушения: " + txtDescriptionFoul.Text
            };

                for (int i = 0; i < bulletItems.Length; i++)
                {
                    var bulletItem = bulletItems[i];
                    if (i < bulletItems.Length)
                    {
                        assets.Range.ParagraphFormat.LeftIndent = 18;
                        if (i == bulletItems.Length - 1)
                        {
                            assets.Range.InsertBefore(bulletItem);
                        }
                        else
                        {
                            bulletItem = bulletItem + "\n";
                            assets.Range.InsertBefore(bulletItem);
                        }
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    paragraph.Range.InsertParagraphAfter();
                }

                paragraph.Range.ParagraphFormat.SpaceAfter = 6;
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                paragraph.Range.InsertAfter("Специалист по расшифровке:");
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.ParagraphFormat.SpaceAfter = 0;
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                paragraph.Range.InsertAfter(initialsMechanic);
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph.Borders[Word.WdBorderType.wdBorderTop].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                paragraph.Range.Font.Size = 8;
                paragraph.Range.InsertAfter("(роспись, Ф.И.О.)");
                paragraph.Range.ParagraphFormat.SpaceAfter = 6;
                paragraph.Range.InsertParagraphAfter();
                paragraph.Borders[Word.WdBorderType.wdBorderTop].LineStyle = Word.WdLineStyle.wdLineStyleNone;
                paragraph.TabStops.Add(doc.Application.CentimetersToPoints(17.5f),
                    Word.WdTabAlignment.wdAlignTabRight,
                    Word.WdTabLeader.wdTabLeaderHeavy);
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.Font.Size = 12;
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;

                paragraph.Range.InsertAfter("9.   Выводы:");
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.InsertAfter("\t");
                paragraph.TabStops.Add(doc.Application.CentimetersToPoints(17.5f),
                    Word.WdTabAlignment.wdAlignTabRight,
                    Word.WdTabLeader.wdTabLeaderLines);
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.InsertAfter("\t");
                paragraph.TabStops.Add(doc.Application.CentimetersToPoints(17.5f),
                    Word.WdTabAlignment.wdAlignTabRight,
                    Word.WdTabLeader.wdTabLeaderLines);
                paragraph.Range.ParagraphFormat.SpaceAfter = 15;
                paragraph.Range.InsertParagraphAfter();

                paragraph.Range.InsertAfter("Дата:\t");
                paragraph.TabStops.Add(doc.Application.CentimetersToPoints(6.5f),
                    Word.WdTabAlignment.wdAlignTabRight,
                    Word.WdTabLeader.wdTabLeaderLines);
                doc.Content.Paragraphs.Add();
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.InsertParagraphAfter();

                var table1 = doc.Tables.Add(paragraph.Range, 2, 4);
                table1.Cell(1, 1).Width = 240;
                table1.Cell(1, 2).Width = 90;
                table1.Cell(1, 3).Width = 20;
                table1.Cell(1, 4).Width = 130;
                table1.Cell(2, 1).Width = 240;
                table1.Cell(2, 2).Width = 90;
                table1.Cell(2, 3).Width = 20;
                table1.Cell(2, 4).Width = 130;
                table1.Range.ParagraphFormat.SpaceAfter = 0;
                table1.Cell(1, 1).Merge(table1.Cell(2, 1));
                table1.Cell(1, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                table1.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                table1.Cell(1, 1).Range.Text = txtPositionChief.Text;
                table1.Cell(1, 2).Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table1.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table1.Cell(2, 2).Range.Font.Size = 8;
                table1.Cell(2, 2).Range.Text = "подпись";
                table1.Cell(1, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table1.Cell(1, 4).Range.Text = initialsChief;
                table1.Cell(1, 4).Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table1.Cell(2, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table1.Cell(2, 4).Range.Font.Size = 8;
                table1.Cell(2, 4).Range.Text = "Ф.И.О.";

                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.InsertParagraphAfter();

                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph.Range.Font.Size = 10;
                paragraph.Range.InsertAfter("Электродепо «Фили» " + DateTime.Now.Year + " год.");
                word.Visible = true;
                doc.SaveAs(Application.StartupPath + @"\Акт РПДП № " + txtNumberAct.Text + ".docx");
                var path = Application.StartupPath + @"\Отчет по случаю допущенного нарушения в электродепо «Фили».xlsx";
                if (File.Exists(path))
                {
                    var workbooks = excel.Workbooks.Open(path);
                    var emptyRow = excel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row + 1;
                    Cells(emptyRow);
                    excel.Visible = true;
                    workbooks.SaveAs(path);
                    GC.GetTotalMemory(true);
                }
                else
                {
                    var workbooks = excel.Workbooks.Add(Missing.Value);
                    var worksheets = excel.ActiveSheet;

                    worksheets.Cells[1, 1] = "№ п/п";
                    worksheets.Cells[1, 2] = "Дата расшифровки";
                    worksheets.Cells[1, 3] = "№№ секций";
                    worksheets.Cells[1, 4] = "Результаты\nрасшифровки";
                    worksheets.Cells[1, 5] = "№ маршрута";
                    worksheets.Cells[1, 6] = "Дата нарушения";
                    worksheets.Cells[1, 7] = "Данные о работнике, допустившем нарушение";
                    worksheets.Cells[1, 8] = "Должность,\nФ.И.О.\nработника, проводившего расшифровку";
                    for (int i = 1; i <= 8; i++)
                    {
                        worksheets.Cells[2, i] = i;
                    }
                    Cells(3);
                    excel.Visible = true;
                    workbooks.SaveAs(path);
                    GC.GetTotalMemory(true);
                }
            }
        }
        void Cells(Int32 i)
        {
            var worksheets = excel.ActiveSheet;
            worksheets.Cells.Font.Size = 12;
            worksheets.Cells.Font.Name = "Times New Roman";
            worksheets.Cells.WrapText = true;
            worksheets.Cells.IndentLevel = 2;
            worksheets.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            worksheets.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            worksheets.Columns[1].EntireColumn.ColumnWidth = 5;
            worksheets.Columns[2].EntireColumn.ColumnWidth = 15;
            worksheets.Columns[3].EntireColumn.ColumnWidth = 8;
            worksheets.Columns[4].EntireColumn.ColumnWidth = 45;
            worksheets.Columns[5].EntireColumn.ColumnWidth = 10;
            worksheets.Columns[6].EntireColumn.ColumnWidth = 12;
            worksheets.Columns[7].EntireColumn.ColumnWidth = 20;
            worksheets.Columns[8].EntireColumn.ColumnWidth = 20;
            var number = excel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row - 1;
            worksheets.Cells[i, 1] = "'" + number + ".";
            worksheets.Cells[i, 2] = datePickerTranscript.Text + ".";

            if (((cmbAmountCar.Text.Equals("1")) && (!cmbCar[0].Text.Equals(""))) || 
                ((!cmbCar[0].Text.Equals("")) && (cmbCar[Convert.ToInt32(cmbAmountCar.Text) - 1].Text.Equals(""))))
            {
                worksheets.Cells[i, 3] = "'" + cmbCar1.Text + ".";
            }

            else if (!cmbCar[0].Text.Equals(""))
            {
                worksheets.Cells[i, 3] = "'" + cmbCar1.Text + "\n" + "'"  + cmbCar[Convert.ToInt32(cmbAmountCar.Text) - 1].Text + ".";
            }


            worksheets.Cells[i, 4] = txtDescriptionFoul.Text;
            worksheets.Cells[i, 5] = "'" + cmbRoute.Text + ".";
            Int32 experience;
            if (startDate.DayOfYear >= DateTime.Now.DayOfYear)
            {
                experience = DateTime.Now.Year - startDate.Year - 1;
            }
            else
            {
                experience = DateTime.Now.Year - startDate.Year;
            }
            String year;
            var exp = Convert.ToString(experience);
            if (exp.Equals("0"))
            {
                year = "до года";
            }
            else if (exp.EndsWith("1") && !(experience > 10) && !(experience < 15))
            {
                year = exp + " год";
            }
            else if ((exp.EndsWith("2") || exp.EndsWith("3") || exp.EndsWith("4")) 
                && (!(experience > 10) && !(experience < 15)))
            {
                year = exp + " года";
            }
            else
            {
                year = exp + " лет";
            }
            worksheets.Cells[i, 6] = datePickerStartAnalysis.Text + ".";

            if (!cmbDriver.Text.Equals(""))
            {
                worksheets.Cells[i, 7] = String.Format("Машинист\n{0}\nСтаж {1}.\nКласс {2}.\nТЧМ\n{3}",
                    initialsDriver, year, classDriver, initialsInstructor);
            }
            worksheets.Cells[i, 8] = "Электромеханик\nРПДП\n" + initialsMechanic;

            var emptyRow = excel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            var cells = worksheets.Range("A1", "H" + emptyRow);
            cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            var cellGH = worksheets.Range("G3", "H" + emptyRow);
            cellGH.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            var cellF = worksheets.Range("C3", "D" + emptyRow);
            cellF.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
        }
    }
}
