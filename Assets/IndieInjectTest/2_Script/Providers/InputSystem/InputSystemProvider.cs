using IndieInject;
using UnityEngine;

public class InputSystemProvider : MonoBehaviour
{
    [Provide(true)]
    public InputSystem ProvideInputSystem() => new();

}
