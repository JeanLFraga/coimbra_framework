﻿namespace Coimbra.Services.PlayerLoopEvents
{
    /// <summary>
    /// Invoked during <see cref="UnityEngine.PlayerLoop.Update"/>.
    /// </summary>
    /// <seealso cref="IPlayerLoopEvent"/>
    public partial struct FirstUpdateEvent : IPlayerLoopEvent
    {
        public FirstUpdateEvent(float deltaTime)
        {
            DeltaTime = deltaTime;
        }

        /// <inheritdoc/>
        public float DeltaTime { get; internal set; }
    }
}
