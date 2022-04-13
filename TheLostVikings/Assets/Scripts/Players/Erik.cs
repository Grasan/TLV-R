using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings.Core {
    public class Erik : Player {
        public float jumpForce = 5;

        protected override void Awake() {
            base.Awake();

            nextCharachter = FindObjectOfType<Baleog>();
            previusCharachter = FindObjectOfType<Olaf>();
        }

        // Action 1
        public void Jump(InputAction.CallbackContext context) {
            if (context.performed && movement.isGrounded && isActive())
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpForce), ForceMode.Impulse);
            else
                Debug.Log(
                    "isGrounded: " + movement.isGrounded + "\n" +
                    "isActive: " + isActive()
                );
        }

        // Action 2
        public void Dash(InputAction.CallbackContext context) {
            if (isActive() && movement.isGrounded)
                StartCoroutine("Dashing");
        }

        IEnumerator Dashing() {
            Debug.Log("I'm dashing!");
            yield return new WaitForSeconds(3.0f);
            Debug.Log("I'm done dashing.");
        }
    }
}