using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings {
    public class Key : IPickup {
        public Door target;

        public void UseItem() {
            Debug.Log("Player unlocked " + target);
        }
    }
}