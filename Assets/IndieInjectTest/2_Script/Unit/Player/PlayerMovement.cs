using IndieInject;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Inject] private InputSystem input;
    [Inject] private PlayerData data;

    private void Update()
    {
        transform.Translate(Input.mousePosition * data.Speed * Time.deltaTime);
    }
}
