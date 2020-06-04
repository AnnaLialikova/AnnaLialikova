using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;
namespace EmployeeApp
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //вставка новой анкеты в таблицу базы данных
        {
         

            string connectionString = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder(connectionString);
            using (SQLiteConnection connection = new SQLiteConnection(builder.ConnectionString))
            {
                connection.Open();
                try
                {
                    string commandText = string.Format("INSERT INTO dbTable (id, Name, Second_Name, Surname, Date_of_birth, Adress, Departement, Info_about) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", textBoxID.Text, textBoxName.Text, textBoxSecondName.Text, textBoxSurname.Text, textBoxDate.Text, textBoxAdress.Text, textBoxDepartement.Text, textBoxInfo.Text);
                    SQLiteCommand command = new SQLiteCommand(commandText, connection);
                    int number = command.ExecuteNonQuery();

                    richTextBox1.Text += (" Анкета добавлена.");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ID не уникален!");
                }
            }


        }

        
        private void NewAccountForm_Load(object sender, EventArgs e)  //генерируем новый айди на 1 больше предыдущего
        {
            string connectionString = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder(connectionString);
            using (SQLiteConnection connection = new SQLiteConnection(builder.ConnectionString))
            {
                connection.Open();
                string id = "";
                SQLiteCommand command1 = new SQLiteCommand("SELECT MAX(id) FROM dbTable", connection);
               
                id = command1.ExecuteScalar().ToString();
                int id_d = Int32.Parse(id) + 1;
                textBoxID.Text = id_d.ToString();
                connection.Close();
            }

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            
            
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)  //проверка на корректность ввода имени
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле имени не должно содержать цифры!");
                
            }
        }

        private void textBoxSecondName_KeyPress(object sender, KeyPressEventArgs e)  //проверка на корректность ввода отчества
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле отчества не должно содержать цифры!");

            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)   //проверка на корректность ввода фамилии
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле фамилии не должно содержать цифры!");

            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
