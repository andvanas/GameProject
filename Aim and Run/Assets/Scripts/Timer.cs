using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    public float timerNumber;
    public bool timerOn;
    public GameObject start;
    public GameObject finish;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = false;   
    }

    // Update is called once per frame
    public void Update()
    {
        if (timerOn == true)
        {
            timerNumber += Time.deltaTime;
            timer.text = timerNumber.ToString();
        }
        else
        {
            timer.text = "";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        timerOn = true;
    }
}
