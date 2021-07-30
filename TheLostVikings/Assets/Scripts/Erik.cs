using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings {
    public class Erik : IPlayer {
        public float jumpForce = 5;

        public override void Awake() {
            base.Awake();
        }

        public void Jump(InputAction.CallbackContext context) {
            if (context.performed && isGrounded)
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

        public void Dash() {

        }
    }
}