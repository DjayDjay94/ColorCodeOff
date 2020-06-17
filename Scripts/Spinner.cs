using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Collections.Specialized;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class Spinner : MonoBehaviour
{
    Vector3 startPosition;

    public Material[] colorMaterials;
    public GameObject[] colorTriggers;
    public SpriteRenderer renderer;
    private int index;

    void Start()
    {
        startPosition = transform.position;       
    }

    void Update()
    {
        if (colorMaterials.Length == 0)
        {
            return;
        }

       if (Input.GetMouseButtonDown(0))
       {
            index = UnityEngine.Random.Range(0, colorMaterials.Length);
            index += 1; // Go through the colors in index one by one
            if (index == colorMaterials.Length) // If all the colors in the list were used
                {
                    index = 1; //Back to the start and repeat
                }

            renderer.sharedMaterial = colorMaterials[index - 1]; // sets the material value colors inside the index 
        }

       if (renderer.material.name == "Arrow_Red (Instance)")
       {
            colorTriggers[0].SetActive(true);
            for (int i = 0; i < colorMaterials.Length; i++)
            {
                colorTriggers[1].SetActive(false);
                colorTriggers[2].SetActive(false);
                colorTriggers[3].SetActive(false);
            }            
       }

        if (renderer.material.name == "Arrow_Yellow (Instance)")
        {
            colorTriggers[1].SetActive(true);
            for (int i = 0; i < colorMaterials.Length; i++)
            {
                colorTriggers[0].SetActive(false);
                colorTriggers[2].SetActive(false);
                colorTriggers[3].SetActive(false);
            }
        }

        if (renderer.material.name == "Arrow_Blue (Instance)")
        {
            colorTriggers[2].SetActive(true);
            for (int i = 0; i < colorMaterials.Length; i++)
            {
                colorTriggers[0].SetActive(false);
                colorTriggers[1].SetActive(false);
                colorTriggers[3].SetActive(false);
            }
        }

        if (renderer.material.name == "Arrow_Green (Instance)")
        {
            colorTriggers[3].SetActive(true);
            for (int i = 0; i < colorMaterials.Length; i++)
            {
                colorTriggers[0].SetActive(false);
                colorTriggers[1].SetActive(false);
                colorTriggers[2].SetActive(false);
            }
        }

    }
    
}
