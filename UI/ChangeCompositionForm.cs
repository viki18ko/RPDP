using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Repository.Implementation;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.UI
{
    public partial class ChangeCompositionForm : Form
    {
        public ChangeCompositionForm()
        {
            InitializeComponent();
        }

        String compositionAdd;
        String compositionDelete;
        Train train;
        IList<ComboBox> cmbCar = new List<ComboBox>();
        IList<ComboBox> cmbCarNew = new List<ComboBox>();

        private void ChangeCompositionForm_Load(object sender, EventArgs e)
        {
            radioBtnAdd.Checked = true;
            AddAmountCar();
            cmbCar.Add(cmbCar1);
            cmbCar.Add(cmbCar2);
            cmbCar.Add(cmbCar3);
            cmbCar.Add(cmbCar4);
            cmbCar.Add(cmbCar5);
            cmbCar.Add(cmbCar6);
            cmbCarNew.Add(cmbCar1New);
            cmbCarNew.Add(cmbCar2New);
            cmbCarNew.Add(cmbCar3New);
            cmbCarNew.Add(cmbCar4New);
            cmbCarNew.Add(cmbCar5New);
            cmbCarNew.Add(cmbCar6New);
            for (int i = 0; i < cmbCar.Count; i++)
            {
                cmbCar[i].Enabled = false;
                cmbCarNew[i].Enabled = false;
            }
            cmbAmountCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void AddAmountCar()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            var amountCarList = AmountCarRepository.GetInstance(mainForm.SessionFactory).GetAmountCar();
            for (int i = 0; i < amountCarList.Count; i++)
            {
                cmbAmountCar.Items.Add(amountCarList[i]);
            }
        }

        private void ClearText()
        {
            for (int i = 0; i < cmbCar.Count; i++)
            {
                cmbCar[i].Text = "";
                cmbCarNew[i].Text = "";
            }
        }

        private void ClearItems()
        {
            for (int i = 0; i < cmbCar.Count; i++)
            {
                cmbCar[i].Items.Clear();
                cmbCarNew[i].Items.Clear();
            }
        }

        private void EnabledCmbCar(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            lblCar.Enabled = flag1;
            if (!cmbAmountCar.Text.Equals(""))
            {
                for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
                {
                    cmbCar[i].Enabled = flag2;
                }
                for (int i = cmbCar.Count - 1; i >= Convert.ToInt32(cmbAmountCar.Text); i--)
                {
                    cmbCar[i].Enabled = flag3;
                }
            }
        }

        private void EnabledCmbCarNew(Boolean flag1, Boolean flag2, Boolean flag3, Boolean flag4)
        {
            lblCarNew.Enabled = flag1;
            lblChange.Enabled = flag2;
            if (!cmbAmountCar.Text.Equals(""))
            {
                for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
                {
                    cmbCarNew[i].Enabled = flag3;
                }
                for (int i = cmbCarNew.Count - 1; i >= Convert.ToInt32(cmbAmountCar.Text); i--)
                {
                    cmbCarNew[i].Enabled = flag4;
                }
            }
        }

        public void CreateCollectionCar(String type, Int32 k)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            var carList = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetCarByTypeCarAndBusy(type, Convert.ToChar("0"));
            for (int i = 0; i < carList.Count; i++)
            {
                cmbCarNew[k].Items.Add(carList[i]);
            }
        }

        public void AddCar(Int32 number, String typeHead, String typeInterval)
        {
            var amountCarsString = cmbAmountCar.Text.Trim();
            Int32 amountCars;
            if (!Int32.TryParse(amountCarsString, out amountCars))
                return;

            if (amountCars == number)
            {
                CreateCollectionCar(typeHead, 0);
                if (amountCars > 1)
                {
                    CreateCollectionCar(typeHead, number - 1);
                    for (int i = 1; i < number - 1; i++)
                    {
                        CreateCollectionCar(typeInterval, i);
                    }
                }
            }
        }

        private void AddCars()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            var amountCar = Convert.ToInt32(cmbAmountCar.Text);
            var carList = TrainRepository.GetInstance(mainForm.SessionFactory)
                .GetHeadByAmountCars(amountCar);
            for (int i = 0; i < carList.Count; i++)
            {
                cmbCar[0].Items.Add(carList[i]);
            }

            AddCar(1, "МРТ", "");
            AddCar(4, "81-740.1", "81-741.1");
            AddCar(5, "81-740.1", "81-741.1");
            AddCar(6, "81-717", "81-714");
        }

        private void cmbAmountCar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (radioBtnAdd.Checked)
            {
                EnabledCmbCarNew(true, false, true, false);
            }
            if (radioBtnDelete.Checked)
            {
                EnabledCmbCar(true, true, false);
            }
            if (radioBtnChange.Checked)
            {
                EnabledCmbCarNew(true, false, true, false);
                EnabledCmbCar(true, true, false);
            }
            AddCars();
        }

        public void AddCarToTrain(Train train, params Car[] cars)
        {
            foreach (var car in cars)
            {
                train.AddCar(car);
            }
        }

        private void cmbCar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (!cmbCar1.Text.Equals(""))
            {
                var car1 = cmbCar1.Text;
                var carList = CarRepository.GetInstance(mainForm.SessionFactory).GetCarsByHead(car1);
                for (int i = 1; i < carList.Count; i++)
                {
                    cmbCar[i].Text = carList[i];
                }
            }
            if (radioBtnChange.Checked)
            {
                for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
                {
                    cmbCarNew[i].Text = cmbCar[i].Text;
                }
            }
        }

        private void AddToDB()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            var amountCar = new AmountCar
            {
                Id = AmountCarRepository.GetInstance(mainForm.SessionFactory)
                               .GetIdByAmountCar(Convert.ToInt32(cmbAmountCar.Text)),
                Number = Convert.ToInt32(cmbAmountCar.Text)
            };
            train = new Train
            {
                IdAmountCar = amountCar
            };
            var carList = new List<Car>();
            for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
            {
                var typeСar = new TypeCar
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetIdTypeCarByNumberCar(cmbCarNew[i].Text),
                    Type = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetTypeCarByNumberCar(cmbCarNew[i].Text)
                };
                var typeRegistrar = new TypeRegistrar
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetIdTypeRegistrarByNumberCar(cmbCarNew[i].Text),
                    Type = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetTypeRegistrarByNumberCar(cmbCarNew[i].Text)
                };
                var numberRegistrar = new Registrar
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetIdRegistrarByNumberCar(cmbCarNew[i].Text),
                    NumberRegistrar = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetNumberRegistrarByNumberCar(cmbCarNew[i].Text),
                    IdTypeRegistrar = typeRegistrar,
                    ManufactureDate = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetManufactureDateByNumberCar(cmbCarNew[i].Text),
                    Busy = Convert.ToChar("1")
                };
                var car = new Car
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory).GetIdByNumberCar(cmbCarNew[i].Text),
                    NumberCar = cmbCarNew[i].Text,
                    IdTypeCar = typeСar,
                    IdRegistrar = numberRegistrar,
                    Busy = Convert.ToChar("1")
                };
                AddCarToTrain(train, car);
            }
            TrainRepository.GetInstance(mainForm.SessionFactory).Save(train);
        }

        private void DeleteToDB()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            var carList = new List<Car>();
            var carList1 = new List<Car>();
            for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
            {
                var typeСar = new TypeCar
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetIdTypeCarByNumberCar(cmbCar[i].Text),
                    Type = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetTypeCarByNumberCar(cmbCar[i].Text)
                };
                var typeRegistrar = new TypeRegistrar
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetIdTypeRegistrarByNumberCar(cmbCar[i].Text),
                    Type = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetTypeRegistrarByNumberCar(cmbCar[i].Text)
                };
                var numberRegistrar = new Registrar
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetIdRegistrarByNumberCar(cmbCar[i].Text),
                    NumberRegistrar = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetNumberRegistrarByNumberCar(cmbCar[i].Text),
                    IdTypeRegistrar = typeRegistrar,
                    ManufactureDate = CarRepository.GetInstance(mainForm.SessionFactory)
                    .GetManufactureDateByNumberCar(cmbCar[i].Text),
                    Busy = Convert.ToChar("1")
                };
                var car = new Car
                {
                    Id = CarRepository.GetInstance(mainForm.SessionFactory).GetIdByNumberCar(cmbCar[i].Text),
                    NumberCar = cmbCar[i].Text,
                    IdTypeCar = typeСar,
                    IdRegistrar = numberRegistrar,
                    Busy = Convert.ToChar("0")
                };
                var car1 = new Car
                {
                    NumberCar = cmbCar[i].Text,
                    IdTypeCar = typeСar,
                    IdRegistrar = numberRegistrar,
                    Busy = Convert.ToChar("0")
                };
                carList.Add(car);
                carList1.Add(car1);
            }
            var amountCar = new AmountCar
            {
                Id = AmountCarRepository.GetInstance(mainForm.SessionFactory)
                .GetIdByAmountCar(Convert.ToInt32(cmbAmountCar.Text)),
                Number = Convert.ToInt32(cmbAmountCar.Text)
            };
            train = new Train
            {
                Id = TrainRepository.GetInstance(mainForm.SessionFactory)
                .GetFirstIdTrainByAmountCar(Convert.ToInt32(cmbAmountCar.Text)),
                IdAmountCar = amountCar,
                Cars = carList
            };
            TrainRepository.GetInstance(mainForm.SessionFactory).Delete(train);
            for (int i = 0; i < carList.Count; i++)
            {
                CarRepository.GetInstance(mainForm.SessionFactory).Save(carList1[i]);
            }
        }

        private Int32 GetEnabledCmb()
        {
            var k = 0;
            for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
            {
                if (!cmbCar[i].Text.Equals(""))
                {
                    k++;
                }
            }
            return k;
        }

        private Int32 GetEnabledCmbNew()
        {
            var k = 0;
            for (int i = 0; i < Convert.ToInt32(cmbAmountCar.Text); i++)
            {
                if (!cmbCarNew[i].Text.Equals(""))
                {
                    k++;
                }
            }
            return k;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var amountCarsString = cmbAmountCar.Text.Trim();
            Int32 amountCars;
            if (!Int32.TryParse(amountCarsString, out amountCars))
                return;

            Int32 number = GetEnabledCmb();
            Int32 numberNew = GetEnabledCmbNew();
            if (radioBtnAdd.Checked)
            {
                if (amountCars != numberNew)
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление состава запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var composition = compAdd();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить состав «" + composition + "»?",
                    "Добавление состава", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        AddToDB();
                        MessageBox.Show("Добавление состава «" + composition + "» выполнено успешно",
                            "Добавление состава", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {

                if (Convert.ToInt32(cmbAmountCar.Text) != number)
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление состава запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var composition = compDelete();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить состав «" + composition + "»?",
                    "Удаление состава", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        DeleteToDB();
                        MessageBox.Show("Удаление состава «" + composition + "» выполнено успешно",
                        "Удаление состава", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((Convert.ToInt32(cmbAmountCar.Text) != number)
                    || (Convert.ToInt32(cmbAmountCar.Text) != numberNew))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение состава запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var composition1 = compAdd();
                    var composition2 = compDelete();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить состав «" +
                            composition2 + "» на состав «" + composition1 + "»?", "Изменение состава",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DeleteToDB();
                        AddToDB();
                        MessageBox.Show("Изменение состава «" + composition2 +
                             "» на состав «" + composition1 + "» выполнено успешно",
                             "Изменение состава", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            ClearItems();
            ClearText();
            AddCars();
        }


        private String compAdd()
        {
            if (!cmbCarNew[0].Text.Equals(""))
            {
                compositionAdd = String.Format(cmbCarNew[0].Text);
            }
            for (int i = 1; i < cmbCarNew.Count; i++)
            {
                if (!cmbCarNew[i].Text.Equals(""))
                {
                    compositionAdd = compositionAdd + String.Format("-" + cmbCarNew[i].Text);
                }
            }
            return compositionAdd;
        }

        private String compDelete()
        {
            if (!cmbCar[0].Text.Equals(""))
            {
                compositionDelete = String.Format(cmbCar[0].Text);
            }
            for (int i = 1; i < cmbCarNew.Count; i++)
            {
                if (!cmbCar[i].Text.Equals(""))
                {
                    compositionDelete = compositionDelete + String.Format("-" + cmbCar[i].Text);
                }
            }
            return compositionDelete;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
            "Закрытие окна редактирования состава", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            EnabledCmbCarNew(true, false, true, false);
            EnabledCmbCar(false, false, false);
            ClearText();
        }

        private void radioBtnChange_CheckedChanged(object sender, EventArgs e)
        {
            EnabledCmbCarNew(true, true, true, false);
            EnabledCmbCar(true, true, false);
            ClearText();
        }

        private void radioBtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            EnabledCmbCarNew(false, false, false, false);
            EnabledCmbCar(true, true, false);
            ClearText();
        }
    }
}
