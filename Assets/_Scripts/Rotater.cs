using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotater : MonoBehaviour
{
    public SpriteRenderer sr;
    private int rotate;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rotate = Random.Range(1, 4);
        if (rotate == 1 )
        {
            sr.flipY = true;
        }
        else if (rotate == 2 )
        {
            sr.flipX = true;
        }
        else if(rotate == 3 )
        {
            sr.flipX = true;
            sr.flipY = true;
        }
        else
        {
            return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
