using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb => GetComponent<Rigidbody2D>();
    public float acceleration = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        MoveBall(1, Random.Range(-1f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity *= acceleration;
    }

    public void ResetPos(bool isPlayer1Scored)
    {
        transform.position = Vector3.zero;
        if (isPlayer1Scored)
        {
            MoveBall(-1, Random.Range(-1f, 1f));
        }
        else
        {
            MoveBall(1, Random.Range(-1f, 1f));
        }
    }

    void MoveBall(float x, float y)
    {
        rb.velocity = new Vector2(x, y).normalized * GameManager.gameManager.ballSpeed;
    }
}
