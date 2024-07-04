// **************************************************************** //
//
//   Copyright (c) YUJECK. All rights reserved.
//   Contact me: 
//          - GitHub:   https://github.com/YUJECK
//
// **************************************************************** //

using UnityEngine;

namespace IndieInject
{
    public sealed class SceneAutoInjector : MonoBehaviour
    {
        private void Start()
        {
            MonoBehaviour[] all = FindObjectsOfType<MonoBehaviour>(true);

            foreach (MonoBehaviour monoBehaviour in all)
            {
                Indie.Injector.Inject(monoBehaviour);
            }
        }
    }
}