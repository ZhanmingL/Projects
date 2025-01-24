using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClockRotating : MonoBehaviour
{
    public float rot;

    // Start is called before the first frame update
    void Start()
    {
        rot = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 zzz = transform.eulerAngles;
        zzz.z += rot;
        transform.eulerAngles = zzz;
    }
}
