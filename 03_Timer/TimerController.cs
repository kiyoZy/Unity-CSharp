using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public float totalTime;
//    float saveTotalTime;
    int seconds;

    bool startFlag;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        startFlag = false;
//        saveTotalTime = totalTime.getvalue;
    }

    // Update is called once per frame
    void Update()
    {
        if(0 <= totalTime && startFlag == true)
        {
            totalTime -= Time.deltaTime;
            seconds = (int)totalTime;
            timerText.text = seconds.ToString();        
        }
    }
        public void ClickStartButton()
    {
        Debug.Log("StartButton押した");
        startFlag = true;
    }

    public void ClickStopButton ()
    {
        Debug.Log("Stopボタン押した");
        startFlag = false;
    }

    public void ClickResetButton ()
    {
        Debug.Log("Resetボタン押した");
        totalTime = 6;
        timerText.text = totalTime.ToString();
    }

}
