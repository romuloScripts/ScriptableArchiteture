using UnityEngine;

public interface ICondition
{
    bool GetResult();
}

namespace GameArchiteture.Variables{
    
    [CreateAssetMenu(fileName = "ObjectReference", menuName = "Game Architeture/ObjectReference", order = 0)]
    public class ObjectReference : ScriptableObject, ICondition {

        [SerializeField]
        protected Object objReference;

        public virtual Object ObjRef{
            get{
                return objReference;
            }set{
                objReference = value;
            }
        }

        private bool NotNull()
        {
            return objReference != null;
        }
        
        public void SetNull()
        {
            objReference = null;
        }

        public bool GetResult()
        {
            return NotNull();
        }

        public void Instantiate()
        {
            Instantiate(objReference);
        }
    }
}
