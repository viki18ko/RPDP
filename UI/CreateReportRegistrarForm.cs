using System;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Repository.Implementation;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace RPDP.UI
{
    public partial class CreateReportRegistrarForm : Form
    {
        public CreateReportRegistrarForm()
        {
            InitializeComponent();
        }

        Excel._Application excel = new Excel.Application();

        private void CreateReportRegistrar_Load(Object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;
            
            datePickerRepair.Format = DateTimePickerFormat.Custom;
            datePickerRepair.CustomFormat = "dd.MM.yyyy";
            datePickerRepair.ShowUpDown = true;
            datePickerManufacture.Format = DateTimePickerFormat.Custom;
            datePickerManufacture.CustomFormat = "dd.MM.yyyy";
            datePickerManufacture.ShowUpDown = true;
            
            cmbNumberCar.DataSource = CarRepository.GetInstance(mainForm.SessionFactory).GetNumberCar();
            cmbNumberCar.SelectedIndex = -1;
            txtNumberRegistrar.Clear();
            txtTypeRegistrar.Clear();
            datePickerManufacture.Text = "";

        }

        private void cmbNumberCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;
            if (!cmbNumberCar.Text.Equals(""))
            {
                var numberCar = cmbNumberCar.Text;
                txtNumberRegistrar.Text = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetNumberRegistrarByNumberCar(numberCar);
                txtTypeRegistrar.Text = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetTypeRegistrarByNumberCar(numberCar);
                datePickerManufacture.Text = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetManufactureDateByNumberCar(numberCar).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
                "Закрытие формы отчета по регистраторам", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var path = Application.StartupPath + @"\Отчет по регистраторам.xlsx";
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

                    worksheets.Cells[1, 1] = "Номер регистратора";
                    worksheets.Cells[1, 2] = "Тип регистратора";
                    worksheets.Cells[1, 3] = "Дата изготовления";
                    worksheets.Cells[1, 4] = "Неисправности";
                    worksheets.Cells[1, 5] = "Дата ремонта";
                    worksheets.Cells[1, 6] = "Примечание";
                    worksheets.Cells[1, 7] = "Установлен на вагоне";
                    Cells(2);
                    excel.Visible = true;
                    workbooks.SaveAs(path);
                    GC.GetTotalMemory(true);
                }
            }
        }

        void Cells(Int32 i)
        {
            var worksheets = excel.ActiveSheet;
            worksheets.Cells.Font.Size = 14;
            worksheets.Cells.Font.Name = "Times New Roman";
            worksheets.Cells.WrapText = true;
            worksheets.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            worksheets.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            worksheets.Columns[1].EntireColumn.ColumnWidth = 18;
            worksheets.Columns[2].EntireColumn.ColumnWidth = 20;
            worksheets.Columns[3].EntireColumn.ColumnWidth = 18;
            worksheets.Columns[4].EntireColumn.ColumnWidth = 30;
            worksheets.Columns[5].EntireColumn.ColumnWidth = 15;
            worksheets.Columns[6].EntireColumn.ColumnWidth = 30;
            worksheets.Columns[7].EntireColumn.ColumnWidth = 20;

            worksheets.Cells[i, 1] = "'" + txtNumberRegistrar.Text;
            worksheets.Cells[i, 2] = txtTypeRegistrar.Text;
            worksheets.Cells[i, 3] = datePickerManufacture.Text;
            worksheets.Cells[i, 4] = txtDefect.Text;
            worksheets.Cells[i, 5] = datePickerRepair.Text;
            worksheets.Cells[i, 6] = txtRemark.Text;
            worksheets.Cells[i, 7] = "'" + cmbNumberCar.Text;

            var emptyRow = excel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            var cells = worksheets.Range("A1", "G" + emptyRow);
            cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            var cellD = worksheets.Range("D2", "D" + emptyRow);
            cellD.HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify;
            var cellF = worksheets.Range("F2", "F" + emptyRow);
            cellF.HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify;
        }
    }
}
