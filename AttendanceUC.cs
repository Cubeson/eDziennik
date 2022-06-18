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
    public partial class AttendanceUC : UserControl
    {
        private List<DBItem> subjectList;
        private List<Student> studentList;
        public AttendanceUC()
        {
            InitializeComponent();
            var toolTip  = new ToolTip();
            toolTip.SetToolTip(this.checkBoxSpecificDate, "Zaznaczenie tego pola spowoduje, że\nobecność zostanie wpisana z datą podaną w kalendarzu poniżej.\n W innym wypadku obecność zostanie wpisana z dzisiejszą datą i godziną");

            var conn = DB.GetInstance();
            conn.Open();
            subjectList = new List<DBItem>();
            using(var cmd = new MySqlCommand(@"SELECT
                                                s.id,
                                                s.name
                                            FROM SUBJECT
                                                s
                                            JOIN teacher_subject ts ON
                                                s.id = ts.subjectid
                                            WHERE
                                                ts.teacherid = @teacherid", conn))
            {
                cmd.Parameters.AddWithValue("@teacherid",Form1.currentUser.Id);
                cmd.Prepare();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        subjectList.Add(new DBItem(id, name));
                    }
                }
            }
            conn.Close();
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(subjectList.ToArray());
            
            if (comboBoxSubject.Items.Count > 0)
                comboBoxSubject.SelectedItem = comboBoxSubject.Items[0];
            
            comboBoxSubjectGrid.Items.Clear();
            comboBoxSubjectGrid.Items.AddRange(subjectList.ToArray());

            if (comboBoxSubjectGrid.Items.Count > 0)
                comboBoxSubjectGrid.SelectedItem = comboBoxSubjectGrid.Items[0];

            ChangeStudentComboBox();
            ChangeGridView();
        }

        private void ChangeStudentComboBox()
        {
            if (comboBoxSubject.Items.Count == 0) return;
            var subject = (DBItem)comboBoxSubject.Items[comboBoxSubject.SelectedIndex];
            var subjectid = subject.Id;
            var conn = DB.GetInstance();
            conn.Open();
            studentList = new();
            using(var cmd = new MySqlCommand(@"SELECT
                                                s.id,
                                                s.name,
                                                s.surname
                                            FROM
                                                student s
                                            JOIN student_subject ss ON
                                                s.id = ss.studentid
                                            WHERE
                                                ss.subjectid = 1", conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string surName = reader.GetString(2);
                        studentList.Add(new Student(id, name, surName));
                    }
                }
            }
            conn.Close();
            comboBoxStudent.Items.Clear();
            comboBoxStudent.Items.AddRange(studentList.ToArray());
            if (comboBoxStudent.Items.Count > 0)
                comboBoxStudent.SelectedItem = comboBoxStudent.Items[0];
        }
        private void ChangeGridView()
        {
            if(comboBoxSubjectGrid.Items.Count == 0) return;

            var subject = (DBItem)comboBoxSubjectGrid.Items[comboBoxSubjectGrid.SelectedIndex];
            var subjectid = subject.Id;
            var conn = DB.GetInstance();
            conn.Open();
            dataGridView.Rows.Clear();
            using (var cmd = new MySqlCommand(@"SELECT
                                                a.id,
                                                a.datetime_present,
                                                a.present,
                                                s.id,
                                                s.name,
                                                s.surname
                                            FROM
                                                attendence a
                                            JOIN student s ON
                                                a.studentid = s.id
                                            WHERE
                                                a.subjectid = @subjectid", conn))
            {
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string datetime_present = reader.GetString(1);
                        bool present = reader.GetBoolean(2);
                        int studentId = reader.GetInt32(3);
                        string studentName  = reader.GetString(4);
                        string studentSurname = reader.GetString(5);
                        dataGridView.Rows.Add(id,datetime_present,studentId,studentName,studentSurname,present);
                    }
                }
            }

                conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AttendanceUC_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var studentid = ((Student)comboBoxStudent.SelectedItem).Id;
            var subjectid = ((DBItem)comboBoxSubject.SelectedItem).Id;
            var present = checkBoxWasPresent.Checked;

            var conn = DB.GetInstance();
            conn.Open();

            using (var cmd = new MySqlCommand(@"INSERT INTO attendence(
                                                studentid,
                                                subjectid,
                                                present,
                                                datetime_present
                                            )
                                            VALUES(@studentid, @subjectid, @present, @datetime_present);", conn))
            {
                if (checkBoxSpecificDate.Checked)
                {
                    string datetime_present = dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.AddWithValue("@datetime_present", datetime_present);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@datetime_present", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                }
                cmd.Parameters.AddWithValue("@studentid", studentid);
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                cmd.Parameters.AddWithValue("@present", present);
                cmd.Prepare();
                int ok = cmd.ExecuteNonQuery();
                if(ok == 0)
                {
                    // Błąd?
                }
                else
                {
                    MessageBox.Show("Dodano obecność");
                }
            }

            conn.Close();


        }

        private void comboBoxSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeStudentComboBox();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
