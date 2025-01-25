using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Things : MonoBehaviour
{
    public bool isFired = false;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFired)
        {
            //Vector2 pos = transform.position;
            //pos.y += speed + Time.deltaTime;
            //transform.position = pos;

            //transform.position += Vector3.up * speed * Time.deltaTime;
            transform.position += transform.up * speed * Time.deltaTime;
        }
        else
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = mousePos - (Vector2)transform.position;

            transform.up = direction;
        }
    }

    public void Bye()
    {
        transform.parent = null;
        Destroy(gameObject, 5);
    }

    public void Fire()
    {
        isFired = true;
        Bye();
    }
}
