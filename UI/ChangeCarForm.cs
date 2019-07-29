using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Repository.Implementation;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.UI
{
    public partial class ChangeCarForm : Form
    {
        public ChangeCarForm()
        {
            InitializeComponent();
        }

        private void ChangeCarForm_Load(object sender, EventArgs e)
        {
            radioBtnAdd.Checked = true;
            AddNumberCar();
            EnabledElement(false, false, true);
            cmbNumberCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNumberRegistrarNew.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeCarNew.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void AddNumberCar()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbNumberCar.DataSource = CarRepository.GetInstance(mainForm.SessionFactory).GetNumberCar();
            var numberRegistrarList = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                .GetNumberRegistrarOfFree(Convert.ToChar("0"));
            numberRegistrarList.Add(txtNumberRegistrar.Text);
            cmbNumberRegistrarNew.DataSource = numberRegistrarList;
            cmbTypeCarNew.DataSource = TypeCarRepository.GetInstance(mainForm.SessionFactory).GetTypeCar();
            ClearElement();
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            cmbNumberCar.Enabled = flag1;
            lblNumberCar.Enabled = flag1;
            txtNumberRegistrar.Enabled = flag1;
            lblNumberRegistrar.Enabled = flag1;
            txtTypeCar.Enabled = flag1;
            lblTypeCar.Enabled = flag1;
            lblChange.Enabled = flag2;
            txtNumberCarNew.Enabled = flag3;
            lblNumberCarNew.Enabled = flag3;
            cmbNumberRegistrarNew.Enabled = flag3;
            lblNumberRegistrarNew.Enabled = flag3;
            cmbTypeCarNew.Enabled = flag3;
            lblTypeCarNew.Enabled = flag3;
        }

        private void ClearElement()
        {
            cmbNumberCar.SelectedIndex = -1;
            cmbNumberRegistrarNew.SelectedIndex = -1;
            cmbTypeCarNew.SelectedIndex = -1;
            txtNumberCarNew.Clear();
            txtNumberRegistrar.Clear();
            txtTypeCar.Clear();
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
                txtTypeCar.Text = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetTypeCarByNumberCar(numberCar);
                if (radioBtnChange.Checked)
                {
                    var numberRegistrarList = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                    .GetNumberRegistrarOfFree(Convert.ToChar("0"));
                    numberRegistrarList.Add(txtNumberRegistrar.Text);
                    cmbNumberRegistrarNew.DataSource = numberRegistrarList;
                    txtNumberCarNew.Text = cmbNumberCar.Text;
                    cmbNumberRegistrarNew.Text = txtNumberRegistrar.Text;
                    cmbTypeCarNew.Text = txtTypeCar.Text;
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
                if ((txtNumberCarNew.Text.Equals("")) || (cmbNumberRegistrarNew.Text.Equals(""))
                    || (cmbTypeCarNew.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var numberCar1 = txtNumberCarNew.Text;
                    var carList = CarRepository.GetInstance(mainForm.SessionFactory)
                        .GetNumberCarOf(numberCar1).ToList();
                    if (carList.Count != 0)
                    {
                        MessageBox.Show("Вагон «" + txtNumberCarNew.Text + "» уже существует в базе данных!",
                            "Добавление вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить вагон «" +
                        txtNumberCarNew.Text + "»?", "Добавление вагона", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeСar = new TypeCar
                            {
                                Id = TypeCarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByTypeCar(cmbTypeCarNew.Text),
                                Type = cmbTypeCarNew.Text
                            };
                            var typeRegistrar = new TypeRegistrar
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdTypeRegistrarByNumbeRegistrar(cmbNumberRegistrarNew.Text),
                                Type = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetTypeRegistraByNumberRegistrar(cmbNumberRegistrarNew.Text)
                            };
                            var numberRegistrar = new Registrar
                            {
                                Id = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByNumberRegistrar(cmbNumberRegistrarNew.Text),
                                NumberRegistrar = cmbNumberRegistrarNew.Text,
                                IdTypeRegistrar = typeRegistrar,
                                ManufactureDate = Convert.ToDateTime(RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetManufactureDateRegistrarByNumberRegistrar(cmbNumberRegistrarNew.Text)),
                                Busy = Convert.ToChar("1")
                            };
                            RegistrarRepository.GetInstance(mainForm.SessionFactory).Save(numberRegistrar);
                            var car = new Car
                            {
                                NumberCar = txtNumberCarNew.Text,
                                IdTypeCar = typeСar,
                                IdRegistrar = numberRegistrar,
                                Busy = Convert.ToChar("0")
                            };
                            CarRepository.GetInstance(mainForm.SessionFactory).Save(car);
                            MessageBox.Show("Добавление вагона «" +
                            txtNumberCarNew.Text + "» выполнено успешно", "Добавление вагона",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if ((cmbNumberCar.Text.Equals("")) || (txtNumberRegistrar.Text.Equals(""))
                    || (txtTypeCar.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var numberCar2 = cmbNumberCar.Text;
                    var carList = TrainRepository.GetInstance(mainForm.SessionFactory)
                        .GetCarByTrain(numberCar2);
                    if (carList.Count != 0)
                    {
                        MessageBox.Show("Невозможно удалить вагон «" + cmbNumberCar.Text +
                            "», пока он используется другой таблицей!",
                            "Удаление вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить вагон «" +
                        cmbNumberCar.Text + "»?", "Удаление вагона", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeСar = new TypeCar
                            {
                                Id = TypeCarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByTypeCar(txtTypeCar.Text),
                                Type = txtTypeCar.Text
                            };
                            var typeRegistrar = new TypeRegistrar
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdTypeRegistrarByNumbeRegistrar(txtNumberRegistrar.Text),
                                Type = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetTypeRegistraByNumberRegistrar(txtNumberRegistrar.Text)
                            };
                            var numberRegistrar = new Registrar
                            {
                                Id = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByNumberRegistrar(txtNumberRegistrar.Text),
                                NumberRegistrar = txtNumberRegistrar.Text,
                                IdTypeRegistrar = typeRegistrar,
                                ManufactureDate = Convert.ToDateTime(RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetManufactureDateRegistrarByNumberRegistrar(txtNumberRegistrar.Text)),
                                Busy = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetBusyByNumberRegistrar(txtNumberRegistrar.Text)

                            };
                            var car = new Car
                            {
                                Id = CarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByNumberCar(cmbNumberCar.Text),
                                NumberCar = cmbNumberCar.Text,
                                IdTypeCar = typeСar,
                                IdRegistrar = numberRegistrar,
                                Busy = CarRepository.GetInstance(mainForm.SessionFactory)
                                .GetBusyByNumberCar(cmbNumberCar.Text)
                            };
                            CarRepository.GetInstance(mainForm.SessionFactory).Delete(car);
                            MessageBox.Show("Удаление вагона «" +
                            cmbNumberCar.Text + "» выполнено успешно", "Удаление вагона",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnChange.Checked)
            {

                if ((txtNumberCarNew.Text.Equals("")) || (cmbNumberRegistrarNew.Text.Equals(""))
                    || (cmbTypeCarNew.Text.Equals("")) || (cmbNumberCar.Text.Equals(""))
                    || (txtNumberRegistrar.Text.Equals("")) || (txtTypeCar.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var numberCar1 = txtNumberCarNew.Text;
                    var carList = CarRepository.GetInstance(mainForm.SessionFactory)
                        .GetNumberCarOf(numberCar1).ToList();
                    if (carList.Count != 0)
                    {
                        MessageBox.Show("Вагон «" + txtNumberCarNew.Text + "» уже существует в базе данных!",
                            "Изменение вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите внести следующие изменения: номер вагона «" +
                        txtNumberCarNew.Text + "», тип вагона «" + cmbTypeCarNew.Text +
                        "», номер регистратора «" + cmbNumberRegistrarNew.Text + "»?", "Изменение вагона",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeСar = new TypeCar
                            {
                                Id = TypeCarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByTypeCar(cmbTypeCarNew.Text),
                                Type = cmbTypeCarNew.Text
                            };
                            var typeRegistrar = new TypeRegistrar
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdTypeRegistrarByNumbeRegistrar(cmbNumberRegistrarNew.Text),
                                Type = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetTypeRegistraByNumberRegistrar(cmbNumberRegistrarNew.Text)
                            };
                            var numberRegistrar = new Registrar
                            {
                                Id = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByNumberRegistrar(cmbNumberRegistrarNew.Text),
                                NumberRegistrar = cmbNumberRegistrarNew.Text,
                                IdTypeRegistrar = typeRegistrar,
                                ManufactureDate = Convert.ToDateTime(RegistrarRepository
                                .GetInstance(mainForm.SessionFactory)
                                .GetManufactureDateRegistrarByNumberRegistrar(cmbNumberRegistrarNew.Text)),
                                Busy = Convert.ToChar("1")
                            };
                            RegistrarRepository.GetInstance(mainForm.SessionFactory).Save(numberRegistrar);
                            if (!cmbNumberRegistrarNew.Text.Equals(txtNumberRegistrar.Text))
                            {
                                var typeRegistrar1 = new TypeRegistrar
                                {
                                    Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdTypeRegistrarByNumbeRegistrar(txtNumberRegistrar.Text),
                                    Type = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                    .GetTypeRegistraByNumberRegistrar(txtNumberRegistrar.Text)
                                };
                                var numberRegistrar1 = new Registrar
                                {
                                    Id = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdByNumberRegistrar(txtNumberRegistrar.Text),
                                    NumberRegistrar = txtNumberRegistrar.Text,
                                    IdTypeRegistrar = typeRegistrar1,
                                    ManufactureDate = Convert.ToDateTime(RegistrarRepository.GetInstance(mainForm.SessionFactory)
                                    .GetManufactureDateRegistrarByNumberRegistrar(txtNumberRegistrar.Text)),
                                    Busy = Convert.ToChar("0")
                                };
                                RegistrarRepository.GetInstance(mainForm.SessionFactory).Save(numberRegistrar1);
                            }
                            var car = new Car
                            {
                                Id = CarRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdByNumberCar(cmbNumberCar.Text),
                                NumberCar = txtNumberCarNew.Text,
                                IdTypeCar = typeСar,
                                IdRegistrar = numberRegistrar,
                                Busy = CarRepository.GetInstance(mainForm.SessionFactory)
                                    .GetBusyByNumberCar(cmbNumberCar.Text)
                            };
                            CarRepository.GetInstance(mainForm.SessionFactory).Save(car);
                            MessageBox.Show("Изменения: номер вагона «" +
                            txtNumberCarNew.Text + "», тип вагона «" + cmbTypeCarNew.Text +
                            "», номер регистратора «" + cmbNumberRegistrarNew.Text + "» выполнены успешно", "Изменение вагона",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddNumberCar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
            "Закрытие окна редактирования вагона", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
