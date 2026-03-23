using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwmDev
{
    public class QuestionCollector
    {

        public List<Question> getQuestions()
        {
            List<Question> tempListeJS = new List<Question>();
            List<Question> returnListeJS = new List<Question>();
            Random rnd = new Random();
            int zahl;
            int zahlOffset = 0;

            Question frage = new Question();
            string jsonString = File.ReadAllText("wwm.json");

            for (int i = 0; i <= 3; i++)
            {
                tempListeJS.Clear();
                for (int z = 0; z <= 2; z++)
                {

                    frage = new Question();
                    frage = JsonConvert.DeserializeObject<List<Question>>(jsonString)[zahlOffset + z]; //Lies aus JSON-Datei die Fragen ein, als Dreierblock  mit offset
                    tempListeJS.Add(frage);
                }
                zahlOffset = zahlOffset + 3;
                zahl = rnd.Next(3);
                returnListeJS.Add(tempListeJS[zahl]);
            }


            return returnListeJS; 
        }
    }
}
