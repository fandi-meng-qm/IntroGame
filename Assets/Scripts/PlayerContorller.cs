using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContorller : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;

    void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveValue.x, 0.0 f, moveValue.y);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.
            fixedDeltaTime);
    }
}
