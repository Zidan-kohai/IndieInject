// **************************************************************** //
//
//   Copyright (c) YUJECK. All rights reserved.
//   Contact me: 
//          - GitHub:   https://github.com/YUJECK
//
// **************************************************************** //

using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace IndieInject
{
    public sealed class InjectFabric
    {
        public event Action<Object> OnInstantiated;
        public event Action<GameObject> OnGameObjectInstantiated;

        public TObject Instantiate<TObject>(TObject original, Vector3 position)
            where TObject : Object
        {
            return Instantiate(original, position, Quaternion.identity, null);
        }

        public TObject Instantiate<TObject>(TObject original, Transform transform)
            where TObject : Object
        {
            return Instantiate(original, transform.position, Quaternion.identity, transform);
        }

        
        public TObject Instantiate<TObject>(TObject original, Vector3 position, Transform parent)
            where TObject : Object
        {
            return Instantiate(original, position, Quaternion.identity, parent);
        }

        public TObject Instantiate<TObject>(TObject original, Vector3 position, Quaternion rotation)
            where TObject : MonoBehaviour
        {
            return Instantiate(original, position, rotation, null);
        }

        public TObject Instantiate<TObject>(TObject original, Vector3 position, Quaternion rotation,
            Transform parent)
            where TObject : Object
        {
            var instance = Object.Instantiate(original, position, rotation, parent);
            
            Indie.Injector.Inject(instance);

            OnInstantiated?.Invoke(instance);
            InvokeGameObjectEventsIfGameObject();
            
            return instance;

            void InvokeGameObjectEventsIfGameObject()
            {
                if (instance is GameObject gameObject)
                {
                    OnGameObjectInstantiated?.Invoke(gameObject);
                }
                else if (instance is Component component)
                {
                    OnGameObjectInstantiated?.Invoke(component.gameObject);
                }
            }
        }
    }
}