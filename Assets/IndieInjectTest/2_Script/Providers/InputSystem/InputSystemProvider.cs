using IndieInject;

public class InputSystemProvider : MonoProvider
{
    [Provide(true)]
    public InputSystem ProvideInputSystem() => new();

}
