using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    public GameObject anim;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Arrow")
        {
            print("Entered trigger");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.GetComponent<Animation>().Play("Perfect");
            print("Anim is played");
        }
    }
}
