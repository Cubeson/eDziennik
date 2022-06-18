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
    public record CurrentUser
    {
        public int Id { get;set;}
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public CurrentUser(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
    public partial class MainUC : UserControl
    {
        public MainUC(CurrentUser user)
        {
            Form1.currentUser = user;
            InitializeComponent();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new AddStudentTaskUC());
        }

        private void AddStudentTaskUCButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new AddStudentTaskUC());
        }

        private void MarksUCButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new MarksUC());
        }
        private void tmpUCButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new AttendanceUC());
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1.FullPanel.Controls.Clear();
            Form1.FullPanel.Controls.Add(new LoginUC());
        }

        private void ToolbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
