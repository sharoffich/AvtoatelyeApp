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
    public partial class InsertForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public InsertForm()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Recording](Data, Time, Surname, Name, Middlename, Number) VALUES (N'{dateTimePickerDate.Value}', N'{dateTimePickerTime.Value}', N'{textBoxSurname.Text}', N'{textBoxName.Text}', N'{textBoxMiddlename.Text}', N'{maskedTextBoxNumber.Text}')", connection);
            MessageBox.Show("Добавление записей: " + command.ExecuteNonQuery().ToString());
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-G8KHEFF\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.ShowDialog();
            connection.Close();
        }
    }
}
