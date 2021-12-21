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
    public partial class AuthorizationForm : Form
    {
        private SqlConnection SqlConnection = null;
        private SqlDataAdapter SqlDataAdapter;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "1234")
            {
                this.Hide();
                MainForm Mainform = new MainForm();
                Mainform.ShowDialog();
                this.Close();

            }
            else
            {
                try
                {
                    string loginUser = textBoxLogin.Text;
                    string passUser = textBoxPassword.Text;

                    SqlConnection = new SqlConnection(@"Data Source=DESKTOP-G8KHEFF\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
                    SqlConnection.Open();

                    DataTable table = new DataTable();

                    SqlDataAdapter = new SqlDataAdapter();

                    SqlCommand command = new SqlCommand("SELECT * from USERS Where Username = @login AND Password = @password", SqlConnection);
                    command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginUser;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = passUser;
                    SqlDataAdapter.SelectCommand = command;
                    SqlDataAdapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                        //AccesToken.accesToken = 0;
                        MasterForm f1 = new MasterForm();
                        f1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Логин/Пароль введены неверно", "Ошибка!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }
    }
}
