using static System.Windows.Forms.DataFormats;

namespace karar12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            if (ses == 0)
            {
                label1.Text = "ses yok"; label1.ForeColor = Color.Black;
            }
            if (ses > 0 && ses <= 10)
            {
                label1.Text = "normal ses seviyesi"; label1.ForeColor = Color.Green;
            }
            if (ses >= 11)
            {
                label1.Text = "yüksek ses seviyesi"; label1.ForeColor = Color.Red;
            }
        }
    }
}