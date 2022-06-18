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
    public partial class MarksUC : UserControl
    {

        public MarksUC()
        {
            InitializeComponent();

            var conn = DB.GetInstance();
            conn.Open();
            var subjects = new List<DBItem>();
            using (var cmd = new MySqlCommand(@"SELECT
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
            
            conn.Close();
            dataGridView1.AutoGenerateColumns = false;
            populateGrid();
        }

        private Dictionary<int, Mark> toUpdate;// = new Dictionary<int,Mark>();
        private List<Mark> markList;// = new List<Mark>();
        private List<_Task> taskList;// = new List<_Task>();
        private List<Student> studentList;// = new List<Student>();
        private void populateGrid()
        {
            if (comboBoxSubject.Items.Count == 0) return;

            var subject = (DBItem)comboBoxSubject.Items[comboBoxSubject.SelectedIndex];
            var subjectid = subject.Id;
            var conn = DB.GetInstance();
            conn.Open();

            toUpdate = new Dictionary<int, Mark>();
            markList = new List<Mark>();
            taskList = new List<_Task>();
            studentList = new List<Student>();


            //var idList = new List<int>();
            //var nameList = new List<string>();
            //var surnameList = new List<string>();

            using (var cmd = new MySqlCommand(@"SELECT
                    s.id,
                    s.name,
                    s.surname
                FROM
                    student s
                JOIN student_subject ss ON
                    s.id = ss.studentid
                JOIN SUBJECT sub ON
                    ss.subjectid = sub.id
                WHERE
                    sub.id = @subjectid", conn))
            {
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                cmd.Prepare();
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studentList.Add(new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                        //idList.Add(reader.GetInt32(0));
                        //nameList.Add(reader.GetString(1));
                        //surnameList.Add(reader.GetString(2));
                    }
                }
            }

            using (var cmd = new MySqlCommand(
                @"SELECT
                    t.id,
                    t.name,
                    t.date_deadline,
                    t.teacherid,
                    t.task_type_id,
                    tt.name
                FROM
                    task t
                JOIN task_type tt ON tt.id = t.task_type_id
                WHERE
                    t.subjectid = @subjectid
                ORDER BY t.date_added ASC", conn))
            {
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                cmd.Prepare();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        taskList.Add(new _Task(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4),
                            reader.GetString(5)));
                    }
                }
            }

            using (var cmd = new MySqlCommand(@"SELECT
                                                m.id,
                                                m.studentid,
                                                m.taskid,
                                                m.value
                                            FROM
                                                mark m
                                            JOIN task t ON
                                                m.taskid = t.id
                                            WHERE
                                                t.subjectid = @subjectid", conn))
            {
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                cmd.Prepare();
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mark mark = new Mark(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetFloat(3));
                        mark.IsInDB = true;
                        markList.Add(mark);
                    }
                }
            }

                conn.Close();
            dataGridView1.Columns.Clear();

            var idColumn = new DataGridViewColumn();
            idColumn.Name = "id";
            idColumn.HeaderText = "Id";
            idColumn.ValueType = typeof(int);
            idColumn.ReadOnly = true;
            idColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(idColumn);

            var nameColumn = new DataGridViewColumn();
            nameColumn.Name = "name";
            nameColumn.HeaderText = "Imie";
            nameColumn.ReadOnly = true;
            nameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(nameColumn);

            var surnameColumn = new DataGridViewColumn();
            surnameColumn.Name = "surname";
            surnameColumn.HeaderText = "Nazwisko";
            surnameColumn.ReadOnly = true;
            surnameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(surnameColumn);
            for(int i = 0; i < taskList.Count; i++)
            {
                var task = taskList[i];
                var column = new DataGridViewColumn();
                column.Name = "task_name_"+task.Id;
                column.HeaderText = task.Name;
                column.HeaderCell.ToolTipText = task.TaskTypeReadableName;
                column.ReadOnly = true;
                column.CellTemplate = new DataGridViewTextBoxCell();
                column.ValueType = typeof(float);
                dataGridView1.Columns.Add(column);

                var id_column = new DataGridViewColumn();
                id_column.Name = "task_id_" + task.Id;
                id_column.HeaderText = task.Id.ToString();
                id_column.ReadOnly = true;
                id_column.CellTemplate = new DataGridViewTextBoxCell();
                id_column.Visible = false;
                dataGridView1.Columns.Add(id_column);
            }

            //for (int i = 0; i < studentList.Count; i++)
            foreach(Student student in studentList)
            {
                List<object> objectList = new List<object>();
                objectList.Add(student.Id);
                objectList.Add(student.Name);
                objectList.Add(student.Surname);
                foreach (_Task task in taskList)
                {
                    Mark? mark = null;
                    try
                    {
                        mark = markList.First(m => m.StudentId == student.Id && m.TaskId == task.Id);
                    }
                    catch (InvalidOperationException ex)
                    {

                    }
                    if (mark != null)
                    {
                        objectList.Add(mark.Value);
                        objectList.Add(mark.Id);
                    }
                    else 
                    { 
                        objectList.Add(null);
                        objectList.Add(null);
                    }
                }
                dataGridView1.Rows.Add(objectList.ToArray());

            }
            

        }

        private void MarksUC_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var cell = dataGridView1.SelectedCells[0];
                //cell.OwningRow.Cells[cell.RowIndex + 1]
                if (cell.ValueType == typeof(float))
                new SetMarkForm(cell,toUpdate,markList).ShowDialog();
                
            }catch(Exception ex)
            {

            }
            dataGridView1.ClearSelection();
        }
        private const string sqlInsert = "INSERT INTO mark (studentid,taskid,value) VALUES (@studentid,@taskid,@value);";
        private const string sqlUpdate = "UPDATE mark SET value = @value WHERE id = @id;";
        private const string sqlDelete = "DELETE FROM mark WHERE id = @id;";
        private void button1_Click(object sender, EventArgs e)
        {
            var conn = DB.GetInstance();
            conn.Open();
            foreach(var mark in toUpdate.Values)
            {
                if (mark.toDelete) // delete
                {
                    using (var cmd = new MySqlCommand(sqlDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", mark.Id);
                        cmd.Prepare();
                        int ok = cmd.ExecuteNonQuery();
                        if (ok != 1)
                        {
                            // błąd?
                        }
                    }
                }
                else if (mark.IsInDB) // update
                {
                    using(var cmd = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@value",mark.Value);
                        cmd.Parameters.AddWithValue("@id",mark.Id);
                        cmd.Prepare();
                        int ok = cmd.ExecuteNonQuery();
                        if (ok != 1)
                        {
                            // błąd?
                        }
                    }
                }
                else // insert
                {
                    using(var cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentid",mark.StudentId);
                        cmd.Parameters.AddWithValue("@taskid",mark.TaskId);
                        cmd.Parameters.AddWithValue("@value",mark.Value);
                        cmd.Prepare();
                        int ok = cmd.ExecuteNonQuery();
                        if(ok != 1)
                        {
                            // błąd?
                        }
                    }
                }
            }
            conn.Close();
            populateGrid();
        }

        private void comboBoxSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            populateGrid();
        }
    }
}
