
namespace wwmDev
{
    public partial class DialogNick : Form
    {
        public string nName => textBox1.Text;
        public DialogNick()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
