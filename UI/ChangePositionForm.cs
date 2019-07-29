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
    public partial class ChangePositionForm : Form
    {
        public ChangePositionForm()
        {
            InitializeComponent();
        }

        private void ChangePositionForm_Load(object sender, EventArgs e)
        {
            radioBtnAdd.Checked = true;
            AddPosition();
            EnabledElement(false, false, true);
        }

        private void AddPosition()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbPosition.DataSource = PositionRepository.GetInstance(mainForm.SessionFactory).GetNamePosition();
            ClearElement();
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            cmbPosition.Enabled = flag1;
            lblPosition.Enabled = flag1;
            lblChange.Enabled = flag2;
            txtPositionNew.Enabled = flag3;
            lblPositionNew.Enabled = flag3;
        }

        private void ClearElement()
        {
            txtPositionNew.Clear();
            cmbPosition.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if (txtPositionNew.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление должности запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var position1 = txtPositionNew.Text;
                    var positionList = PositionRepository.GetInstance(mainForm.SessionFactory)
                        .GetPositionOf(position1).ToList();
                    if (positionList.Count != 0)
                    {
                        MessageBox.Show("Должность «" + txtPositionNew.Text + "» уже существует в базе данных!",
                            "Добавление должности запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить должность «" +
                        txtPositionNew.Text + "»?", "Добавление должности", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var position = new Position
                            {
                                NamePosition = txtPositionNew.Text
                            };
                            PositionRepository.GetInstance(mainForm.SessionFactory).Save(position);
                            MessageBox.Show("Добавление должности «" +
                            txtPositionNew.Text + "» выполнено успешно", "Добавление должности",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if (cmbPosition.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление должности запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var position2 = cmbPosition.Text;
                    var positionList = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                        .GetEmployeeByPosition(position2);
                    if (positionList.Count != 0)
                    {
                        MessageBox.Show("Невозможно удалить должность «" + cmbPosition.Text + 
                            "», пока она используется другой таблицей!",
                            "Удаление должности запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить должность «" +
                        cmbPosition.Text + "»?", "Удаление должности", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var position = new Position
                            {
                                Id = PositionRepository.GetInstance(mainForm.SessionFactory).GetIdByPosition(cmbPosition.Text),
                                NamePosition = cmbPosition.Text
                            };
                            PositionRepository.GetInstance(mainForm.SessionFactory).Delete(position);
                            MessageBox.Show("Удаление должности «" +
                            cmbPosition.Text + "» выполнено успешно", "Удаление должности",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((cmbPosition.Text.Equals("")) || (txtPositionNew.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение должности запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    var position1 = txtPositionNew.Text;
                    var positionList = PositionRepository.GetInstance(mainForm.SessionFactory)
                        .GetPositionOf(position1).ToList();
                    if (positionList.Count != 0)
                    {
                        MessageBox.Show("Должность «" + txtPositionNew.Text + "» уже существует в базе данных!",
                            "Изменение должности запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить должность «" +
                                cmbPosition.Text + "» на должность «" + txtPositionNew.Text + "»?", "Изменение должости",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var position = new Position
                            {
                                Id = PositionRepository.GetInstance(mainForm.SessionFactory).GetIdByPosition(cmbPosition.Text),
                                NamePosition = txtPositionNew.Text
                            };
                            PositionRepository.GetInstance(mainForm.SessionFactory).Save(position);
                            MessageBox.Show("Изменение должности «" +
                            cmbPosition.Text + "» на должность «" + txtPositionNew.Text + "» выполнено успешно",
                            "Изменение должости", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddPosition();
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
            EnabledElement(true, true, false);
            ClearElement();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
            "Закрытие окна редактирования должности", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
