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
    public partial class ChangeClassForm : Form
    {
        public ChangeClassForm()
        {
            InitializeComponent();
        }

        private void ChangeClassForm_Load(object sender, EventArgs e)
        {
            AddClass();
            radioBtnAdd.Checked = false;
            EnabledElement(false, false, true);
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddClass()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbClass.DataSource = ClassRepository.GetInstance(mainForm.SessionFactory).GetNumberClass();
            ClearElement();
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            lblClass.Enabled = flag1;
            cmbClass.Enabled = flag1;
            lblChange.Enabled = flag2;
            lblClassNew.Enabled = flag3;
            txtClassNew.Enabled = flag3;
            txtClassNew.Clear();
            cmbClass.Text = "";
        }

        private void ClearElement()
        {
            txtClassNew.Clear();
            cmbClass.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if (txtClassNew.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление класса машиниста запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var class1 = Convert.ToInt32(txtClassNew.Text);
                    var classList = ClassRepository.GetInstance(mainForm.SessionFactory)
                        .GetClassOf(class1).ToList();
                    if (classList.Count != 0)
                    {
                        MessageBox.Show("Класс машиниста «" + txtClassNew.Text + "» уже существует в базе данных!",
                            "Добавление класса машиниста запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить класс машиниста «" +
                        txtClassNew.Text + "»?", "Добавление класса машиниста", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var number = new Class()
                            {
                                NumberClass = Convert.ToInt32(txtClassNew.Text)
                            };
                            ClassRepository.GetInstance(mainForm.SessionFactory).Save(number);
                            MessageBox.Show("Добавление класса машиниста «" +
                            txtClassNew.Text + "» выполнено успешно", "Добавление класса машиниста",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if (cmbClass.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление класса машиниста запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var number2 = Convert.ToInt32(cmbClass.Text);
                    var classList = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                        .GetDriverByNameClass("Машинист", number2).ToList();
                    if (classList.Count != 0)
                    {
                        MessageBox.Show("Невозможно удалить класс машиниста «" + cmbClass.Text +
                            "», пока он используется другой таблицей!",
                            "Удаление класса машиниста запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить класс машиниста «" +
                        cmbClass.Text + "»?", "Удаление класса машиниста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var number = new Class()
                            {
                                Id = ClassRepository.GetInstance(mainForm.SessionFactory).GetIdByClass(Convert.ToInt32(cmbClass.Text)),
                                NumberClass = Convert.ToInt32(cmbClass.Text)
                            };
                            ClassRepository.GetInstance(mainForm.SessionFactory).Delete(number);
                            MessageBox.Show("Удаление класса машиниста «" +
                            cmbClass.Text + "» выполнено успешно", "Удаление класса машиниста",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((cmbClass.Text.Equals("")) || (txtClassNew.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение класса машиниста запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var class1 = Convert.ToInt32(txtClassNew.Text);
                    var classList = ClassRepository.GetInstance(mainForm.SessionFactory)
                        .GetClassOf(class1).ToList();
                    if (classList.Count != 0)
                    {
                        MessageBox.Show("Класс машиниста «" + txtClassNew.Text + "» уже существует в базе данных!",
                            "Изменение класса машиниста запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить класс машиниста «" +
                                cmbClass.Text + "» на класс машиниста «" + txtClassNew.Text + "»?", 
                                "Изменение класса машиниста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var number = new Class()
                            {
                                Id = ClassRepository.GetInstance(mainForm.SessionFactory).GetIdByClass(Convert.ToInt32(cmbClass.Text)),
                                NumberClass = Convert.ToInt32(txtClassNew.Text)
                            };
                            ClassRepository.GetInstance(mainForm.SessionFactory).Save(number);
                            MessageBox.Show("Изменение класса машиниста «" +
                            cmbClass.Text + "» на класс машиниста «" + txtClassNew.Text + "» выполнено успешно",
                            "Изменение класса машиниста", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddClass();
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
            "Закрытие окна редактирования класса машиниста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
