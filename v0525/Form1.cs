namespace v0525
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"����ɂ���{textBox1.Text}����");
            label1.Text = "Hello";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 5;
            label1.Left -= 5;
            
        }
    }
}