using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckScript : MonoBehaviour
{
    ScoreScript ScoreScriptInstance;
    public static bool WasGoal { get; private set; }
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        WasGoal = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!WasGoal)
        {
            if (other.tag == "AiGoal")
            {
                ScoreScriptInstance.Increment(ScoreScript.Score.PlayerScore);
                WasGoal = true;
                StartCoroutine(ResetPuck());
            }
            else if (other.tag == "PlayerGoal")
            {
                ScoreScriptInstance.Increment(ScoreScript.Score.AiScore);
                StartCoroutine(ResetPuck());
            }
        }
    }

    private IEnumerator ResetPuck()
    {
        yield return new WaitForSecondsRealtime(1);
        WasGoal = false;
        rb.velocity = rb.position = new Vector2(0, 0);
    }
}

//Also make sure you CITE VIDEOS!!!!!!!!!