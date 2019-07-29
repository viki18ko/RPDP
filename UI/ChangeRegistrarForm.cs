using System;
using System.Linq;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Entity;
using RPDP.RepositoryLibrary.Repository.Implementation;

namespace RPDP.UI
{
    public partial class ChangeRegistrarForm : Form
    {
        public ChangeRegistrarForm()
        {
            InitializeComponent();
        }

        private void ChangeRegistrarForm_Load(object sender, EventArgs e)
        {
            datePickerManufactureDate.Format = DateTimePickerFormat.Custom;
            datePickerManufactureDate.CustomFormat = "dd.MM.yyyy";
            datePickerManufactureDate.ShowUpDown = true;
            datePickerManufactureDateNew.Format = DateTimePickerFormat.Custom;
            datePickerManufactureDateNew.CustomFormat = "dd.MM.yyyy";
            datePickerManufactureDateNew.ShowUpDown = true;
            radioBtnAdd.Checked = true;
            AddRegistrar();
            EnabledElement(false, false, true);
            cmbNumberRegistrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeRegistrarNew.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            cmbNumberRegistrar.Enabled = flag1;
            lblNumberRegistrar.Enabled = flag1;
            txtTypeRegistrar.Enabled = flag1;
            lblTypeRegistrar.Enabled = flag1;
            datePickerManufactureDate.Enabled = flag1;
            lblManufactureDate.Enabled = flag1;
            lblChange.Enabled = flag2;
            txtNumberRegistrarNew.Enabled = flag3;
            lblNumberRegistrarNew.Enabled = flag3;
            cmbTypeRegistrarNew.Enabled = flag3;
            lblTypeRegistrarNew.Enabled = flag3;
            datePickerManufactureDateNew.Enabled = flag3;
            lblManufactureDateNew.Enabled = flag3;
        }

        private void AddRegistrar()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbNumberRegistrar.DataSource = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                .GetNumberRegistrar();
            cmbTypeRegistrarNew.DataSource = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                .GetTypeRegistrar();
            ClearElement();
        }

        private void ClearElement()
        {
            txtNumberRegistrarNew.Clear();
            txtTypeRegistrar.Clear();
            cmbNumberRegistrar.SelectedIndex = -1;
            cmbTypeRegistrarNew.SelectedIndex = -1;
            datePickerManufactureDate.Text = "";
            datePickerManufactureDateNew.Text = "";
        }

