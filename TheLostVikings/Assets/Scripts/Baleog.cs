using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings {
    public class Baleog : IPlayer {
        public float arrowSpeed = 3.0f;
        public float swordCooldown = 0.5f;

        private void SwingSword() {

        }

        private IEnumerator DrawBow() {
            Debug.Log(this.name + " has drawn his bow");
            yield return new WaitForSeconds(1.0f);
        }

        private void ShootArrow() {
            Debug.Log(this.name + " has realesed the arrow");
        }
    }
}