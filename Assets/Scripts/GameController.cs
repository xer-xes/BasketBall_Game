using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player Player;
    public float ResetTime = 5f;

    void Update()
    {
        if(Player.HoldingBall == false)
        {
            ResetTime -= Time.deltaTime;
            if(ResetTime <= 0)
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
}
