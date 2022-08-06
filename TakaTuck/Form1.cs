namespace TakaTuck
{
    public partial class TukaTuck : Form
    {
        public TukaTuck()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TukaTuck_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {
            Form frm_Form2 = new Order_Form();
            frm_Form2.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult iexit;
            iexit = MessageBox.Show("Confirm you want to exit the system.","Ordering system" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}