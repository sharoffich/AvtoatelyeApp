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
    public partial class ServiceMasterForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table ;
        private double d;
        public ServiceMasterForm()
        {
            InitializeComponent();
        }

        private void заказнарядыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form master = new MasterForm();
            master.ShowDialog();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Surname LIKE '%{0}%'", textBox_search.Text);
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

        private void ServiceMasterForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-G8KHEFF\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();

            // создание таблицы в дата грид вью
            adapter = new SqlDataAdapter("SELECT* FROM Service", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderCell.Value = "№";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Услуга";
            dataGridView1.Columns[3].HeaderCell.Value = "Материал";
            dataGridView1.Columns[4].HeaderCell.Value = "Цена";

            dataGridView1.Columns["Material"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Service"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            MastersServiceInsertForm mastersServiceInsertForm = new MastersServiceInsertForm();
            mastersServiceInsertForm.ShowDialog();
        }

        private void buttonValue_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                double number;
                string value = row.Cells[4].Value.ToString();

                if (Double.TryParse(value, out number))
                    d += number;
            }
            label1.Text = d.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            d = 0;
            label1.Text = d.ToString();
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
