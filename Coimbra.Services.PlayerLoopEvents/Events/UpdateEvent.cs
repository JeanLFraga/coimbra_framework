namespace Coimbra.Services.PlayerLoopEvents
{
    /// <summary>
    /// Invoked during <a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html">Update</a>.
    /// </summary>
    /// <seealso cref="IPlayerLoopEvent"/>
    public partial struct UpdateEvent : IPlayerLoopEvent
    {
        public UpdateEvent(float deltaTime)
        {
            DeltaTime = deltaTime;
        }

        /// <inheritdoc/>
        public float DeltaTime { get; internal set; }
    }
}
