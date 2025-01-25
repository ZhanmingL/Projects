using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHero : MonoBehaviour
{
    public float speed = 5;
    public GameObject thingPrefab;
    public Things currentThing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space) && currentThing == null)
        {
            //GameObject newThing = Instantiate(thingPrefab, transform);
            GameObject newThing = Instantiate(thingPrefab, transform.position, transform.rotation);
            newThing.transform.parent = transform;

            currentThing = newThing.GetComponent<Things>();
        }

        if (Input.GetMouseButtonDown(0) && currentThing != null)
        {
            currentThing.Fire();
            currentThing = null;
        }
    }
}
