using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoints : MonoBehaviour
{
    void Update()
    {
        ScoreManager.scoreValue += 10000;
    }
}
