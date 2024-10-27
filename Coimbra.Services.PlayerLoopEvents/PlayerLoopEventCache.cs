#nullable enable
namespace Coimbra.Services.PlayerLoopEvents
{
    internal struct PlayerLoopEventCache
    {
        public FixedUpdateEvent FixedUpdateEvent;
        public LateUpdateEvent LateUpdateEvent;
        public UpdateEvent UpdateEvent;
        public FirstFixedUpdateEvent FirstFixedUpdateEvent;
        public LastFixedUpdateEvent LastFixedUpdateEvent;
        public FirstInitializationEvent FirstInitializationEvent;
        public LastInitializationEvent LastInitializationEvent;
        public FirstEarlyUpdateEvent FirstEarlyUpdateEvent;
        public LastEarlyUpdateEvent LastEarlyUpdateEvent;
        public FirstPreUpdateEvent FirstPreUpdateEvent;
        public LastPreUpdateEvent LastPreUpdateEvent;
        public FirstUpdateEvent FirstUpdateEvent;
        public LastUpdateEvent LastUpdateEvent;
        public PreLateUpdateEvent PreLateUpdateEvent;
        public FirstPostLateUpdateEvent FirstPostLateUpdateEvent;
        public PostLateUpdateEvent PostLateUpdateEvent;
        public LastPostLateUpdateEvent LastPostLateUpdateEvent;
        public PreTimeUpdateEvent PreTimeUpdateEvent;
        public PostTimeUpdateEvent PostTimeUpdateEvent;
    }
}