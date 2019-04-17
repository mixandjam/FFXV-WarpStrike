using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{

    WarpController warp;

    void Start()
    {
        warp = FindObjectOfType<WarpController>();
    }

    private void OnBecameVisible()
    {
        if (!warp.screenTargets.Contains(transform))
            warp.screenTargets.Add(transform);
    }

    private void OnBecameInvisible()
    {
        if(warp.screenTargets.Contains(transform))
            warp.screenTargets.Remove(transform);
    }
}
