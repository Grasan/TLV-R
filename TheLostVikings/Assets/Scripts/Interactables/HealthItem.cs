using System;
using UnityEngine;

namespace TheLostVikings.Interactable {
    public class HealthItem : IPickup {
        public int healthPoints = 1;

        public void UseItem() {
            Debug.Log("Player gained " + healthPoints + " HP.");
        }
    }
}