using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameArchiteture.Variables{
    [CreateAssetMenu(fileName = "ObjectReference", menuName = "Game Architeture/ObjectReference", order = 0)]
    public class ObjectReference : ScriptableObject {

        [SerializeField]
        protected Object objReference;

        public virtual Object ObjRef{
            get{
                return objReference;
            }set{
                objReference = value;
            }
        }
    }
}
