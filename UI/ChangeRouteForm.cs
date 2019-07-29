using System;
using System.Linq;
using RPDP.RepositoryLibrary.Repository.Implementation;
using RPDP.RepositoryLibrary.Entity;
using System.Windows.Forms;

namespace RPDP.UI
{
    public partial class ChangeRouteForm : Form
    {
        public ChangeRouteForm()
        {
            InitializeComponent();
        }

        private void ChangeRouteForm_Load(object sender, EventArgs e)
        {
            AddRoute();
            radioBtnAdd.Checked = true;
            EnabledElement(false, false, true);
            cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void EnabledElement(Boolean flag1, Boolean flag2, Boolean flag3)
        {
            lblRoute.Enabled = flag1;
            cmbRoute.Enabled = flag1;
            lblChange.Enabled = flag2;
            lblRouteNew.Enabled = flag3;
            txtRouteNew.Enabled = flag3;
        }

        private void AddRoute()
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            cmbRoute.DataSource = RouteRepository.GetInstance(mainForm.SessionFactory).GetNumberRoute();
            ClearElement();
        }

        private void ClearElement()
        {
            txtRouteNew.Clear();
            cmbRoute.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm == null)
                return;

            if (radioBtnAdd.Checked)
            {
                if (txtRouteNew.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно добавить пустую строку!",
                            "Добавление маршрута запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var number1 = Convert.ToInt32(txtRouteNew.Text);
                    var routeList = RouteRepository.GetInstance(mainForm.SessionFactory)
                        .GetNumberRouteOf(number1).ToList();
                    if (routeList.Count != 0)
                    {
                        MessageBox.Show("Маршрут «" + txtRouteNew.Text + "» уже существует в базе данных!",
                            "Добавление маршрута запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить маршрут «" +
                        txtRouteNew.Text + "»?", "Добавление маршрута", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var number = new Route
                            {
                                NumberRoute = Convert.ToInt32(txtRouteNew.Text)
                            };
                            RouteRepository.GetInstance(mainForm.SessionFactory).Save(number);
                            MessageBox.Show("Добавление маршрута «" +
                            txtRouteNew.Text + "» выполнено успешно", "Добавление маршрута", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (radioBtnDelete.Checked)
            {
                if (cmbRoute.Text.Equals(""))
                {
                    MessageBox.Show("Невозможно удалить пустую строку!",
                            "Удаление маршрута запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить маршрут «" +
                    cmbRoute.Text + "»?", "Удаление маршрута", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var route = new Route
                        {
                            Id = RouteRepository.GetInstance(mainForm.SessionFactory).GetIdByNumberRoute(Convert.ToInt32(cmbRoute.Text)),
                            NumberRoute = Convert.ToInt32(cmbRoute.Text)
                        };
                        RouteRepository.GetInstance(mainForm.SessionFactory).Delete(route);
                        MessageBox.Show("Удаление маршрута «" +
                            cmbRoute.Text + "» выполнено успешно", "Удаление маршрута", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }

            if (radioBtnChange.Checked)
            {
                if ((cmbRoute.Text.Equals("")) || (txtRouteNew.Text.Equals("")))
                {
                    MessageBox.Show("Невозможно произвести замену пустых строк!",
                            "Изменение маршрута запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var number1 = Convert.ToInt32(txtRouteNew.Text);
                    var routeList = RouteRepository.GetInstance(mainForm.SessionFactory)
                        .GetNumberRouteOf(number1).ToList();
                    if (routeList.Count != 0)
                    {
                        MessageBox.Show("Маршрут «" + txtRouteNew.Text + "» уже существует в базе данных!",
                            "Изменение маршрута запрещено", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить маршрут «" +
                        cmbRoute.Text + "» на маршрут «" + txtRouteNew.Text + "»?", "Изменение маршрута",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var number = new Route
                            {
                                Id = RouteRepository.GetInstance(mainForm.SessionFactory)
                                .GetIdByNumberRoute(Convert.ToInt32(cmbRoute.Text)),
                                NumberRoute = Convert.ToInt32(txtRouteNew.Text)
                            };
                            RouteRepository.GetInstance(mainForm.SessionFactory).Save(number);
                            MessageBox.Show("Изменение маршрута «" +
                                cmbRoute.Text + "» на маршрут «" + txtRouteNew.Text + "» выполнено успешно",
                                "Изменение маршрута", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            ClearElement();
            AddRoute();
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
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Закрытие окна редактирования маршрута",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
