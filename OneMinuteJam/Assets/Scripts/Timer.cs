using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    [SerializeField]private Text timerText;
    private int timerSec = 31;

    void Start()
    {
        StartCoroutine("TimerSec");
    }

    IEnumerator TimerSec()
    {
        while(timerSec > 0)
        {
            timerSec--;
            if(timerSec < 10)
                timerText.text = "0:0" + timerSec.ToString();
            else
                timerText.text = "0:" + timerSec.ToString();
            yield return new WaitForSeconds(1f);
        }
    }

}
