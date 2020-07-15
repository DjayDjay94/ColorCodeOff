using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarHandler : MonoBehaviour
{
    public static BarHandler instance;
    public RainbowBar rainbowBar;
    public float health = 0.5f;
    public GameObject theArrow;
    public Animation bonus;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine(decreasingBar());
        theArrow.GetComponent<Spinner>().enabled = true;
    }

    private void Update()
    {
        if (health > 0)
        {
            health -= 0.02f * Time.deltaTime;
            rainbowBar.SetSize(health);
        }

        if (health <= 0)
        {
            theArrow.GetComponent<Animation>().Play();
            theArrow.GetComponent<Spinner>().enabled = false;
        }

        if (health >= 1)
        {
            bonus.GetComponent<Animation>().Play();
            health = 0.5f;         
        }
    }

    IEnumerator decreasingBar()
    {

        yield return new WaitForSeconds(1f);

    }
}
