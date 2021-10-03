using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{
    public void OpenPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenInstructions()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
