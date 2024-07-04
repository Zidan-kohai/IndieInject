using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }
    public bool LoadScene { get; internal set; }

    public void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        LoadScene = Input.GetKeyDown(KeyCode.KeypadEnter);
    }
}
