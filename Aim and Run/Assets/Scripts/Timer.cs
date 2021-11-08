using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    public float timerNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerNumber += Time.deltaTime;
        timer.text = timerNumber.ToString();
    }
}
