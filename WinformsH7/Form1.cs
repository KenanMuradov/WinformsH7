namespace WinformsH7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File|*.txt";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using StreamReader sr = new(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
            }

            
        }
    }
}