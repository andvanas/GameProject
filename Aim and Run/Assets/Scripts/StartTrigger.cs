using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject hitObj = other.gameObject;
        Timer _timer;

        if(hitObj.tag == "Player")
        {
            //_timer.timerOn = true;

        }
    }
}
