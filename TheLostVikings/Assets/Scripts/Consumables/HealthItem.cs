using System;
using UnityEngine;

namespace TheLostVikings.Interactable {
    public class HealthItem : Pickup {
        public int healthPoints = 1;

        public override void UseItem() {
            Debug.Log(owner.name + " gained " + healthPoints + " HP.");

            owner.giveHealth(healthPoints);
            Destroy(gameObject);
        }
    }
}