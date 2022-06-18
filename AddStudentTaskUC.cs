using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace edziennik
{
    public partial class AddStudentTaskUC : UserControl
    {


        public AddStudentTaskUC()
        {
            InitializeComponent();

            monthCalendar1.MaxSelectionCount = 1;

            var conn = DB.GetInstance();
            conn.Open();
            var subjects = new List<DBItem>();
            using (var cmd = new MySqlCommand(
                @"SELECT
                    s.id,
                    s.name
                FROM SUBJECT
                    s
                JOIN teacher_subject ts ON
                    s.id = ts.subjectid
                JOIN teacher t ON
                    t.id = ts.teacherid
                WHERE
                    t.id = @uid", conn))
            {
                cmd.Parameters.AddWithValue("@uid", Form1.currentUser.Id);
                cmd.Prepare();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new DBItem(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }

            

            comboBoxSubject.Items.AddRange(subjects.ToArray());
            if(comboBoxSubject.Items.Count > 0)
                comboBoxSubject.SelectedItem = comboBoxSubject.Items[0];

            var taskTypes = new List<DBItem>();
            using (var cmd = new MySqlCommand("SELECT id,name FROM task_type", conn))
            {
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        taskTypes.Add(new DBItem(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            comboBoxTaskType.Items.AddRange(taskTypes.ToArray());
            if(comboBoxTaskType.Items.Count > 1)
            comboBoxTaskType.SelectedItem = comboBoxTaskType.Items[1];

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {

            if(comboBoxSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano przedmiotu");
                return;
            }
            if (comboBoxTaskType.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano rodzaju zadania");
                return;
            }
            if(monthCalendar1.SelectionStart < DateTime.Now)
            {
                MessageBox.Show("Nieprawidłowa data oddania");
                return;
            }
            if(textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nieprawidłowa nazwa zadania");
                return;
            }
            var deadline = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            var name = textBox1.Text.Trim();
            var teacherid = Form1.currentUser.Id;

            var subject= (DBItem)comboBoxSubject.Items[comboBoxSubject.SelectedIndex];
            var subjectid = subject.Id;
            var task = (DBItem)comboBoxTaskType.Items[comboBoxTaskType.SelectedIndex];
            var taskid = task.Id;

            var conn = DB.GetInstance();
            conn.Open();
            
            using(var cmd = new MySqlCommand(
                "INSERT INTO task (name,date_deadline,teacherid,subjectid,task_type_id)" +
                "VALUES (@name," +
                "@date_deadline," +
                "@teacherid,@subjectid,@task_type_id)",
                conn))
            {
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@date_deadline", deadline);
                cmd.Parameters.AddWithValue("@teacherid", teacherid);
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                cmd.Parameters.AddWithValue("@task_type_id", taskid);
                cmd.Prepare();
                var ok = cmd.ExecuteNonQuery();

                if(ok != 1)
                {
                    MessageBox.Show("Wystąpił błąd przy dodawaniu zadania");
                }
                else
                {
                    MessageBox.Show("Dodano zadanie");
                }
            }

            conn.Close();

            //MessageBox.Show(task.Name);
        }

        private void comboBoxSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddStudentTaskUC_Load(object sender, EventArgs e)
        {

        }
    }
}
