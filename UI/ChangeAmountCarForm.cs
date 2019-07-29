using System;
using System.Linq;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Entity;
using RPDP.RepositoryLibrary.Repository.Implementation;

namespace RPDP.UI
{
    public partial class ChangeAmountCarForm : Form
    {
        public ChangeAmountCarForm()
        {
            InitializeComponent();
        }

        private void ChangeAmountCarForm_Load(object sender, EventArgs e)
        {
            radioBtnAdd.Checked = true;
            AddAmountCar();
            cmbAmountCar.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void AddAmountCar()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbAmountCar.DataSource = AmountCarRepository.GetInstance(mainForm.SessionFactory).GetAmountCar();
            cmbAmountCar.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if (cmbAmountCar.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление количества вагонов в составе запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var amountCar1 = Convert.ToInt32(cmbAmountCar.Text);
                    var amountCarList = AmountCarRepository.GetInstance(mainForm.SessionFactory)
                        .GetAmountCarOf(amountCar1).ToList();
                    if (amountCarList.Count != 0)
                    {
                        MessageBox.Show("Количество вагонов в составе «" + cmbAmountCar.Text + "» уже существует в базе данных!",
                            "Добавление количества вагонов в составе запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить количество вагонов в составе «" +
                        cmbAmountCar.Text + "»?", "Добавление количества вагонов в составе", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var amountCar = new AmountCar()
                            {
                                Number = Convert.ToInt32(cmbAmountCar.Text)
                            };
                            AmountCarRepository.GetInstance(mainForm.SessionFactory).Save(amountCar);
                            MessageBox.Show("Добавление количества вагонов в составе «" +
                            cmbAmountCar.Text + "» выполнено успешно", "Добавление количества вагонов в составе",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if (cmbAmountCar.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление количества вагонов в составе запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var amountCar2 = Convert.ToInt32(cmbAmountCar.Text);
                    var amountCarList = TrainRepository.GetInstance(mainForm.SessionFactory)
                        .GetIdTrainByAmountCar(amountCar2);
                    if (amountCarList.Count != 0)
                    {
                        MessageBox.Show("Невозможно удалить количество вагонов в составе «" + cmbAmountCar.Text + 
                            "», пока оно используется другой таблицей!",
                            "Удаление запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить количество вагонов в составе «" +
                        cmbAmountCar.Text + "»?", "Удаление количества вагонов в составе", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var number = new AmountCar()
                            {
                                Id = AmountCarRepository.GetInstance(mainForm.SessionFactory).GetIdByAmountCar(Convert.ToInt32(cmbAmountCar.Text)),
                                Number = Convert.ToInt32(cmbAmountCar.Text)
                            };
                            AmountCarRepository.GetInstance(mainForm.SessionFactory).Delete(number);
                            MessageBox.Show("Удаление количества вагонов в составе «" +
                            cmbAmountCar.Text + "» выполнено успешно", "Удаление количества вагонов в составе",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            cmbAmountCar.SelectedIndex = -1;
            AddAmountCar();
        }

        private void radioBtnAdd_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbAmountCar.SelectedIndex = -1;
            cmbAmountCar.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void radioBtnDelete_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbAmountCar.SelectedIndex = -1;
            cmbAmountCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
            "Закрытие окна редактирования количества вагонов в составе", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
