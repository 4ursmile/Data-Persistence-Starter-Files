using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    public static MainGameManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public string HighScoreName = "Ly";
    public int HighScoreCount = 0;
    [System.Serializable]
    public class SaveData
    {
        public string PlayerName;
        public int HighScore;
    }
    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.PlayerName = HighScoreName;
        data.HighScore = HighScoreCount; 
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string  json =  File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            HighScoreName = data.PlayerName;
            HighScoreCount = data.HighScore;
        }
    }
}
