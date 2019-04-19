using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject ScoreEffect;
    // Start is called before the first frame update
    void Start()
    {
        ScoreEffect.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Ball>() != null)
        {
            ScoreEffect.SetActive(true);
        }
    }
}
