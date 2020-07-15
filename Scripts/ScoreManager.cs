using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    public AudioSource fasterPitch;
    public GameObject fasterArrow;

    void Start()
    {
        score = GetComponent<Text>();
        fasterPitch.GetComponent<AudioSource>();   
    }

    void Update()
    {
        score.text = "Points " + scoreValue;

        if (scoreValue >= 350000)
        {
            fasterPitch.pitch += 0.35f;
            fasterPitch.pitch = Mathf.Clamp(fasterPitch.pitch, 1f, 1.35f);

            BeatScroller beatScroller = fasterArrow.GetComponent<BeatScroller>();
            beatScroller.beatsPerLoop -= 1f;
            beatScroller.beatsPerLoop = Mathf.Clamp(beatScroller.beatsPerLoop, 2.8f, 3.8f);
        }
    }
}
