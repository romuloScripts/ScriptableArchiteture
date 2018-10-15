
using UnityEditor;
using UnityEngine;

namespace GameArchiteture.Events
{
    [CustomEditor(typeof(GameEvent)),CanEditMultipleObjects]
    public class EventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            foreach (var item in targets)
            {
                GameEvent e = item as GameEvent;
                if (GUILayout.Button("Run "+ e.name))
                    e.Raise();
            }
        }
    }
}