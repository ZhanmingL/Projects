using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MagicStoneMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 StonePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //let the stone's position follow by mouse position, I have tp transfer the cameraview to world point.
        transform.position = StonePos;
    }
}
//Player controlled character by mouse Position Input.