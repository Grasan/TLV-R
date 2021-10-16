using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings {
    public abstract class IPlayer : MonoBehaviour {
        // Stats
        public float movementSpeed = 5.0f;
        public int healthPoints = 3;
        public int shieldPoints = 0;
        public IPickup[] inventory = new IPickup[4];
        public bool dead;

        public Transform groundPoint;
        public LayerMask whatIsGround;
        public bool isActive = false;
        protected bool isGrounded;
        protected bool facingRight;

        // Components
        protected IPlayer nextCharachter;
        protected IPlayer previusCharachter;
        Vector2 direction;

        // Anim
        public AnimationClip dammagedAnimClip;
        public AnimationClip deathAnimClip;

        public virtual void Awake() {
            for (int i = 0; i < inventory.Length; i++) {
                inventory[i] = null;
            }
        }

        public virtual void Update() {
            // Cheack if on the ground
            isGrounded = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);


            // Movement
            if (isActive) {
                if (direction.x >= 0.6 || direction.x <= -0.6) {
                    Vector2 m = new Vector2(direction.x, 0) * Time.deltaTime;
                    transform.Translate(m * movementSpeed, Space.World);
                }
            }
        }

        public void Interact(InputAction.CallbackContext context) {
            if (context.performed)
                Debug.Log("hello! My name is " + this.name);
        }
        
        public void Move(InputAction.CallbackContext context) {
            direction = context.ReadValue<Vector2>();
        }
        
        public void ClimbLadder() {

        }

        public void TakeDammage() {
            healthPoints -= 1;
            if (healthPoints == 0) {
                dead = true;
                Die();
            }
            if (healthPoints > 0) {
                // Dammaged anim
            } else {
                // DeathAnim
                // Die();
            }
        }

        public IPlayer GetNextCharacter() { return nextCharachter; }
        public IPlayer GetPreviusCharacter() { return previusCharachter; }

        private void Die() {
            for (int i = 0; i < inventory.Length; i++) {
                inventory[i] = null;
            }
            dead = true;
            // SwithCharacter();
        }
    }
}