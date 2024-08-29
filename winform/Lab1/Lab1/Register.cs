namespace Lab1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
         
            lg.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
