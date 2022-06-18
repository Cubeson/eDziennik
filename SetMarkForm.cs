using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edziennik
{
    public partial class SetMarkForm : Form
    {
        private DataGridViewCell cell;
        private List<Mark> markList;
        private Dictionary<int, Mark> toUpdate;
        public SetMarkForm(DataGridViewCell cell, Dictionary<int, Mark> toUpdate, List<Mark> markList)
        {
            this.markList = markList;
            this.toUpdate = toUpdate;
            this.cell = cell;
            InitializeComponent();
        }

        private void setMark(float f)
        {

            if(f == 0)
            {
                this.cell.Value = null;
                
            }
            else
            {
                this.cell.Value = f;
                
            }
            
            int idx = (cell.RowIndex * cell.OwningRow.Cells.Count) + cell.ColumnIndex;
            if (toUpdate.ContainsKey(idx)) // już istnieje taki element w liście ocen do zmiany
            {
                if(f == 0)
                {
                    toUpdate[idx].toDelete = true;
                    this.cell.Style.BackColor = Color.Red;
                }
                else
                {
                    toUpdate[idx].toDelete = false;
                    this.cell.Style.BackColor = Color.LightBlue;
                }
                toUpdate[idx].Value = f;
            }
            else // należy dodać nowy element do listy ocen do zmiany
            {
                int studentId = (int)cell.OwningRow.Cells["id"].Value;
                //int taskId = (int)cell.OwningColumn.HeaderCell.Value;
                var str = cell.OwningColumn.DataGridView.Columns[cell.OwningColumn.Index+1].HeaderText;
                int taskId = int.Parse(str);
                try // ocena istnieje w bazie danych (w liście pobranej z bazy danych)
                {
                    var mark = markList.First(m => m.StudentId == studentId && m.TaskId == taskId);
                    if (f == 0)
                    {
                        mark.toDelete = true;
                        this.cell.Style.BackColor = Color.Red;
                    }
                    else
                    {
                        mark.toDelete = false;
                        this.cell.Style.BackColor = Color.LightBlue;
                    }
                    mark.Value = f;
                    toUpdate.Add(idx, mark);
                }
                catch (InvalidOperationException) // nie ma oceny w bazie danych
                {
                    if(f == 0) // nie można usunąć oceny która nie istnieje w bazie danych, więc wracamy
                    {
                        this.Close();
                        return;
                    }
                    toUpdate.Add(idx, new Mark(0,studentId,taskId,f));
                    this.cell.Style.BackColor = Color.LightBlue;
                }
                
                
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setMark(1f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMark(1.5f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setMark(2f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setMark(2.5f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setMark(3f);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setMark(3.5f);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setMark(4f);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setMark(4.5f);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setMark(5f);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setMark(5.5f);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            setMark(6f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setMark(0f);
        }
    }
}
