using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncedRotation : MonoBehaviour
{
    void Update()
    {
        this.gameObject.transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0, 360, BeatScroller.instance.loopPositionInAnalog));
    }
}
