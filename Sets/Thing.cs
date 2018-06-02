﻿using UnityEngine;

namespace GameArchiteture.Sets{
    public class Thing : MonoBehaviour{
        public ThingRuntimeSet RuntimeSet;

        private void OnEnable(){
            RuntimeSet.Add(this);
        }

        private void OnDisable(){
            RuntimeSet.Remove(this);
        }
    }
}