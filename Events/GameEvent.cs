using System.Collections.Generic;
using UnityEngine;

namespace GameArchiteture.Events{
    [CreateAssetMenu(fileName = "Event", menuName = "Game Architerute/GameEvent", order = 0)]
    public class GameEvent : ScriptableObject{
        
        private readonly List<GameEventListener> eventListeners = 
            new List<GameEventListener>();

        public virtual void Raise(){
            for(int i = eventListeners.Count -1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventListener listener){
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener){
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}