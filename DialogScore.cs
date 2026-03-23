
namespace wwmDev
{
    public partial class DialogScore : Form
    {
        public DialogScore()
        {
            InitializeComponent();
            foreach (var item in ScoreCollector.GetAllPlayers())
            {
                listBoxScore.Items.Add(item.Name + " - " + item.HighScore);
            }
        }
    }
}
