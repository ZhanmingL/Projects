using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MagicStoneMoving : MonoBehaviour
{
    public float StoneMove = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 StonePos = transform.position;
        StonePos.x += Input.GetAxisRaw("Horizontal") * StoneMove * Time.deltaTime; //Moving horizontally by A,D,arrows keys.
        StonePos.y += Input.GetAxisRaw("Vertical") * StoneMove * Time.deltaTime; //Moving vertically by W,S,arrows keys.
        transform.position = StonePos;
    }
}
