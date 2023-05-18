using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private float moveSpeed = 5f;

    //private readonly InputManager inputManager = new InputManager();
    private void Update()
    {
        var horizontal = InputManager.Instace.GetHorizontalValue();

        if(horizontal == 0)
        {
            return;
        }

        transform.position += Vector3.right * (horizontal * Time.deltaTime) * moveSpeed;
    }
}
