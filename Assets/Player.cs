using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1 = true;
    public float yLimit = 4.25f;
    Rigidbody2D rb;
    GameManager gameManager;
    float inputAxis;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameManager.gameManager;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            inputAxis = Input.GetAxisRaw("Vertical");
        }
        else
        {
            inputAxis = Input.GetAxisRaw("Vertical2");
        }
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, inputAxis, 0) * gameManager.playerSpeed * Time.deltaTime;

        if (transform.position.y > yLimit)
        {
            transform.position = new Vector2(transform.position.x, yLimit);
        }
        else if (transform.position.y < -yLimit)
        {
            transform.position = new Vector2(transform.position.x, -yLimit);
        }
    }

    public void ResetPos()
    {
        transform.position = new Vector3(transform.position.x, 0);
    }
}
