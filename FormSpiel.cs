
namespace wwmDev
{
    public partial class FormSpiel : Form
    {
        SpieleController meinSpiel;
        int level = 0;
        string nName;
        public FormSpiel()
        {
            InitializeComponent();
            buttonAntwort1.BackColor = Color.LightGray;
            buttonAnwort2.BackColor = Color.LightGray;
            buttonAnwort3.BackColor = Color.LightGray;
            buttonAntwort4.BackColor = Color.LightGray;
        }
        private void FormSpiel_Load(object sender, EventArgs e)
        {
            DialogNick nNameDialog = new DialogNick();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (nNameDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.nName = nNameDialog.nName;
            }
            else
            {
                this.nName = "unknown";
            }
            ScoreCollector.CreatePlayer(this.nName);
            nNameDialog.Dispose();
            nNameDialog.Text = nName;
            labelNickName.Text = nName;
            buttonJocker7525.Enabled = false;
            buttonJoker5050.Enabled = false;
            buttonSkip.Enabled = false;

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {

            meinSpiel = new SpieleController(labelFrage, buttonAntwort1, buttonAnwort2, buttonAnwort3, buttonAntwort4);
            buttonStart.Enabled = false;
            buttonJocker7525.Enabled = true;
            buttonJoker5050.Enabled = true;
            buttonSkip.Enabled = true;
        }
        private void buttonAuswertung(object sender, EventArgs e)
        {
            int right;
            DialogResult result;
            Button b = (Button)sender;
            right = this.meinSpiel.getResult(b.Name); // Der Methode getResult wir der Button-Name übergeben, der den Klick ausgelöst hat
            //Frage falsch beantwortet
            if (right == 0)
            {
                b.BackColor = Color.Red;
                result = MessageBox.Show("Leider falsch. Das Siel wird beednet", "Spielergebnis", MessageBoxButtons.OK);
                meinSpiel = null;
                this.Close();
            }
            //Frage richtig beantwortet
            if (right == 1)
            {
                b.BackColor = Color.Lime;
                this.setMoney(this.level);
                result = MessageBox.Show("Das war richtig. Wollen Sie das Spiel fortsetzen?", "Spielergebnis", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (level < 3)
                    {
                        switch (level)
                        {
                            case 1:
                                ScoreCollector.EditScore(this.nName, 200);
                                break;
                            case 2:
                                ScoreCollector.EditScore(this.nName, 1000);
                                break;
                            default:
                                ScoreCollector.EditScore(this.nName, 50);
                                break;
                        }
                        level++;
                        buttonAntwort1.BackColor = Color.LightGray;
                        buttonAnwort2.BackColor = Color.LightGray;
                        buttonAnwort3.BackColor = Color.LightGray;
                        buttonAntwort4.BackColor = Color.LightGray;
                        meinSpiel.nextLevel(level);
                    }
                    else
                    {
                        MessageBox.Show("Sie sind Millionär. Der Highscore wird eingetragen", "Spielergebnis", MessageBoxButtons.OK);
                        meinSpiel = null;
                        ScoreCollector.EditScore(this.nName, 5000);
                        this.Close();
                    }

                }

            }

        }
        private void setMoney(int level)
        {
            checkedListBox1.SetItemCheckState((3 - level), CheckState.Checked);
        }

        private void buttonJoker5050_Click(object sender, EventArgs e)
        {
            buttonJoker5050.Enabled = false;
            meinSpiel.setJoker5050();
        }

        private void buttonJocker7525_Click(object sender, EventArgs e)
        {
            buttonJocker7525.Enabled = false;
            meinSpiel.setJoker7525();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            buttonSkip.Enabled = false;
            meinSpiel.skipJoker(level);
        }
    }
}
