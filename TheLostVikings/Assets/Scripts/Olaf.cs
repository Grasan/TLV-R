using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings {
    public class Olaf : IPlayer {
        private bool shieldUp = false;

        public override void Awake() {
            base.Awake();

            nextCharachter = GameObject.FindObjectOfType<Erik>();
            previusCharachter = GameObject.FindObjectOfType<Baleog>();
        }

        // Action 1 & 2
        public void TiltShield(InputAction.CallbackContext context) {
            if (isActive) {
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