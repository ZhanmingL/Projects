using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGuy : MonoBehaviour
{
    public float move = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += move * Time.deltaTime;
        Vector2 CameraPos = Camera.main.WorldToScreenPoint(pos); //Camera perspective's position is a bette way to get positions.
        if(CameraPos.x < 0 || CameraPos.x > Screen.width) //if bottom guy reaches laft corner or right corner, reverse the direction.
        {
            move = move * -1; //negative number to reverse a moving direction.
        }
        transform.position = pos;
    }   
}
//It's the moving of bottom magic box guy.