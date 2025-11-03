using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        if (Keyboard.current.aKey.isPressed)
        {
            horizontal = -0.1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            horizontal = 0.1f;
        }
        float vertical = 0.0f;
        if (Keyboard.current.wKey.isPressed)
        {
            vertical = 0.1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            vertical = -0.1f;
        }

        Debug.Log(horizontal);

        Vector2 position=transform.position;
        position.x = position.x + 0.1f*horizontal;
        position.y = position.y +0.1f*vertical;
        transform.position = position;
    }
}
