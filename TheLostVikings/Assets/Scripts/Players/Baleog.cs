using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TheLostVikings.Core;

namespace TheLostVikings.Players {
    public class Baleog : Player {
        public float arrowSpeed = 3.0f;
        public float swordCooldown = 0.5f;

        protected override void Awake() {
            base.Awake();

            nextCharachter = GameObject.FindObjectOfType<Olaf>();
            previusCharachter = GameObject.FindObjectOfType<Erik>();
        }

        private void SwingSword() {
            if (isActive())
                Debug.Log("I used my sword");
        }

        private IEnumerator DrawBow() {
            if (isActive()) {
                Debug.Log(this.name + " has drawn his bow");
                yield return new WaitForSeconds(1.0f);
            }
        }

        private void ShootArrow() {
            Debug.Log(this.name + " has realesed the arrow");
        }
    }
}