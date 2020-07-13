using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RainbowBar : MonoBehaviour
{
    public Transform bar; 

    public void Start()
    {
        bar = transform.Find("Bar");
    }

    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(1f, sizeNormalized);
    }

    public void SetColor(Color color)
    {
        bar.Find("Bar Sprite").GetComponent<SpriteRenderer>().color = color;
    }
}
