using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    public GameObject anim;
    public BarHandler winPoints;
    //bool triggerWorks;

    void Start()
    {
        StartCoroutine(fuckyou());
    }

    //void OnTriggerStay2D(Collider2D collision)
    //{
    //    triggerWorks = true;
    //}

    //void OnTriggerExit2D(Collider2D collision)
    //{
    //    triggerWorks = false;
    //}

    void Update ()
    {
        //if (triggerWorks)
        if (Input.GetKeyDown("space"))
        {
            switch (gameObject.tag)
            {
                case "PerfectPressed":
                    {
                        winPoints.health += 0.2f;
                        anim.GetComponent<Animation>().Play("Perfect");
                    }
                    break;

                case "Pressed":
                    {
                        winPoints.health += 0.1f;
                    }
                    break;

                case "Missed":
                    {
                        
                    }
                    break;
            }
        }


            //yield return new WaitForFixedUpdate();
      
        //if (Input.GetKeyDown("space") && gameObject.tag == "Missed")
        //{
        //    winPoints.health -= 0.03f;
        //}

    }

    IEnumerator fuckyou()
    {
        yield return new WaitForFixedUpdate();
    }
}
