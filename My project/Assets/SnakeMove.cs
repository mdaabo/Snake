using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    private Vector2 direction;



    //body


    // Start is called before the first frame update
    void Start()
    {
        //body
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;

        }

        else if (Input.GetKeyDown(KeyCode.S))

        {
            direction = Vector2.down;

        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
        }



    }

        void FixedUpdate() { 
        transform.position = new Vector2
            (Mathf.Round(transform.position.x) + direction.x,
            Mathf.Round(transform.position.y) + direction.y);
    }
}
