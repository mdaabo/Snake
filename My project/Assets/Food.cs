using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    //variable
    public BoxCollider2D grid;



    void Start()
    {
        
    }

    // Update is called once per frame
    
    void RandomPos()
    {
        Bounds bounds = grid.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        transform.position = new Vector2(Mathf.Round(x), Mathf.Round(y));
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        RandomPos();
    }


}
