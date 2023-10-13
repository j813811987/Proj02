using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : GameItem
{
    Vector2 v;
    // Start is called before the first frame update

    private void Awake()
    {
    }
    void Start()
    {
        v = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            v = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            v = Vector2.right;
        }
        transform.position = new Vector3(x + v.x, y + v.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        v = Vector2.zero;
    }
}
