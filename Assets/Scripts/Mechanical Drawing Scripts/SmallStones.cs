using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SmallStones : MonoBehaviour
{
    [Range(0, 1)] //let t value constrained in 0 to 1.
    public float t;
    public AnimationCurve curve; //claim my curve.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        transform.localScale = Vector2.one * curve.Evaluate(t) * Time.deltaTime * 50; //local scale changes, I time another 50 because it gonna be faster.
        if(t >= 1)
        {
            t = 0; //reset t value to initial value when it gets maximum.
        }
    }
}
