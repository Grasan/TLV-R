using System;
using TheLostVikings.Core;
using UnityEngine;

namespace TheLostVikings.Consumables {
    public class HealthItem : Pickup {
        public int healthPoints = 1;

        public override void UseItem() {
            Debug.Log(owner.name + " gained " + healthPoints + " HP.");

            owner.giveHealth(healthPoints);
            Destroy(gameObject);
        }
    }
}