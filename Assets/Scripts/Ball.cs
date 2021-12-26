using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500, 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
