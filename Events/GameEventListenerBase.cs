using System.Collections;
using System.Collections.Generic;
using GameArchiteture.Events;
using UnityEngine;

public abstract class GameEventListenerBase : MonoBehaviour
{
	public abstract void OnEventRaised(GameEvent gameEvent = null);
}
