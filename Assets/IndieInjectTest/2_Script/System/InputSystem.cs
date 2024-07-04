using UnityEngine;

public class InputSystem 
{
    public float Horizontal => Input.GetAxis("Horizontal");
    public float Vertical => Input.GetAxis("Vertical");
    public bool LoadScene => Input.GetKeyDown(KeyCode.Return);
}
