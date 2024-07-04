using IndieInject;

namespace IndieInjectSample
{
    public class InputServiceProvider : MonoProvider
    {
        [Provide(true)]
        public InputService ProvideInputService() => new();
    }
}