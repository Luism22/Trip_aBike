using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class RankingMenu : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI gemsText;
    public Animator messageAnim;

    private void Start()
    {
        Time.timeScale = 1;
    }


    /*
    public void PlayMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public void RankingMenu()
    {
        SceneManager.LoadScene("Ranking");
    }
    */

    public void HomeMenu()
    {
        SceneManager.LoadScene("Home");
    }

}
