using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings {
    public class Key : Pickup {
        public Door target;

        public override void UseItem() {
            Debug.Log(owner.name + " used a key to open a door");
        }
    }
}