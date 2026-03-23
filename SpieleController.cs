
namespace wwmDev
{
    class SpieleController
    {
        int level=0;
        List<Question> meineQuestions;
        private Label labelFrage;
        private Button buttonAntwort1, buttonAntwort2, buttonAntwort3, buttonAntwort4;

        public SpieleController(object labelFrage, object buttonAntwort1, object buttonAntwort2, object buttonAntwort3, object buttonAntwort4) 
        {
            this.labelFrage = (Label)labelFrage;
            this.buttonAntwort1 = (Button)buttonAntwort1;
            this.buttonAntwort2 = (Button)buttonAntwort2;
            this.buttonAntwort3 = (Button)buttonAntwort3;
            this.buttonAntwort4 = (Button)buttonAntwort4;
            QuestionCollector qc1= new QuestionCollector();
            meineQuestions = new List<Question>();
            meineQuestions = qc1.getQuestions();
            this.nextQuestion(level);
        }
        
        public void nextQuestion(int level)
        {
            this.level = level;
            Thread.Sleep(1000);
            this.labelFrage.Text = meineQuestions[level].frage;
            this.buttonAntwort1.Text = meineQuestions[level].antwort1;
            this.buttonAntwort2.Text = meineQuestions[level].antwort2;
            this.buttonAntwort3.Text = meineQuestions[level].antwort3;
            this.buttonAntwort4.Text = meineQuestions[level].antwort4;
        }
        public int getResult(string anwserID)
        {
            int result = 0;
            int answer = 0;
            //Der übergeben String (Name des Buttons) wird geprüft
            if (anwserID == "buttonAntwort1") { answer = 1; }
            if (anwserID == "buttonAnwort2") { answer = 2; }
            if (anwserID == "buttonAnwort3") { answer = 3; }
            if (anwserID == "buttonAntwort4") { answer = 4; }
            if (meineQuestions[level].richtigeA == answer)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        public void nextLevel(int level) 
        {
            this.level = level;
            buttonAntwort1.Enabled = true;
            buttonAntwort2.Enabled = true;
            buttonAntwort3.Enabled = true;
            buttonAntwort4.Enabled = true;
            this.labelFrage.Text = meineQuestions[level].frage;
            this.buttonAntwort1.Text = meineQuestions[level].antwort1;
            this.buttonAntwort2.Text = meineQuestions[level].antwort2;
            this.buttonAntwort3.Text = meineQuestions[level].antwort3;
            this.buttonAntwort4.Text = meineQuestions[level].antwort4;
        }

        public void setJoker5050()
        {
            //Button b = (Button) sender;
            Random rnd = new Random();
            int zahl, ersterBtn =0, zweiterBtn=0; 
            bool fertig1 = false;
            bool fertig2 = false;
            //ersten Button auswählen

            while (!fertig1)
            {
                zahl = rnd.Next(4)+1;
                if (meineQuestions[level].richtigeA != zahl)
                {
                    ersterBtn = zahl;
                    
                    fertig1 = true;
                }
            }
            while (!fertig2)
            { 
                zahl = rnd.Next(4)+1;
                if (meineQuestions[level].richtigeA != zahl && zahl != ersterBtn)
                {
                    zweiterBtn = zahl;
                    fertig2 = true;
                }
            }
            switch (ersterBtn)
            {
                case 1: buttonAntwort1.Enabled = false;
                    break;
                case 2:
                    buttonAntwort2.Enabled = false;
                    break;
                case 3:
                    buttonAntwort3.Enabled = false;
                    break;
                case 4:
                    buttonAntwort4.Enabled = false;
                    break;
            }
            switch (zweiterBtn)
            {
                case 1:
                    buttonAntwort1.Enabled = false;
                    break;
                case 2:
                    buttonAntwort2.Enabled = false;
                    break;
                case 3:
                    buttonAntwort3.Enabled = false;
                    break;
                case 4:
                    buttonAntwort4.Enabled = false;
                    break;
            }

        }
        public void setJoker7525()
        {
            Random rnd = new Random();
            int zahl, ersterBtn = 0;
            bool fertig1 = false;
           
            //ersten Button auswählen

            while (!fertig1)
            {
                zahl = rnd.Next(4) + 1;
                if (meineQuestions[level].richtigeA != zahl)
                {
                    ersterBtn = zahl;

                    fertig1 = true;
                }
            }
            switch (ersterBtn)
            {
                case 1:
                    buttonAntwort1.Enabled = false;
                    break;
                case 2:
                    buttonAntwort2.Enabled = false;
                    break;
                case 3:
                    buttonAntwort3.Enabled = false;
                    break;
                case 4:
                    buttonAntwort4.Enabled = false;
                    break;
            }

        }
        public void skipJoker(int level)
        {
            if (level == 0)
            {
                this.nextLevel(1);

            }
        }
    }
}
