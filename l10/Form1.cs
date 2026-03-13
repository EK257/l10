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
            label1.Text = SayHelloTo("Tom") + "\n" + SayHelloTo("Bob") + "\n" + SayHelloTo("Alice");
        }
        private String SayHelloTo(String name)
        {
            return "Hello, " + name;
        }
    }
}
