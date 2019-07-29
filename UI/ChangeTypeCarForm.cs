using System;
using System.Linq;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Repository.Implementation;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.UI
{
    public partial class ChangeTypeCarForm : Form
    {
        public ChangeTypeCarForm()
        {
            InitializeComponent();
        }

        private void ChangeTypeCarForm_Load(object sender, EventArgs e)
        {
            AddTypeCar();
            radioBtnAdd.Checked = true;
            EnabledElement(false, false, true);
            cmbTypeCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddTypeCar()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbTypeCar.DataSource = TypeCarRepository.GetInstance(mainForm.SessionFactory).GetTypeCar();
            ClearElement();
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            cmbTypeCar.Enabled = flag1;
            lblTypeCar.Enabled = flag1;
            lblChange.Enabled = flag2;
            txtTypeCarNew.Enabled = flag3;
            lblTypeCarNew.Enabled = flag3;
            txtTypeCarNew.Clear(); 
            cmbTypeCar.Text = "";
        }

        private void ClearElement()
        {
            txtTypeCarNew.Clear();
            cmbTypeCar.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if (txtTypeCarNew.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление типа вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var typeCar1 = txtTypeCarNew.Text;
                    var carList = TypeCarRepository.GetInstance(mainForm.SessionFactory)
                        .GetTypeCarOf(typeCar1).ToList();
                    if (carList.Count != 0)
                    {
                        MessageBox.Show("Тип вагона «" + txtTypeCarNew.Text + "» уже существует в базе данных!",
                            "Добавление типа вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить тип вагона «" +
                        txtTypeCarNew.Text + "»?", "Добавление типа вагона", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeCar = new TypeCar
                            {
                                Type = txtTypeCarNew.Text
                            };
                            TypeCarRepository.GetInstance(mainForm.SessionFactory).Save(typeCar);
                            MessageBox.Show("Добавление типа вагона «" +
                            txtTypeCarNew.Text + "» выполнено успешно", "Добавление типа вагона",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if (cmbTypeCar.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление типа вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var typeCar2 = cmbTypeCar.Text;
                    var carList = CarRepository.GetInstance(mainForm.SessionFactory).GetCarByTypeCar(typeCar2);
                    if (carList.Count != 0)
                    {
                        MessageBox.Show("Невозможно удалить тип вагона «" + cmbTypeCar.Text +
                            "», пока он используется другой таблицей!",
                            "Удаление типа вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить тип вагона «" +
                        cmbTypeCar.Text + "»?", "Удаление типа вагона", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeCar = new TypeCar
                            {
                                Id = TypeCarRepository.GetInstance(mainForm.SessionFactory).GetIdByTypeCar(cmbTypeCar.Text),
                                Type = cmbTypeCar.Text
                            };
                            TypeCarRepository.GetInstance(mainForm.SessionFactory).Delete(typeCar);
                            MessageBox.Show("Удаление типа вагона «" +
                            cmbTypeCar.Text + "» выполнено успешно", "Удаление типа вагона",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((cmbTypeCar.Text.Equals("")) || (txtTypeCarNew.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение типа вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    var typeCar1 = txtTypeCarNew.Text;
                    var carList = TypeCarRepository.GetInstance(mainForm.SessionFactory)
                        .GetTypeCarOf(typeCar1).ToList();
                    if (carList.Count != 0)
                    {
                        MessageBox.Show("Тип вагона «" + txtTypeCarNew.Text + "» уже существует в базе данных!",
                            "Изменение типа вагона запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить тип вагона «" +
                                cmbTypeCar.Text + "» на тип вагона «" + txtTypeCarNew.Text + "»?", "Изменение типа вагона",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeCar = new TypeCar
                            {
                                Id = TypeCarRepository.GetInstance(mainForm.SessionFactory).GetIdByTypeCar(cmbTypeCar.Text),
                                Type = txtTypeCarNew.Text
                            };
                            TypeCarRepository.GetInstance(mainForm.SessionFactory).Save(typeCar);
                            MessageBox.Show("Изменение типа вагона «" +
                            cmbTypeCar.Text + "» на тип вагона «" + txtTypeCarNew.Text + "» выполнено успешно",
                            "Изменение типа вагона", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddTypeCar();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
            "Закрытие окна редактирования типа вагона", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
