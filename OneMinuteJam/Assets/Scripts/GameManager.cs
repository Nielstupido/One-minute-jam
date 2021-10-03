using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]private GameObject gameScreen;
    [SerializeField]private GameObject connectionLostSreen;
    [SerializeField]private GameObject tv;
    [SerializeField]private CanvasGroup explosionScreen;
    [SerializeField]private CanvasGroup endScreen;
    [SerializeField]private AudioSource explosion;

    public void TimerEnded()
    {
        gameScreen.SetActive(false);
        connectionLostSreen.SetActive(true);
        tv.SetActive(false);
        explosionScreen.LeanAlpha(1f, 3f).delay = 5f;
    }

    public void StartExplosionSFX()
    {
        explosion.Play();
    }

    public void ShowEndScreen()
    {
        endScreen.LeanAlpha(1f, 4f).setOnComplete(BackToMenu);
    }

    void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
