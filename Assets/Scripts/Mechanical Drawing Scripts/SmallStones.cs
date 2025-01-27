using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SmallStones : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        transform.localScale = Vector2.one * curve.Evaluate(t) * Time.deltaTime * 50;
        if(t >= 1)
        {
            t = 0;
        }
    }
}
