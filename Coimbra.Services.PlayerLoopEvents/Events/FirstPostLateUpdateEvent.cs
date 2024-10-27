namespace Coimbra.Services.PlayerLoopEvents
{
    /// <summary>
    /// Invoked during <see cref="UnityEngine.PlayerLoop.PreLateUpdate"/>.
    /// </summary>
    /// <seealso cref="IPlayerLoopEvent"/>
    public partial struct FirstPostLateUpdateEvent : IPlayerLoopEvent
    {
        public FirstPostLateUpdateEvent(float deltaTime)
        {
            DeltaTime = deltaTime;
        }

        /// <inheritdoc/>
        public float DeltaTime { get; internal set; }
    }
}
