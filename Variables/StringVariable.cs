using UnityEngine;

namespace GameArchiteture.Variables{
    [CreateAssetMenu(fileName = "StringVariable", menuName = "Game Architeture/StringVariable", order = 0)]
    public class StringVariable : ScriptableObject{
        [SerializeField]
        private string value = "";

        public string Value{
            get { return value; }
            set { this.value = value; }
        }
    }
}