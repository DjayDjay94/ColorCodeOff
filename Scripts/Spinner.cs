using System;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public Material[] colorMaterials;
    public SpriteRenderer renderer;
    private int index;
    public BarHandler winPoints;
    public AnimationController PerfectHit;
    public AnimationController GoodHit;
    public AnimationController BadHit;

    void Update()
    {
        if (colorMaterials.Length == 0)
        {
            return;
        }

       if (Input.GetKeyDown("space"))
       {
            //Scoring bit
            float targetAngle = 0f;

            if (renderer.material.name == "Arrow_Red (Instance)")
            {
                targetAngle = 45;
            }

            if (renderer.material.name == "Arrow_Yellow (Instance)")
            {
                targetAngle = 135;
            }

            if (renderer.material.name == "Arrow_Blue (Instance)")
            {
                targetAngle = 225;
            }

            if (renderer.material.name == "Arrow_Green (Instance)")
            {
                targetAngle = 315;
            }

            float angleDiff = Mathf.Abs(targetAngle - transform.rotation.eulerAngles.z);

            if (angleDiff < 5)
            {
                winPoints.health += 0.05f;
                GoodHit.GetComponentInChildren<Animation>().Stop();
                PerfectHit.GetComponentInChildren<Animation>().Play();
                ScoreManager.scoreValue += 500;
                CountManager.perfectCount += 1;
            }
            else if (angleDiff < 30)
            {
                winPoints.health += 0.03f;
                GoodHit.GetComponentInChildren<Animation>().Play();
                ScoreManager.scoreValue += 200;
                CountManager.goodCount += 1;
            }

            else
            {
                winPoints.health -= 0.05f;
                BadHit.GetComponentInChildren<Animation>().Play();
                ScoreManager.scoreValue -= 200;
                CountManager.missedCount += 1;
            }

            index = UnityEngine.Random.Range(0, colorMaterials.Length);
            index += 1; // Go through the colors in index one by one
            if (index == colorMaterials.Length) // If all the colors in the list were used
            {
                index = 1; //Back to the start and repeat
            }

            renderer.sharedMaterial = colorMaterials[index - 1]; // sets the material value colors inside the index 

        }

    }   
}
