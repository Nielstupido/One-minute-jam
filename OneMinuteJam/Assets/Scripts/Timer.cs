using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    [SerializeField]private Text timerText;

    private GameManager gameManager;
    private int timerSec = 31;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        StartCoroutine("TimerSec");
    }

    IEnumerator TimerSec()
    {
        while(timerSec > 0)
        {
            if (timerSec == 5)
                gameManager.StartExplosionSFX();

            timerSec--;
            if(timerSec < 10)
                timerText.text = "0:0" + timerSec.ToString();
            else
                timerText.text = "0:" + timerSec.ToString();
            yield return new WaitForSeconds(1f);
        }
        gameManager.TimerEnded();

        timerSec = 10;
        while(timerSec > 0)
        {
            timerSec--;
            yield return new WaitForSeconds(1f);
        }
        gameManager.ShowEndScreen();
    }

}
