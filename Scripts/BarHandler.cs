using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarHandler : MonoBehaviour
{
    public static BarHandler instance;
    public RainbowBar rainbowBar;
    public float health = 0.5f;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine(decreasingBar());
    }

    private void Update()
    {
        if (health > 0)
        {
            health -= 0.01f * Time.deltaTime;
            rainbowBar.SetSize(health);
        }
    }
    IEnumerator decreasingBar()
    {

        yield return new WaitForSeconds(1f);

    }
}
