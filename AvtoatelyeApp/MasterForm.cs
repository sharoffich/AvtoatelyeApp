using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AvtoatelyeApp
{
    public partial class MasterForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-G8KHEFF\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();

            // создание таблицы в дата грид вью
            adapter = new SqlDataAdapter("SELECT* FROM Recording", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderCell.Value = "№";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderCell.Value = "Дата";
            dataGridView1.Columns[2].HeaderCell.Value = "Время";
            dataGridView1.Columns[3].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[4].HeaderCell.Value = "Имя";
            dataGridView1.Columns[5].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[6].HeaderCell.Value = "Номер телефона";
            dataGridView1.Columns[7].Visible = false;
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MessageBox.Show("Записи обновлены!", "Уведомление");
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new AuthorizationForm();
            login.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form masterinsert = new MaterInsertForm();
            masterinsert.ShowDialog();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form automaster = new ServiceMasterForm();
            automaster.ShowDialog();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Surname LIKE '%{0}%'", textBox_search.Text);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form info = new InfoForm();
            info.ShowDialog();
        }

        private void textBox_search_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_search.Clear();
        }
    }
}
