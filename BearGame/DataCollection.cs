﻿using MathNet.Numerics.Statistics;
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

    public int[] GetTotalKnockOuts()
    {
        int[] kos = new int[GameStatistics.NumberOfPlayers];

        foreach (MatchStatistics match in GameStatistics.MatchStatistics)
        {
            for (int i = 0; i < GameStatistics.NumberOfPlayers; i++)
            {
                kos[i] += match.NumberOfTimesKnockedOutAPlayer[i];
            }
        }  
        return kos;
    }

    public int[] TotalNumberOfTimesBeenKOd()
    {
        int[] kos = new int[GameStatistics.NumberOfPlayers];

        foreach (MatchStatistics match in GameStatistics.MatchStatistics)
        {
            for (int i = 0; i < GameStatistics.NumberOfPlayers; i++)
            {
                kos[i] += match.NumberOfTimesBeenKnockedOut[i];
            }
        }
        return kos;
    }

    public int[] GetNumberOfCictories()
    {
        int[] counter = new int[GameStatistics.NumberOfPlayers];

        foreach (MatchStatistics match in GameStatistics.MatchStatistics)
        {
            counter[match.PlayerFinishOrder[0]]++;
        }
        return counter;
    }

    public double[] GetNumOfRounds()
    {
        double[] numOfRounds = new double[GameStatistics.MatchStatistics.Count];
        for (int i = 0; i < numOfRounds.Length; i++)
        {
            numOfRounds[i] = GameStatistics.MatchStatistics[i].TotalNumberOfRounds;
        }
        return numOfRounds;
    }


}