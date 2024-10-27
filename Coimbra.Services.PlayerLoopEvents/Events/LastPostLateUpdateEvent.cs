namespace Coimbra.Services.PlayerLoopEvents
{
    /// <summary>
    /// Invoked during <see cref="UnityEngine.PlayerLoop.PostLateUpdate"/>.
    /// </summary>
    /// <seealso cref="IPlayerLoopEvent"/>
    public partial struct LastPostLateUpdateEvent : IPlayerLoopEvent
    {
        public LastPostLateUpdateEvent(float deltaTime)
        {
            DeltaTime = deltaTime;
        }

        /// <inheritdoc/>
        public float DeltaTime { get; internal set; }
    }
}
