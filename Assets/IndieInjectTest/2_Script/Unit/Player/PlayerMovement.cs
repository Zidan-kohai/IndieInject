using IndieInject;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Inject] private InputSystem input;
    [Inject] private PlayerData data;

    private void Update()
    {
        Vector3 movement = new Vector3(input.Horizontal, 0, input.Vertical) * data.Speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
