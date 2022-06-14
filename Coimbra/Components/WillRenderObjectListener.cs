﻿using UnityEngine;

namespace Coimbra
{
    /// <summary>
    /// Listen to <see cref="Renderer"/>'s <see cref="OnWillRenderObject"/> callback.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Renderer))]
    [AddComponentMenu(CoimbraUtility.GeneralMenuPath + "Will Render Object Listener")]
    [HelpURL("https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnWillRenderObject.html")]
    public sealed class WillRenderObjectListener : MonoBehaviour
    {
        public delegate void EventHandler(WillRenderObjectListener sender);

        /// <summary>
        /// Invoked inside <see cref="OnWillRenderObject"/>.
        /// </summary>
        public event EventHandler OnTrigger
        {
            add
            {
                _eventHandler += value;
                enabled = _eventHandler != null;
            }
            remove
            {
                _eventHandler -= value;
                enabled = _eventHandler != null;
            }
        }

        private EventHandler _eventHandler;

        private Renderer _renderer;

        /// <summary>
        /// The renderer this component depends on.
        /// </summary>
        public Renderer Renderer => _renderer != null ? _renderer : _renderer = GetComponent<Renderer>();

        private void Awake()
        {
            enabled = _eventHandler != null;
        }

        private void OnWillRenderObject()
        {
            _eventHandler?.Invoke(this);
        }
    }
}