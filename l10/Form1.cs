namespace l10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.Trim();

            label2.Text = SayHelloTo(name);
        }
        private String SayHelloTo(String name)
        {
            return "Hello, " + name;
        }
    }
}
