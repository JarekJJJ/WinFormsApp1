namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string lablelText {
            get { return label1.Text; }
            set { label1.Text = value; } 
        }
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            BleBle ble = new BleBle();
            ble.form2Changer(this);        }
    }
}
