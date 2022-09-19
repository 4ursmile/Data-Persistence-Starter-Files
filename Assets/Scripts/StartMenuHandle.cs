using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartMenuHandle : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highscoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        MainGameManager.Instance.LoadHighScore();
        highscoreDisplay.text = "high score \n" + MainGameManager.Instance.HighScoreName + ": " +MainGameManager.Instance.HighScoreCount.ToString();
    }
    // Update is called once per frame
 
    public void StartPressed()
    {
        SceneManager.LoadScene(1);
    }
    public void EndPressed()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }
}
