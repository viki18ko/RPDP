using System;
using System.Linq;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Repository.Implementation;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.UI
{
    public partial class ChangeTypeRegistrarForm : Form
    {
        public ChangeTypeRegistrarForm()
        {
            InitializeComponent();
        }

        private void ChangeTypeRegistrarForm_Load(object sender, EventArgs e)
        {
            radioBtnAdd.Checked = true;
            EnabledElement(false, false, true);
            AddTypeRegistrar();
            cmbTypeRegistrar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddTypeRegistrar()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbTypeRegistrar.DataSource = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory).GetTypeRegistrar();
            ClearElement();
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            lblTypeRegistrar.Enabled = flag1;
            cmbTypeRegistrar.Enabled = flag1;
            lblChange.Enabled = flag2;
            lblTypeRegistrarNew.Enabled = flag3;
            txtTypeRegistrarNew.Enabled = flag3;
            txtTypeRegistrarNew.Clear();
            cmbTypeRegistrar.Text = "";
        }

        private void ClearElement()
        {
            txtTypeRegistrarNew.Clear();
            cmbTypeRegistrar.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if (txtTypeRegistrarNew.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление типа регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var typeRegistrar1 = txtTypeRegistrarNew.Text;
                    var typeList = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                        .GetTypeRegistrarOf(typeRegistrar1).ToList();
                    if (typeList.Count != 0)
                    {
                        MessageBox.Show("Тип регистратора «" + txtTypeRegistrarNew.Text + "» уже существует в базе данных!",
                            "Добавление типа регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить тип регистратора «" +
                        txtTypeRegistrarNew.Text + "»?", "Добавление типа регистратора", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeRegistrar = new TypeRegistrar
                            {
                                Type = txtTypeRegistrarNew.Text
                            };
                            TypeRegistrarRepository.GetInstance(mainForm.SessionFactory).Save(typeRegistrar);
                            MessageBox.Show("Добавление типа регистратора «" +
                            txtTypeRegistrarNew.Text + "» выполнено успешно", "Добавление типа регистратора",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if (cmbTypeRegistrar.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление типа регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var typeRegistrar2 = cmbTypeRegistrar.Text;
                    var registrarList = RegistrarRepository.GetInstance(mainForm.SessionFactory)
                        .GetRegistrarByTypeRegistrar(typeRegistrar2);
                    if (registrarList.Count != 0)
                    {
                        MessageBox.Show("Невозможно удалить тип регистратора «" + cmbTypeRegistrar.Text + 
                            "», пока он используется другой таблицей!",
                            "Удаление типа регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить тип регистратора «" +
                        cmbTypeRegistrar.Text + "»?", "Удаление типа регистратора",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeRegistrar = new TypeRegistrar
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory).GetIdByTypeRegistrar(cmbTypeRegistrar.Text),
                                Type = cmbTypeRegistrar.Text
                            };
                            TypeRegistrarRepository.GetInstance(mainForm.SessionFactory).Delete(typeRegistrar);
                            MessageBox.Show("Удаление типа регистратора «" +
                            txtTypeRegistrarNew.Text + "» выполнено успешно", "Удаление типа регистратора",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((cmbTypeRegistrar.Text.Equals("")) || (txtTypeRegistrarNew.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение типа регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var typeRegistrar1 = txtTypeRegistrarNew.Text;
                    var typeList = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                        .GetTypeRegistrarOf(typeRegistrar1).ToList();
                    if (typeList.Count != 0)
                    {
                        MessageBox.Show("Тип регистратора «" + txtTypeRegistrarNew.Text + "» уже существует в базе данных!",
                            "Изменение типа регистратора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtTypeRegistrarNew.Clear();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить тип регистратора «" +
                                cmbTypeRegistrar.Text + "» на тип регистратора «" + txtTypeRegistrarNew.Text + "»?",
                                "Изменение типа регистратора", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var typeRegistrar = new TypeRegistrar
                            {
                                Id = TypeRegistrarRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByTypeRegistrar(cmbTypeRegistrar.Text),
                                Type = txtTypeRegistrarNew.Text
                        };
                            TypeRegistrarRepository.GetInstance(mainForm.SessionFactory).Save(typeRegistrar);
                            MessageBox.Show("Изменение типа регистратора «" + cmbTypeRegistrar.Text +
                            "» на тип регистратора «" + txtTypeRegistrarNew.Text + "» выполнено успешно",
                            "Изменение типа регистратора", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddTypeRegistrar();
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
               "Закрытие окна редактирования типа регистратора",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
