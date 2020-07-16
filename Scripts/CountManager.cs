using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CountManager : MonoBehaviour
{
    public static int goodCount = 0;
    public static int missedCount = 0;
    public static int perfectCount = 0;
    public Text count;

    void Start()
    {
        count = GetComponent<Text>();

        perfectCount = GlobalControl.Instance.Perfect;
        goodCount = GlobalControl.Instance.Good;
        missedCount = GlobalControl.Instance.Missed;
    }

    void Update()
    {
        if (this.gameObject.name == "GoodText")
        {
            count.text = "Good: " + goodCount;
            GlobalControl.Instance.Good = goodCount;
        }

        if (this.gameObject.name == "MissedText")
        {
            count.text = "Missed: " + missedCount;
            GlobalControl.Instance.Missed = missedCount;
        }

        if (this.gameObject.name == "PerfectText")
        {
            count.text = "Perfect: " + perfectCount;
            GlobalControl.Instance.Perfect = perfectCount;
        }
    }
}
