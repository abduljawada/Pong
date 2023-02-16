using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isGoal1 = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.gameManager.ChangeScore(!isGoal1);
    }
}
