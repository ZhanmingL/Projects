using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand2 : MonoBehaviour
{
    public float rot2 = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rot2 * 12 * Time.deltaTime);
    }
}
