﻿namespace Coimbra.Services.PlayerLoopEvents
{
    /// <summary>
    /// Invoked during <see cref="UnityEngine.PlayerLoop.EarlyUpdate"/>.
    /// </summary>
    /// <seealso cref="IPlayerLoopEvent"/>
    public partial struct FirstEarlyUpdateEvent : IPlayerLoopEvent
    {
        public FirstEarlyUpdateEvent(float deltaTime)
        {
            DeltaTime = deltaTime;
        }

        /// <inheritdoc/>
        public float DeltaTime { get; internal set; }
    }
}
