using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings {
    public class Erik : IPlayer {
        public float jumpForce = 5;

        public override void Awake() {
            base.Awake();

            nextCharachter = GameObject.FindObjectOfType<Baleog>();
            previusCharachter = GameObject.FindObjectOfType<Olaf>();
        }

        // Action 1
        public void Jump(InputAction.CallbackContext context) {
            if (context.performed && isGrounded && isActive)
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

        // Action 2
        public void Dash(InputAction.CallbackContext context) {
            if (isActive)
                StartCoroutine("Dashing");
        }

        IEnumerator Dashing() {
            Debug.Log("I'm dashing!");
            yield return new WaitForSeconds(3.0f);
            Debug.Log("I'm done dashing.");
        }
    }
}