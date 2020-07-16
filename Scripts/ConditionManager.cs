using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConditionManager : MonoBehaviour
{
    public static int gameOver;
    private AudioSource music;
    public Animator animator;

    void Awake()
    {
        GameObject arrow = GameObject.Find("Spinning Arrow");
        music = arrow.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!music.isPlaying)
        {
            StartCoroutine(LoadHighScores());            
        }
    }

   IEnumerator LoadHighScores()
    {
        animator.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Highscore");
    }
}
