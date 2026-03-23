using System.Text.Json;

namespace wwmDev
{
    public class ScoreCollector
    {
        private static readonly string saveFilePath = Path.Combine(AppContext.BaseDirectory, "score.json");

        public static List<Score> GetAllPlayers()
        {
            if (!File.Exists(saveFilePath))
            {
                return new List<Score>();
            }

            try
            {
                string json = File.ReadAllText(saveFilePath);
                return JsonSerializer.Deserialize<List<Score>>(json) ?? new List<Score>();
            }
            catch
            {
                return new List<Score>();
            }
        }
        public static bool CreatePlayer(string pName)
        {
            try
            {
                var players = GetAllPlayers();
                if (players.Any(p => p.Name == pName))
                {
                    return false;
                }
                var newPlayer = new Score
                {
                    Name = pName,
                    HighScore = 0
                };
                players.Add(newPlayer);
                SaveAllPlayers(players);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool EditScore(string playerName, int score)
        {
            try
            {
                var players = GetAllPlayers();
                var playerIndex = players.FindIndex(p => p.Name == playerName);
                if (playerIndex >= 0)
                {
                    players[playerIndex] = new Score
                    {
                        Name = playerName,
                        HighScore = score
                    };
                    SaveAllPlayers(players);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private static void SaveAllPlayers(List<Score> players)
        {
            try
            {
                string directory = Path.GetDirectoryName(saveFilePath);
                if (!Directory.Exists(directory) && !string.IsNullOrEmpty(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(players, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(saveFilePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving players: {ex.Message}");
            }
        }
    }
}