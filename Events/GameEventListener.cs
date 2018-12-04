using UnityEngine;
using UnityEngine.Events;

namespace GameArchiteture.Events{
    public class GameEventListener : GameEventListenerBase
    {
        public bool unregisterOnDisable=true;
        
        [Tooltip("Event to register with."),EditScriptable]
        public GameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        private void OnEnable(){
            Event.RegisterListener(this);
        }

        private void OnDisable(){
            if (unregisterOnDisable)
            {
                Event.UnregisterListener(this);
            }  
        }

        public override void OnEventRaised(GameEvent gameEvent = null)
        {
            Response.Invoke();
        }
        
        public void DisableAndUnregister()
        {
            enabled = false;
            Event.UnregisterListener(this);
        }
        
        public void EnableAndRegister()
        {
            enabled = true;
            Event.RegisterListener(this);
        }
        
    }
}