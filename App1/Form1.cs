using GlobalData;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReadStr_Click(object sender, EventArgs e)
        {
            TxtHello.Text = ShareData.Hello;
        }

        private void BtnWriteStr_Click(object sender, EventArgs e)
        {
            ShareData.Hello = TxtHello.Text;
        }
    }
}
