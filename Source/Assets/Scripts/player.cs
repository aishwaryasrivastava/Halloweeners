using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float speed = 0.1f;
    bool leftArrowState = false;
    bool rightArrowState = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.z += speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.z -= speed;
        }

        transform.position = position;
    }

}