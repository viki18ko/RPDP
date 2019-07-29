using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using NHibernate;

namespace RPDP.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public ISessionFactory SessionFactory { get; protected set; }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ConfigurationManager.AppSettings["databaseLocation"],
                InitialCatalog = ConfigurationManager.AppSettings["databaseName"],
                IntegratedSecurity = true
            };
            SessionFactory = RepositoryLibrary.Repository.SessionFactory.GetSessionFactory(builder.ConnectionString);
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из приложения", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            Application.Exit();
        }

        private void вагоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeCarForm().ShowDialog(this);
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePositionForm().ShowDialog(this);
        }

        private void классыМашинистовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeClassForm().ShowDialog(this);
        }

        private void количествоВагоновВСоставеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeAmountCarForm().ShowDialog(this);
        }

        private void маршрутыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ChangeRouteForm().ShowDialog(this);
        }

        private void регистраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeRegistrarForm().ShowDialog(this);
        }

        private void составыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeCompositionForm().ShowDialog(this);
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeEmployeeForm().ShowDialog(this);
        }

        private void типыВагоновToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ChangeTypeCarForm().ShowDialog(this);
        }

        private void типыРегистраторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeTypeRegistrarForm().ShowDialog(this);
        }

        private void btnCreateAct_Click(object sender, EventArgs e)
        {
            new CreateActForm().ShowDialog(this);
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            new CreateReportRegistrarForm().ShowDialog(this);
        }
    }
}
