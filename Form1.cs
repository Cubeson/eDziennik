namespace edziennik
{
    public partial class Form1 : Form
    {
        public static Panel FullPanel { get; private set; }
        public static CurrentUser currentUser { get; set; }

        public Form1()
        {
            InitializeComponent();
            FullPanel = panel1;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var isConnected = DB.CheckDB();
            if (!isConnected)
            {
                MessageBox.Show("Brak po³¹czenia z baz¹ danych, aplikacja zostanie zatrzymana");
                this.Close();
                return;
            }
            panel1.Controls.Add(new LoginUC());
        }
    }
}