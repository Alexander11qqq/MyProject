using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance = new InputManager();

    public float GetHorizontalValue()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public static InputManager Instace => instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);

    }
}
