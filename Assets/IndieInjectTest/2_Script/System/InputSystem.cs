using UnityEngine;

public class InputSystem 
{
    public float Horizontal { get; private set; } = Input.GetAxis("Horizontal");
    public float Vertical { get; private set; } = Input.GetAxis("Vertical");
    public bool LoadScene { get; internal set; } = Input.GetKeyDown(KeyCode.KeypadEnter);
}
