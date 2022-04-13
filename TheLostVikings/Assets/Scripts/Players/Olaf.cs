using UnityEngine;
using UnityEngine.InputSystem;
using TheLostVikings.Core;

namespace TheLostVikings.Players {
    public class Olaf : Player {
        private bool shieldUp = false;

        protected override void Awake() {
            base.Awake();

            nextCharachter = GameObject.FindObjectOfType<Erik>();
            previusCharachter = GameObject.FindObjectOfType<Baleog>();
        }

        // Action 1 & 2
        public void TiltShield(InputAction.CallbackContext context) {
            if (isActive()) {
                // flip the shield
                if (shieldUp)
                    shieldUp = false;
                else
                    shieldUp = true;

                Debug.Log("I tilted my shield " + (shieldUp ? "up" : "down"));
            }
        }
    }
}