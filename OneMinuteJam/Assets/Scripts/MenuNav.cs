using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{
    [SerializeField]private GameObject instructionsWindow;
    [SerializeField]private GameObject mainMenuWindow;

    public void OpenPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenInstructions()
    {
        instructionsWindow.SetActive(true);
        mainMenuWindow.SetActive(false);
    }

    public void BackToMain()
    {
        instructionsWindow.SetActive(false);
        mainMenuWindow.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
