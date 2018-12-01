using System.Collections.Generic;
using UnityEngine;

namespace GameArchiteture.Events{
    [CreateAssetMenu(fileName = "Event", menuName = "Game Architeture/GameEvent", order = 0)]
    public class GameEvent : ScriptableObject{
        
        private readonly List<GameEventListenerBase> eventListeners = 
            new List<GameEventListenerBase>();

        public virtual void Raise(){
            for(int i = eventListeners.Count -1; i >= 0; i--)
                eventListeners[i].OnEventRaised(this);
        }

        public void RegisterListener(GameEventListenerBase listener){
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListenerBase listener){
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}