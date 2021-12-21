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
    public partial class ServiceForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table;
        private double d;

        public ServiceForm()
        {
            InitializeComponent();
        }

        private void заказнарядыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new MainForm();
            main.ShowDialog();
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

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoatelyeBDDataSet.Recording". При необходимости она может быть перемещена или удалена.
            this.recordingTableAdapter.Fill(this.avtoatelyeBDDataSet.Recording);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceInsertForm serviceinsert = new ServiceInsertForm();
            serviceinsert.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Service WHERE ID = N'{textBoxID.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();         // обновление таблицы после добавления записи
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();    
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            d = 0;
            label1.Text = d.ToString();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Surname LIKE '%{0}%'", textBox_search.Text);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE [Service] SET Surname = N'{textBoxSurname.Text}', Service = N'{textBoxService.Text}', Material = N'{textBoxMaterial.Text}', Price = N'{textBoxPrice.Text}' WHERE id = {int.Parse(textBox_ID.Text)}", connection);
                MessageBox.Show("Записи обновлены. " + command.ExecuteNonQuery().ToString());
                textBoxSurname.Clear();
                textBoxService.Clear();
                textBoxMaterial.Clear();
                textBoxPrice.Clear();
                table.Clear();         // обновление таблицы после добавления записи
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Выберите строчку!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxService.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxMaterial.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox_search_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_search.Clear();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form info = new InfoForm();
            info.ShowDialog();
        }
    }
}
