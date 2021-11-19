using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    public float timerNumber;
    public bool timerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (timerOn)
        {
            timerNumber += Time.deltaTime;
            timer.text = timerNumber.ToString();
        }
        else
        {
            timer.text = "";
        }
    }

    public void StartTimer()
    {
        timerOn = true;
    }

    public void EndTimer()
    {

    }
}
