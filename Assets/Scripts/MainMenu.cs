using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI gemsText;
    public Animator messageAnim;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        highScoreText.text = "High Score\n" + PlayerPrefs.GetInt("HighScore", 0);
        gemsText.text = PlayerPrefs.GetInt("TotalGems", 0).ToString();
    }

    public void PlayGameEasy()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PlayGameMedium()
    {
        SceneManager.LoadScene("Level2");
    }

    public void PlayGameHard()
    {
        SceneManager.LoadScene("Level3");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
