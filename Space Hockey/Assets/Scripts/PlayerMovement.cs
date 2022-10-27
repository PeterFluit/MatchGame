//Code from Reso Coder https://www.youtube.com/watch?v=ZlAMVEVHkuI&list=PLB6lc7nQ1n4hLTDIPJiUD6OlBSNvtp7YP&index=1&ab_channel=ResoCoder

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool playerClicked = true;
    bool canMove;
    Vector2 playerSize;

    public Transform BoundaryHolder;
    private Boundary playerBoundary;
    struct Boundary
    {
        public float Up, Down, Left, Right;

        public Boundary(float up, float down, float left, float right)
        {
            Up = up;
            Down = down;
            Left = left;
            Right = right;
        }
    }

    void Start()
    {
        playerSize = gameObject.GetComponent<SpriteRenderer>().bounds.extents;

        playerBoundary = new Boundary(BoundaryHolder.GetChild(0).position.y,
            BoundaryHolder.GetChild(1).position.y,
            BoundaryHolder.GetChild(2).position.x,
            BoundaryHolder.GetChild(3).position.x);

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
                Vector2 clampedMousePos = new Vector2(
                    Mathf.Clamp(mousePos.x, playerBoundary.Left, playerBoundary.Right),
                    Mathf.Clamp(mousePos.y, playerBoundary.Down, playerBoundary.Up));
                
                transform.position = clampedMousePos;
            }
            else
            {
                playerClicked = true;
            }
        }
    }
}