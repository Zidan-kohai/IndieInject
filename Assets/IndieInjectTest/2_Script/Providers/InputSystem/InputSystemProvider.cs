using IndieInject;
using UnityEngine;

public class InputSystemProvider : MonoBehaviour
{
    [SerializeField] private InputSystem inputSystemPrefab;

    [Provide(true)]
    public InputSystem ProvideInputSystem() => inputSystemPrefab;

}
