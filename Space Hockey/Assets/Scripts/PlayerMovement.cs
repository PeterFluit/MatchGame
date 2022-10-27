//Code from Reso Coder https://www.youtube.com/watch?v=ZlAMVEVHkuI&list=PLB6lc7nQ1n4hLTDIPJiUD6OlBSNvtp7YP&index=1&ab_channel=ResoCoder

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool playerClicked = true;
    bool canMove;
    Vector2 playerSize;

    void Start()
    {
        playerSize = gameObject.GetComponent<SpriteRenderer>().bounds.extents;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (playerClicked)
            {
                playerClicked = false;


                if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
                     mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
                    (mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y) ||
                    mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y)
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

            if (canMove)
            {
                transform.position = mousePos;
            }
            else
            {
                playerClicked = true;
            }
        }
    }
}