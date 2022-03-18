﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Coimbra.Systems
{
    /// <summary>
    /// Default implementation for <see cref="ILateUpdateService"/>.
    /// </summary>
    [DisallowMultipleComponent]
    [Obsolete(nameof(LateUpdateSystem) + " has been deprecated. Use " + nameof(LateUpdateEvent) + " through the " + nameof(IEventService) + " instead.")]
    public class LateUpdateSystem : UpdateSystemBase<ILateUpdateService, ILateUpdateListener>, ILateUpdateService
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void Initialize()
        {
            ServiceLocator.SetDefaultCreateCallback(Create, false);
        }

        private static ILateUpdateService Create()
        {
            GameObject gameObject = new GameObject(nameof(LateUpdateSystem))
            {
                hideFlags = HideFlags.NotEditable,
            };

            DontDestroyOnLoad(gameObject);

            return gameObject.AddComponent<LateUpdateSystem>();
        }

        private void LateUpdate()
        {
            float deltaTime = Time.deltaTime;
            IReadOnlyList<ILateUpdateListener> listeners = Listeners;
            int listenersCount = listeners.Count;

            for (int i = 0; i < listenersCount; i++)
            {
                listeners[i].OnLateUpdate(deltaTime);
            }
        }
    }
}