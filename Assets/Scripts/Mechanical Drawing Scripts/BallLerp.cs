using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallLerp : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;
    public Transform start; //the start point of ball sliding.
    public Transform end; //the end point, make these two points public,

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime; //adding t value automatically.
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t)); //I get my start and end point, now I can do evaluate t time to move by deltatime.
        if (t > 1)
        {
            t = 0; //it's part of my drawing, so I want to repeat this object all the time, t back to initial point, and keep doing this curve codes
        }
    }
}
//this is the magic ball sliding from a incline