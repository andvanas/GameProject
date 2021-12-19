using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    public float timerNumber;
    public GameObject start;
    public GameObject finish;

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    public void Update()
    {
        timerNumber += Time.deltaTime;
        timer.text = timerNumber.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("start"))
        {
            timerNumber += Time.deltaTime;
            timer.text = timerNumber.ToString();
        }
        else if(other.gameObject.CompareTag("finish"))
        {
            timer.text = timerNumber.ToString();
        }
    }
}
