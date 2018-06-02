using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GameArchiteture.Events{
	[CreateAssetMenu(fileName = "GameEvent", menuName = "Game Architerute/GameEventWithUnityEvent", order = 0)]
	public class GameEventWithUnityEvent : GameEvent {
		public UnityEvent unityEvent;

		public override void Raise(){
			unityEvent.Invoke();
			base.Raise();
		}
	}
}
