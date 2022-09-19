using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMainHandle : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highname;
    [SerializeField] Text bestScoreText;
    private void Start()
    {
        bestScoreText.text = "Best score: " + MainGameManager.Instance.HighScoreName + ": " + MainGameManager.Instance.HighScoreCount.ToString(); 
    }
    public void MenuPressed()
    {
        SceneManager.LoadScene(0);
    }
    public void SaveScorePressed()
    {
        MainGameManager.Instance.HighScoreName = highname.text;
        MainGameManager.Instance.SaveHighScore();
        SceneManager.LoadScene(1);
    }
}
