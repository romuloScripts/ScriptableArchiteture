using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GameArchiteture.Variables;

[CreateAssetMenu(fileName = "GameEventBranchWithUnityEvent", menuName = "Game Architeture/GameEventBranchWithUnityEvent", order = 0)]
public class GameEventBranchWithUnityEvent : ScriptableObject {
    public List<Option> options;

		[System.Serializable]
		public class Option{
			public Object obj;
			public UnityEvent unityEvent;
		}

		public void Raise(ObjectReference obj){
			Option op = options.Find(o => o.obj == obj.ObjRef);
			if(op != null){
				op.unityEvent.Invoke();
			}
		}
}