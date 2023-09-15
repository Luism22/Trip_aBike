using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level");
    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
