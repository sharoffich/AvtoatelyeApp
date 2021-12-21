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
    public partial class ServiceInsertForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table;
        public ServiceInsertForm()
        {
            InitializeComponent();
        }

        private void ServiceInsertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoatelyeBDDataSet.Recording". При необходимости она может быть перемещена или удалена.
            this.recordingTableAdapter.Fill(this.avtoatelyeBDDataSet.Recording);
            connection = new SqlConnection(@"Data Source=DESKTOP-G8KHEFF\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Service](Surname, Service, Material, Price) VALUES (N'{comboBoxSurname.Text}', N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}')", connection);
            MessageBox.Show("Добавление записей: " + command.ExecuteNonQuery().ToString());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceForm service = new ServiceForm();
            service.ShowDialog();
            connection.Close();
        }

        private void comboBoxSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxSurname.SelectedValue.ToString());
        }
    }
}
