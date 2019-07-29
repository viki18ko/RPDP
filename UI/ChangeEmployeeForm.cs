using System;
using System.Windows.Forms;
using RPDP.RepositoryLibrary.Repository.Implementation;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.UI
{
    public partial class ChangeEmployeeForm : Form
    {
        public ChangeEmployeeForm()
        {
            InitializeComponent();
        }

        private void ChangeEmployeeForm_Load(object sender, EventArgs e)
        {
            datePickerStartDate.Format = DateTimePickerFormat.Custom;
            datePickerStartDate.CustomFormat = "dd.MM.yyyy";
            datePickerStartDate.ShowUpDown = true;
            datePickerStartDateNew.Format = DateTimePickerFormat.Custom;
            datePickerStartDateNew.CustomFormat = "dd.MM.yyyy";
            datePickerStartDateNew.ShowUpDown = true;
            radioBtnAdd.Checked = true;
            AddEmployee();
            cmbFIOemployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClassNew.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPositionNew.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFIOinstructorNew.DropDownStyle = ComboBoxStyle.DropDownList;
            EnabledElement(false, false, false, true, false);
        }

        private void AddEmployee()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbFIOemployee.DataSource = EmployeeRepository.GetInstance(mainForm.SessionFactory).GetNameEmployee();
            cmbPositionNew.DataSource = PositionRepository.GetInstance(mainForm.SessionFactory).GetNamePosition();
            cmbClassNew.DataSource = ClassRepository.GetInstance(mainForm.SessionFactory).GetNumberClass();
            cmbFIOinstructorNew.DataSource = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                .GetEmployeeByPosition("ТЧМ");
            ClearElement();
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3, Boolean flag4, Boolean flag5)
        {
            cmbFIOemployee.Enabled = flag1;
            lblFIOemployee.Enabled = flag1;
            txtPosition.Enabled = flag1;
            lblPosition.Enabled = flag1;
            txtClass.Enabled = flag2;
            lblClass.Enabled = flag2;
            datePickerStartDate.Enabled = flag2;
            lblDate.Enabled = flag2;
            txtFIOinstructor.Enabled = flag2;
            lblFIOinstructor.Enabled = flag2;
            lblChange.Enabled = flag3;
            txtSurnameNew.Enabled = flag4;
            lblSurname.Enabled = flag4;
            txtNameNew.Enabled = flag4;
            lblName.Enabled = flag4;
            txtPatronymicNew.Enabled = flag4;
            lblPatronymic.Enabled = flag4;
            cmbPositionNew.Enabled = flag4;
            lblPositionNew.Enabled = flag4;
            cmbClassNew.Enabled = flag5;
            lblClassNew.Enabled = flag5;
            datePickerStartDateNew.Enabled = flag5;
            lblDateNew.Enabled = flag5;
            cmbFIOinstructorNew.Enabled = flag5;
            lblFIOinstructorNew.Enabled = flag5;
        }

        private void ClearElement()
        {
            cmbFIOemployee.SelectedIndex = -1;
            txtPosition.Clear();
            txtClass.Clear();
            txtFIOinstructor.Clear();
            datePickerStartDate.Text = "";
            txtNameNew.Clear();
            txtSurnameNew.Clear();
            txtPatronymicNew.Clear();
            cmbPositionNew.SelectedIndex = -1;
            cmbClassNew.SelectedIndex = -1;
            cmbFIOinstructorNew.SelectedIndex = -1;
            datePickerStartDateNew.Text = "";
        }

        private void cmbFIOemployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (!cmbFIOemployee.Text.Equals(""))
            {
                var nameEmployee = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbFIOemployee.Text);
                txtPosition.Text = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetPositionByEmployeeName(nameEmployee);
                txtSurnameNew.Text = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetSurnameByName(nameEmployee);
                txtNameNew.Text = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetNameByName(nameEmployee);
                txtPatronymicNew.Text = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                    .GetPatronymicByName(nameEmployee);
                cmbPositionNew.Text = txtPosition.Text;
                if (txtPosition.Text.Equals("Машинист"))
                {
                    txtClass.Text = Convert.ToString(EmployeeRepository.GetInstance(mainForm.SessionFactory)
                        .GetClassByName(nameEmployee));
                    datePickerStartDate.Text = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                        .GetStartDateByName(nameEmployee).ToString();
                    txtFIOinstructor.Text = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                        .GetNameInstructorByNameDriver(nameEmployee);
                    cmbClassNew.Text = txtClass.Text;
                    datePickerStartDateNew.Text = datePickerStartDate.Text;
                    cmbFIOinstructorNew.Text = txtFIOinstructor.Text;
                }
            }
        }

        private void StopAddition()
        {
            MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление сотрудника запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void StopChange()
        {
            MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение сотрудника запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if (((txtSurnameNew.Text.Equals("")) || (txtNameNew.Text.Equals("")) || (txtPatronymicNew.Text.Equals(""))
                    || (cmbPositionNew.Text.Equals(""))) && (!cmbPositionNew.Text.Equals("Машинист")))
                {
                    StopAddition();
                }
                else if (((txtSurnameNew.Text.Equals("")) || (txtNameNew.Text.Equals("")) || (txtPatronymicNew.Text.Equals(""))
                    || (cmbPositionNew.Text.Equals("")) || (cmbClassNew.Text.Equals(""))
                    || (datePickerStartDateNew.Equals("")) || (cmbFIOinstructorNew.Equals("")))
                    && (cmbPositionNew.Text.Equals("Машинист")))
                {
                    StopAddition();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить сотрудника «" +
                    txtSurnameNew.Text + " " + txtNameNew.Text + " " + txtPatronymicNew.Text + "»?", "Добавление сотрудника",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var nameEmployee = RPDP.RepositoryLibrary.Entity.Name.ToName
                            (String.Format("{0} {1} {2}", txtSurnameNew.Text, txtNameNew.Text, txtPatronymicNew.Text));
                        var position = new Position
                        {
                            Id = PositionRepository.GetInstance(mainForm.SessionFactory)
                            .GetIdByPosition(cmbPositionNew.Text),
                            NamePosition = cmbPositionNew.Text
                        };
                        if (!cmbPositionNew.Text.Equals("Машинист"))
                        {
                            var employee = new Employee
                            {
                                Name = nameEmployee,
                                IdPosition = position,
                                StartDate = Convert.ToDateTime("01.01.1753")
                            };
                            EmployeeRepository.GetInstance(mainForm.SessionFactory).Save(employee);
                        }
                        else
                        {
                            var numberClass = new Class
                            {
                                Id = ClassRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByClass(Convert.ToInt32(cmbClassNew.Text)),
                                NumberClass = Convert.ToInt32(cmbClassNew.Text)
                            };

                            var nameInstructor = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbFIOinstructorNew.Text);
                            var positionInstructor = new Position
                            {
                                Id = PositionRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByPosition("ТЧМ"),
                                NamePosition = "ТЧМ"
                            };
                            var instructor = new Employee
                            {
                                Id = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByEmployee(nameInstructor),
                                Name = nameInstructor,
                                IdPosition = positionInstructor
                            };
                            var driver = new Employee
                            {
                                Name = nameEmployee,
                                IdPosition = position,
                                IdClass = numberClass,
                                StartDate = Convert.ToDateTime(datePickerStartDateNew.Text),
                                IdInstructor = instructor
                            };
                            EmployeeRepository.GetInstance(mainForm.SessionFactory).Save(driver);
                            MessageBox.Show("Добавление сотрудника «" + txtSurnameNew.Text + " " + txtNameNew.Text + " " 
                                + txtPatronymicNew.Text + "» выполнено успешно", "Добавление сотрудника",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if (((cmbFIOemployee.Text.Equals(""))
                    || (txtPosition.Text.Equals(""))) && (!txtPosition.Text.Equals("Машинист")))
                {
                    StopAddition();
                }
                else if (((cmbFIOemployee.Text.Equals(""))
                    || (txtPosition.Text.Equals("")) || (txtPosition.Text.Equals(""))
                    || (datePickerStartDate.Equals("")) || (txtFIOinstructor.Equals("")))
                    && (cmbPositionNew.Text.Equals("Машинист")))
                {
                    StopAddition();
                }
                else
                {
                    if (txtPosition.Text.Equals("ТЧМ"))
                    {
                        var instructor1 = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbFIOemployee.Text);
                        var driverList = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                            .GetNameInstructor("Машинист", instructor1);
                        if (driverList.Count != 0)
                        {
                            MessageBox.Show("Невозможно удалить инструктора «" + cmbFIOemployee.Text +
                                "», пока он используется данной таблицей!",
                                "Удаление инструктора запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить сотрудника «" +
                        cmbFIOemployee.Text + "»?", "Удаление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var nameEmployee = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbFIOemployee.Text);
                            var position = new Position
                            {
                                Id = PositionRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByPosition(txtPosition.Text),
                                NamePosition = txtPosition.Text
                            };
                            if (!txtPosition.Text.Equals("Машинист"))
                            {
                                var employee = new Employee
                                {
                                    Id = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdByEmployee(nameEmployee),
                                    Name = nameEmployee,
                                    IdPosition = position
                                };
                                EmployeeRepository.GetInstance(mainForm.SessionFactory).Delete(employee);
                            }
                            else
                            {
                                var numberClass = new Class
                                {
                                    Id = ClassRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdByClass(Convert.ToInt32(txtClass.Text)),
                                    NumberClass = Convert.ToInt32(txtClass.Text)
                                };

                                var nameInstructor = RPDP.RepositoryLibrary.Entity.Name.ToName(txtFIOinstructor.Text);
                                var positionInstructor = new Position
                                {
                                    Id = PositionRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdByPosition("ТЧМ"),
                                    NamePosition = "ТЧМ"
                                };
                                var instructor = new Employee
                                {
                                    Id = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdByEmployee(nameInstructor),
                                    Name = nameInstructor,
                                    IdPosition = positionInstructor
                                };
                                var driver = new Employee
                                {
                                    Id = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                                    .GetIdByEmployee(nameEmployee),
                                    Name = nameEmployee,
                                    IdPosition = position,
                                    IdClass = numberClass,
                                    StartDate = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                                    .GetStartDateByName(nameEmployee),
                                    IdInstructor = instructor
                                };
                                EmployeeRepository.GetInstance(mainForm.SessionFactory).Delete(driver);
                                MessageBox.Show("Удаление сотрудника «" + cmbFIOemployee.Text 
                                    + "» выполнено успешно", "Удаление сотрудника",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((cmbFIOemployee.Text.Equals("")) || (txtPosition.Text.Equals(""))
                    || (txtSurnameNew.Text.Equals("")) || (txtNameNew.Text.Equals(""))
                    || (txtPatronymicNew.Text.Equals("")) || (cmbPositionNew.Text.Equals("")))
                {
                    StopAddition();
                }
                else if ((cmbPositionNew.Text.Equals("Машинист")) && ((cmbClassNew.Text.Equals(""))
                    || (datePickerStartDateNew.Text.Equals("")) || (cmbFIOinstructorNew.Text.Equals(""))))
                {
                    StopAddition();
                }
                else if ((txtPosition.Text.Equals("Машинист")) && ((txtClass.Text.Equals(""))
                    || (datePickerStartDate.Text.Equals("")) || (txtFIOinstructor.Text.Equals(""))))
                {
                    StopAddition();
                }
                else
                {
                    var nameEmployee = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbFIOemployee.Text);
                    var nameEmployee2 = RPDP.RepositoryLibrary.Entity.Name.ToName(
                        String.Format("{0} {1} {2}", txtSurnameNew.Text, txtNameNew.Text, txtPatronymicNew.Text));
                    var position = new Position
                    {
                        Id = PositionRepository.GetInstance(mainForm.SessionFactory)
                        .GetIdByPosition(cmbPositionNew.Text),
                        NamePosition = cmbPositionNew.Text
                    };
                    if (!cmbPositionNew.Text.Equals("Машинист"))
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите внести следующие изменения: Ф.И.О. «" +
                        txtSurnameNew.Text + " " + txtNameNew.Text + " " + txtPatronymicNew.Text + "», должность «" 
                        + cmbPositionNew.Text + "»?", "Изменение сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var employee = new Employee
                            {
                                Id = EmployeeRepository.GetInstance(mainForm.SessionFactory).
                                GetIdByEmployee(nameEmployee),
                                Name = nameEmployee2,
                                IdPosition = position,
                                IdClass = null,
                                IdInstructor = null,
                                StartDate = Convert.ToDateTime("01.01.1753")
                            };
                            EmployeeRepository.GetInstance(mainForm.SessionFactory).Save(employee);
                            MessageBox.Show("Изменения: Ф.И.О. «" + txtSurnameNew.Text + " " + txtNameNew.Text 
                                + " " + txtPatronymicNew.Text + "», должность «" + cmbPositionNew.Text 
                                + "» выполнены успешно", "Изменение сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите внести следующие изменения: Ф.И.О. «" +
                        txtSurnameNew.Text + " " + txtNameNew.Text + " " + txtPatronymicNew.Text + "», должность «"
                        + cmbPositionNew.Text + "», класс «" + cmbClassNew.Text + "», дата поступления на работу «" + 
                        datePickerStartDateNew.Text  + "», Ф.И.О. инструктора «" + cmbFIOinstructorNew.Text + "»?",
                        "Изменение сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var numberClass = new Class
                            {
                                Id = ClassRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByClass(Convert.ToInt32(cmbClassNew.Text)),
                                NumberClass = Convert.ToInt32(cmbClassNew.Text)
                            };

                            var nameInstructor = RPDP.RepositoryLibrary.Entity.Name.ToName(cmbFIOinstructorNew.Text);
                            var positionInstructor = new Position
                            {
                                Id = PositionRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByPosition("ТЧМ"),
                                NamePosition = "ТЧМ"
                            };
                            var instructor = new Employee
                            {
                                Id = EmployeeRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByEmployee(nameInstructor),
                                Name = nameInstructor,
                                IdPosition = positionInstructor
                            };
                            var driver = new Employee
                            {
                                Id = EmployeeRepository.GetInstance(mainForm.SessionFactory).
                                GetIdByEmployee(nameEmployee),
                                Name = nameEmployee,
                                IdPosition = position,
                                IdClass = numberClass,
                                StartDate = Convert.ToDateTime(datePickerStartDateNew.Text),
                                IdInstructor = instructor
                            };
                            EmployeeRepository.GetInstance(mainForm.SessionFactory).Save(driver);
                            MessageBox.Show("Изменения: Ф.И.О. «" + txtSurnameNew.Text + " " + txtNameNew.Text + " " 
                                + txtPatronymicNew.Text + "», должность «" + cmbPositionNew.Text + "», класс «" 
                                + cmbClassNew.Text + "», дата поступления на работу «" + datePickerStartDateNew.Text 
                                + "», Ф.И.О. инструктора «" + cmbFIOinstructorNew.Text + "» выполнены успешно",
                                "Изменение сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddEmployee();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
            "Закрытие окна редактирования сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            EnabledElement(false, false, false, true, false);
            ClearElement();
        }

        private void radioBtnChange_CheckedChanged(object sender, EventArgs e)
        {
            EnabledElement(true, false, true, true, false);
            ClearElement();
        }

        private void radioBtnDelete_CheckedChanged_1(object sender, EventArgs e)
        {
            EnabledElement(true, false, false, false, false);
            ClearElement();
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            txtClass.Clear();
            txtFIOinstructor.Clear();
            datePickerStartDate.Text = "";
            if (radioBtnDelete.Checked)
            {
                if (txtPosition.Text.Equals("Машинист"))
                {
                    EnabledElement(true, true, false, false, false);
                }
                else
                {
                    EnabledElement(true, false, false, false, false);
                }
            }
            if (radioBtnChange.Checked)
            {
                if (txtPosition.Text.Equals("Машинист"))
                {
                    if (cmbPositionNew.Text.Equals("Машинист"))
                    {
                        EnabledElement(true, true, true, true, true);
                    }
                    else
                    {
                        EnabledElement(true, true, true, true, false);
                    }
                }
                else
                {
                    if (cmbPositionNew.Text.Equals("Машинист"))
                    {
                        EnabledElement(true, false, true, true, true);
                    }
                    else
                    {
                        EnabledElement(true, false, true, true, false);
                    }
                }
            }
        }

        private void cmbPositionNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClassNew.SelectedIndex = -1;
            cmbFIOinstructorNew.SelectedIndex = -1;
            datePickerStartDateNew.Text = "";
            if (radioBtnAdd.Checked)
            {
                if (cmbPositionNew.Text.Equals("Машинист"))
                {
                    EnabledElement(false, false, false, true, true);
                }

                if (!cmbPositionNew.Text.Equals("Машинист"))
                {
                    EnabledElement(false, false, false, true, false);
                }
            }
            if (radioBtnChange.Checked)
            {
                if (cmbPositionNew.Text.Equals("Машинист"))
                {
                    if (txtPosition.Text.Equals("Машинист"))
                    {
                        EnabledElement(true, true, true, true, true);
                    }
                    else
                    {
                        EnabledElement(true, false, true, true, true);
                    }
                }
                else
                {
                    if (txtPosition.Text.Equals("Машинист"))
                    {
                        EnabledElement(true, true, true, true, false);
                    }
                    else
                    {
                        EnabledElement(true, false, true, true, false);
                    }
                }
            }
        }
    }
}
