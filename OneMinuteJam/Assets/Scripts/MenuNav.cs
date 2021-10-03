using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{
    [SerializeField]private GameObject instructionsWindow;
    [SerializeField]private GameObject mainMenuWindow;
    [SerializeField]private GameObject screen;
    [SerializeField]private CanvasGroup coverScreen;
    [SerializeField]private float targetXpos = -647;

    public void OpenPlay()
    {
        coverScreen.gameObject.SetActive(true);
        mainMenuWindow.SetActive(false);
        
        screen.LeanMoveLocalX(targetXpos, 3f);
        screen.LeanScaleX(1f, 5f);
        screen.LeanScaleY(1f, 5f);

        coverScreen.LeanAlpha(1f, 1f).setOnComplete(OpenGameScene).delay = 1f;
    }

    void OpenGameScene()
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
