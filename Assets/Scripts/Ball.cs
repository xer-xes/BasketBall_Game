using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject Trail;
    
    void Start()
    {
        Trail.SetActive(false);
    }

    public void ActivateTrail()
    {
        Trail.SetActive(true);
    }
}
