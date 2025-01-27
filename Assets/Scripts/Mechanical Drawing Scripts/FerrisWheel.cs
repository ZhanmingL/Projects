using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheel : MonoBehaviour
{
    public float SpinSpeed = 5.0f; //The rotating speed of Ferris Wheel Frame.
    //This object is the "parent", so that it rotates the different direction as carriages.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, SpinSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            SpinSpeed += 5.0f; //If we press mouseLeftButton, add speed of counterClockWise.
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpinSpeed -= 5.0f; //If we press SpaceKey once, add speed of ClockWise which is opposite speed.
        }
    }
}
//Frame of Ferris wheel, it's the parent of carriages.