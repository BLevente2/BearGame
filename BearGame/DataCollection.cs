using MathNet.Numerics.Statistics;
using System.Text.Json;

namespace BearGame;

class DataCollection
{

    public static string DEFAULT_JSON_FILE_PATH = "data.json";

    public GameStatistics GameStatistics { get; set; }

    public string JsonFilePath { get; set; }

    public DataCollection(GameStatistics statistics)
    {
        GameStatistics = statistics;
        JsonFilePath = DEFAULT_JSON_FILE_PATH;
    }

    public DataCollection()
    {
        GameStatistics = new GameStatistics(0, 0);
        JsonFilePath = DEFAULT_JSON_FILE_PATH;
    }

    public void SaveGameStatistics()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(GameStatistics, options);
        File.WriteAllText(JsonFilePath, jsonString);
    }

    public void LoadGameStatistics()
    {
        if (File.Exists(JsonFilePath) == false)
        {
            throw new Exception("File does not exist");
        }

        string jsonString = File.ReadAllText(JsonFilePath);

        GameStatistics? statistics = JsonSerializer.Deserialize<GameStatistics>(jsonString);

        if (statistics == null)
        {
            throw new Exception("Failed to deserialize JSON");
        }
        GameStatistics = statistics;
    }
}