// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub:   https://github.com/RimuruDev
//
// **************************************************************** //

using IndieInject;
using UnityEngine;

namespace IndieInjectSample
{
    [SelectionBase]
    [RequireComponent(typeof(Rigidbody))]
    [HelpURL("https://github.com/RimuruDev/IndieInject")]
    [InjectRegion(InjectRegion.Properties)]
    public class Hero : MonoBehaviour
    {
        // === Inject in properties === //
        [Inject] private InputService InputService { get; set; }
        [Inject] private HeroConfig HeroConfig { get; set; }

        private Rigidbody heroRigidbody;

        private void Awake() =>
            heroRigidbody = GetComponent<Rigidbody>();

        private void Update()
        {
            var input = InputService.GetInput();

            var movement = input * (HeroConfig.MoveSpeed * Time.deltaTime);

            heroRigidbody.MovePosition(transform.position + movement);
        }
    }
}