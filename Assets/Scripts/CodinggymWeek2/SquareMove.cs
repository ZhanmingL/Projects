using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    float move = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * move * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * move * Time.deltaTime;

        Vector2 BottomL = Camera.main.ScreenToWorldPoint(Vector2.zero);
        Vector2 TopR = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height));

        pos.x = Mathf.Clamp(pos.x, BottomL.x, TopR.x);  //constrain x values
        pos.y = Mathf.Clamp(pos.y, BottomL.y, TopR.y);  //constrain y values, Mathf.Clamp is as same as constrain in Processing!

        transform.position = pos;
    }
}
