namespace wwmDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpielStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSpiel FormSpiel = new FormSpiel();
            FormSpiel.ShowDialog();
            this.Show();
        }
    }
}
