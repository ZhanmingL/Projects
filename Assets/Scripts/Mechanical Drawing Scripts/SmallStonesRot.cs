using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallStonesRot : MonoBehaviour
{
    public float Rot = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += Rot;
        transform.eulerAngles = rot; //rotate two top small stones.
    }
}
