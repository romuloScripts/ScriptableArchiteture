using UnityEngine;
using UnityEngine.Events;

namespace GameArchiteture.Events{
    public class UnityEventRaiser : MonoBehaviour{
        public UnityEvent OnEnableEvent;

        public void OnEnable(){
            OnEnableEvent.Invoke();
        }
    }
}