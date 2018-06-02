using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameArchiteture.Variables;

namespace GameArchiteture.Events{
	[CreateAssetMenu(fileName = "GameEventBranch", menuName = "Game Architerute/GameEventBranch", order = 0)]
	public class GameEventBranch : ScriptableObject {

		public List<Option> options;

		[System.Serializable]
		public class Option{
			public Object obj;
			public GameEvent gameEvent;
		}

		public void Raise(ObjectReference obj){
			Option op = options.Find(o => o.obj == obj.ObjRef);
			if(op != null){
				op.gameEvent.Raise();
			}
		}

		public void RaiseObj(Object obj){
			Option op = options.Find(o => o.obj == obj);
			if(op != null){
				op.gameEvent.Raise();
			}
		}
	}
}