        private void cmbNumberRegistrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;
            if (!cmbNumberRegistrar.Text.Equals(""))
            {
                var numberRegistrar = cmbNumberRegistrar.Text;
                txtTypeRegistrar.Text = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                    .GetTypeRegistrarByNumberRegistrar(numberRegistrar);
                datePickerManufactureDate.Text = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                    .GetManufactureDateRegistrarByNumberRegistrar(numberRegistrar);
                if (radioBtnChange.Checked)
                {
                    txtNumberRegistrarNew.Text = cmbNumberRegistrar.Text;
                    cmbTypeRegistrarNew.Text = txtTypeRegistrar.Text;
                    datePickerManufactureDateNew.Text = datePickerManufactureDate.Text;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if ((txtNumberRegistrarNew.Text.Equals("")) || (cmbTypeRegistrarNew.Text.Equals("")) 
                    || (datePickerManufactureDateNew.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var numberRegistrar1 = txtNumberRegistrarNew.Text;
                    var registrarList = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                        .GetNumberRegistrarOf(numberRegistrar1).ToList();
                    if (registrarList.Count != 0)
                    {
                        MessageBox.Show("Регистратор «" + txtNumberRegistrarNew.Text + "» уже существует в базе данных!",
                            "Добавление регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить регистратор «" +
                        txtNumberRegistrarNew.Text + "»?", "Добавление регистратора", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeRegistrar = new TypeRegistrar
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByTypeRegistrar(cmbTypeRegistrarNew.Text),
                                Type = cmbTypeRegistrarNew.Text
                            };
                            var registrar = new Registrar
                            {
                                NumberRegistrar = txtNumberRegistrarNew.Text,
                                IdTypeRegistrar = typeRegistrar,
                                ManufactureDate = Convert.ToDateTime(datePickerManufactureDateNew.Text),
                                Busy = Convert.ToChar("0")
                            };
                            RegistrarRepository.GetInstance(mainForm.SessionFactory).Save(registrar);
                            MessageBox.Show("Добавление регистратора «" +
                            txtNumberRegistrarNew.Text + "» выполнено успешно", "Добавление регистратора",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if ((cmbNumberRegistrar.Text.Equals("")) || (txtTypeRegistrar.Text.Equals(""))
                    || (datePickerManufactureDate.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var numberRegistrar2 = cmbNumberRegistrar.Text;
                    var carList = CarRepository.GetInstance(mainForm.SessionFactory)
                        .GetNumberCarByNumberRegistar(numberRegistrar2);
                    if (carList.Count != 0)
                    {
                        MessageBox.Show("Невозможно удалить регистратор «" + cmbNumberRegistrar.Text + "», пока он используется другой таблицей!",
                            "Удаление запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить регистратор «" +
                        cmbNumberRegistrar.Text + "»?", "Удаление регистратора", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeRegistrar = new TypeRegistrar
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByTypeRegistrar(txtTypeRegistrar.Text),
                                Type = txtTypeRegistrar.Text
                            };
                            var registrar = new Registrar
                            {
                                Id = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByNumberRegistrar(cmbNumberRegistrar.Text),
                                NumberRegistrar = cmbNumberRegistrar.Text,
                                IdTypeRegistrar = typeRegistrar,
                                ManufactureDate = Convert.ToDateTime(datePickerManufactureDate.Text),
                                Busy = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetBusyByNumberRegistrar(cmbNumberRegistrar.Text)
                            };
                            RegistrarRepository.GetInstance(mainForm.SessionFactory).Delete(registrar);
                            MessageBox.Show("Удаление регистратора «" +
                            cmbNumberRegistrar.Text + "» выполнено успешно", "Удаление регистратора",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((txtNumberRegistrarNew.Text.Equals("")) || (cmbTypeRegistrarNew.Text.Equals(""))
                    || (datePickerManufactureDateNew.Text.Equals("")) || (cmbNumberRegistrar.Text.Equals(""))
                    || (txtTypeRegistrar.Text.Equals("")) || (datePickerManufactureDate.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var numberRegistrar1 = txtNumberRegistrarNew.Text;
                    var registrarList = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                        .GetNumberRegistrarOf(numberRegistrar1).ToList();
                    if (registrarList.Count != 0)
                    {
                        MessageBox.Show("Регистратор «" + txtNumberRegistrarNew.Text + "» уже существует в базе данных!",
                            "Изменение регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите внести следующие изменения: номер регистратора «" +
                            txtNumberRegistrarNew.Text + "», тип регистратора «" + cmbTypeRegistrarNew.Text +
                            "», дата изготовления «" + datePickerManufactureDateNew.Text + "»?", "Изменение регистратора",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeRegistrar = new TypeRegistrar()
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByTypeRegistrar(cmbTypeRegistrarNew.Text),
                                Type = cmbTypeRegistrarNew.Text
                            };
                            var registrar = new Registrar
                            {
                                Id = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByNumberRegistrar(cmbNumberRegistrar.Text),
                                NumberRegistrar = txtNumberRegistrarNew.Text,
                                IdTypeRegistrar = typeRegistrar,
                                ManufactureDate = Convert.ToDateTime(datePickerManufactureDateNew.Text),
                                Busy = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetBusyByNumberRegistrar(cmbNumberRegistrar.Text)
                            };
                            RegistrarRepository.GetInstance(mainForm.SessionFactory).Save(registrar);
                            MessageBox.Show("Изменения: номер регистратора «" + txtNumberRegistrarNew.Text +
                                "», тип регистратора «" + cmbTypeRegistrarNew.Text + "», дата изготовления «"
                                + datePickerManufactureDateNew.Text + "» выполнены успешно", "Изменение регистратора",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddRegistrar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
            "Закрытие окна редактирования регистратора", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            EnabledElement(false, false, true);
            ClearElement();
        }

        private void radioBtnChange_CheckedChanged(object sender, EventArgs e)
        {
            EnabledElement(true, true, true);
            ClearElement();
        }

        private void radioBtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            EnabledElement(true, false, false);
            ClearElement();
        }
    }
}
