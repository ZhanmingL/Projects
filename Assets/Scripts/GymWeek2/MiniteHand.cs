using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniteHand : MonoBehaviour
{
    public float minZ;
    // Start is called before the first frame update
    void Start()
    {
        minZ = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 zzZ = transform.eulerAngles;
        zzZ.z += minZ;
        transform.eulerAngles = zzZ;
    }
}
