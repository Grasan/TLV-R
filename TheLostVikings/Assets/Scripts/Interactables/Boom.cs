using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings {
    public class Boom : Pickup {

        public override void UseItem() {
            Debug.Log(owner.name + " dropped a bomb");
        }

    }
}
