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
namespace EmployeeApp
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)  //обновляем данные в базе: имя, фамилию, отчество, дату рождения, адрес, отдел и информацию соответственно. Выбираем анкету человека по введенному айди - аналогично поиску
        {
            string connectionString1 = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder1 = new SQLiteConnectionStringBuilder(connectionString1);
            using (SQLiteConnection connection1 = new SQLiteConnection(builder1.ConnectionString))
            {
                connection1.Open();
                string command1Text = string.Format("UPDATE dbTable SET [Name] = '{0}' where id = '{1}'", textBoxName.Text, textBox1.Text);
                SQLiteCommand command1 = new SQLiteCommand(command1Text, connection1);
                int n = command1.ExecuteNonQuery();

                connection1.Close();


            }
            string connectionString2 = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder2 = new SQLiteConnectionStringBuilder(connectionString2);
            using (SQLiteConnection connection2 = new SQLiteConnection(builder2.ConnectionString))
            {
                connection2.Open();
                string command2Text = string.Format("UPDATE dbTable SET [Surname] = '{0}' where id = '{1}'", textBoxSurname.Text, textBox1.Text);
                SQLiteCommand command2 = new SQLiteCommand(command2Text, connection2);
                int n = command2.ExecuteNonQuery();

                connection2.Close();
            }
            string connectionString3 = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder3 = new SQLiteConnectionStringBuilder(connectionString3);
            using (SQLiteConnection connection3 = new SQLiteConnection(builder3.ConnectionString))
            {
                connection3.Open();
                string command3Text = string.Format("UPDATE dbTable SET [Second_name] = '{0}'where id = '{1}'", textBoxSecondName.Text, textBox1.Text);
                SQLiteCommand command3 = new SQLiteCommand(command3Text, connection3);
                int n = command3.ExecuteNonQuery();

                connection3.Close();
            }
            string connectionString4 = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder4 = new SQLiteConnectionStringBuilder(connectionString4);
            using (SQLiteConnection connection4 = new SQLiteConnection(builder4.ConnectionString))
            {
                connection4.Open();
                string command4Text = string.Format("UPDATE dbTable SET [Date_of_birth] = '{0}' where id = '{1}'", textBoxDate.Text, textBox1.Text);
                SQLiteCommand command4 = new SQLiteCommand(command4Text, connection4);
                int n = command4.ExecuteNonQuery();

                connection4.Close();
            }
            string connectionString5 = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder5 = new SQLiteConnectionStringBuilder(connectionString5);
            using (SQLiteConnection connection5 = new SQLiteConnection(builder5.ConnectionString))
            {
                connection5.Open();
                string command5Text = string.Format("UPDATE dbTable SET [Adress] = '{0}' where id = '{1}'", textBoxAdress.Text, textBox1.Text);
                SQLiteCommand command5 = new SQLiteCommand(command5Text, connection5);
                int n = command5.ExecuteNonQuery();

                connection5.Close();
            }
            string connectionString6 = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder6 = new SQLiteConnectionStringBuilder(connectionString6);
            using (SQLiteConnection connection6 = new SQLiteConnection(builder6.ConnectionString))
            {
                connection6.Open();
                string command6Text = string.Format("UPDATE dbTable SET [Departement] = '{0}'where id = '{1}'", textBoxDepartement.Text, textBox1.Text);
                SQLiteCommand command6 = new SQLiteCommand(command6Text, connection6);
                int n = command6.ExecuteNonQuery();

                connection6.Close();
            }
            string connectionString7 = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder7 = new SQLiteConnectionStringBuilder(connectionString7);
            using (SQLiteConnection connection7 = new SQLiteConnection(builder7.ConnectionString))
            {
                connection7.Open();
                string command7Text = string.Format("UPDATE dbTable SET [Info_about] = '{0}' where id = '{1}'", textBoxInfo.Text, textBox1.Text);
                SQLiteCommand command7 = new SQLiteCommand(command7Text, connection7);
                int n = command7.ExecuteNonQuery();

                connection7.Close();
            }

            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnterId_Click(object sender, EventArgs e)  //аналогично поиску по айди
        {
            string connectionString = string.Format("Data Source = {0}", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDB.db"));
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder(connectionString);
            using (SQLiteConnection connection1 = new SQLiteConnection(builder.ConnectionString))
            {
                connection1.Open();
                string command1Text = string.Format("SELECT * FROM [dbTable]  where id = '{0}'", textBox1.Text);
                SQLiteCommand command1 = new SQLiteCommand(command1Text, connection1);
                SQLiteDataReader n = command1.ExecuteReader();
                while (n.Read())
                {
                    textBoxName.Text = string.Format(" " + n["Name"]);
                    textBoxSurname.Text = string.Format(" " + n["Surname"]);
                    textBoxSecondName.Text = string.Format(" " + n["Second_name"]);
                    textBoxDate.Text = string.Format(" " + n["Date_of_birth"]);
                    textBoxAdress.Text = string.Format(" " + n["Adress"]);
                    textBoxDepartement.Text = string.Format(" " + n["Departement"]);
                    textBoxInfo.Text = string.Format(" " + n["Info_about"]);
                }
                n.Close();
                connection1.Close();


            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)  //проверка на корректность ввода имени
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле имени не должно содержать цифры!");

            }
        }

        private void textBoxSecondName_KeyPress(object sender, KeyPressEventArgs e)   //проверка на корректность ввода отчества
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле отчества не должно содержать цифры!");

            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)  //проверка на корректность ввода фамилии
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле фамилии не должно содержать цифры!");

            }
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
