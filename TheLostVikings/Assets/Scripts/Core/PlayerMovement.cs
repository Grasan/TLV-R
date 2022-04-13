using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings.Core {
    public class PlayerMovement : MonoBehaviour {
        // Global variables
        private bool facingRight;
        private bool ladderClose;
        private bool climbing;

        // Components
        private Player player;

        // Stats
        public float movementSpeed = 5.0f;
        public float climbingSpeed = 3.0f;
        public LayerMask whatIsGround;
        public bool isGrounded =>
            Physics.Raycast(transform.position, Vector3.down, 1.1f, whatIsGround);
        private Vector2 direction;

        // Start is called before the first frame update
        private void Awake() {
            player = GetComponent<Player>();
        }

        // Update is called once per frame
        private void Update() {
            if (player.isActive()) {
                Vector2 m = new Vector2(direction.x, 0) * Time.deltaTime;
                transform.Translate(m * movementSpeed, Space.World);
            }
        }

        private void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Ladder")) {
                setLadderClose(true);

                Debug.Log("Player is next to a ladder.");
            }
        }
        private void OnTriggerExit(Collider other) {
            if (other.CompareTag("Ladder")) {
                setLadderClose(false);
                setClimbing(false); 
            }
        }
        
        public bool isLadderClose() { return ladderClose; }
        public void setLadderClose(bool value) {
            ladderClose = value;
        }
        public bool isClimbing() { return climbing; }
        public void setClimbing(bool value) {
            climbing = value;
        }

        public void Move(InputAction.CallbackContext context) {
            direction = context.ReadValue<Vector2>();
        }

        public void Interact(InputAction.CallbackContext context) {
            if (context.performed && player.isActive())
                Debug.Log("hello! My name is " + this.name);
        }

        public void ClimbLadder() {
            if (isGrounded && ladderClose) {
                setClimbing(true);

            }
        }

        public void PushObject() {
            if (isGrounded) {

            }
        }

        
    }
}
