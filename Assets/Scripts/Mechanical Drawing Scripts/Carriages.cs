using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carriages : MonoBehaviour
{
    public float rot = -5.0f; //the rotating speed of carriages that are from Ferris Wheel Frame.
    //In reality, the carriages are always fixed, so in my codes, the opposite variable 'rot' value is needed.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rot * Time.deltaTime);
    }
}
