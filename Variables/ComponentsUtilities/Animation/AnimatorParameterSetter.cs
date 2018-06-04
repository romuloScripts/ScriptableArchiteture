using UnityEngine;

namespace GameArchiteture.Variables{

    public class AnimatorParameterSetter : MonoBehaviour{
        [Tooltip("Variable to read from and send to the Animator as the specified parameter.")]
        public FloatVariable Variable;

        [Tooltip("Animator to set parameters on.")]
        public Animator Animator;

        [Tooltip("Name of the parameter to set with the value of Variable.")]
        public string ParameterName;

        [Tooltip("Animator Hash of ParameterName, automatically generated.")]
        [SerializeField] private int parameterHash;

        private void OnValidate(){
            parameterHash = Animator.StringToHash(ParameterName);
        }

        private void Update(){
            Animator.SetFloat(parameterHash, Variable.Value);
        }
    }
}