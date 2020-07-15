using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConditionManager : MonoBehaviour
{
    public static int gameOver;
    public AudioSource music;

    void Update()
    {
        if (!music.isPlaying)
        {
            SceneManager.LoadScene("Highscore");
        }
    }
}
