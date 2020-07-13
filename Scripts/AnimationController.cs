using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static AnimationController instance;
    public Animation anim;

    void Awake()
    {
        instance = this;
    }
}
