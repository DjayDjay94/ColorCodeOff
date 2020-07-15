using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class StartDelay : MonoBehaviour
{
    public GameObject arrow;
    public GameObject conditionManager;

    void Start()
    {
        arrow.gameObject.SetActive (false);
        conditionManager.gameObject.SetActive(false);
        StartCoroutine("GameDelay");
    }

    IEnumerator GameDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 5;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        arrow.gameObject.SetActive(true);
        conditionManager.gameObject.SetActive(true);
        Time.timeScale = 1;
    }
}
