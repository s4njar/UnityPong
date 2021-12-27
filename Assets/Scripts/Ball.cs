using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    [SerializeField] int _speed;
    private Vector2 defaultPos;
    void Start()
    {
        defaultPos = this.transform.position;
        ResetBall();
    }

    public void ResetBall()
    {
        this.transform.position = defaultPos;
        GetComponent<Rigidbody2D>().velocity = new Vector2();
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        var x = Random.Range(0, 2) == 0 ? 1 : -1;
        var y = Random.Range(0, 2) == 0 ? 1 : -1;

        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(_speed * x, _speed * y));
    }
}
