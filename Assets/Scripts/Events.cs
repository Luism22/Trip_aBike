using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private bool isPaused = false; // Variable para rastrear si el juego está pausado.

    public void ReplayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        // Pausar el juego.
        Time.timeScale = 0; // Esto detendrá la simulación del tiempo, haciendo que el juego se pause.
        isPaused = true;
    }

    public void ContinueGame()
    {
        // Continuar el juego si está pausado.
        if (isPaused)
        {
            Time.timeScale = 1; // Restablecer la simulación del tiempo a 1 para reanudar el juego.
            isPaused = false;
        }
    }
}
