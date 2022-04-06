using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings {
    public class ShieldItem : Pickup {
        public int shieldPoints = 1;

        public override void UseItem() {
            Debug.Log(owner.name + " gained " + shieldPoints + " ShieldPoints.");

            owner.AddShield(shieldPoints);
            Destroy(gameObject);
        }
    }
}
