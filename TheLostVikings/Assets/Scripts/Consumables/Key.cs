using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheLostVikings.Core;

namespace TheLostVikings.Consumables {
    public class Key : Pickup {
        private Material keyMaterial;

        public Color keyColor;
        public Door target;

        protected override void Awake() {
            base.Awake();

            keyMaterial = meshRenderer.material;
            keyMaterial.color = keyColor;
        }

        public override void UseItem() {
            Debug.Log(owner.name + " used a key to open " + target.name);

            // Unlock door.
            target.UnlockDoor();

            // Remove key from game scene.
            Destroy(gameObject);
        }
    }
}