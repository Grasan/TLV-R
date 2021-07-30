using UnityEngine;

namespace TheLostVikings {
    public class Olaf : IPlayer {
        private bool shieldUp = false;

        // Special ability
        void TiltShield() {
            // Turn the shield
            if (shieldUp)
                shieldUp = false;
            else
                shieldUp = true;

            Debug.Log("I tilted my shield " + (shieldUp ? "up" : "down"));
        }
    }
}