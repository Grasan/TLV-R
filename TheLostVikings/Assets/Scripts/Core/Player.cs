using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings {
    public abstract class Player : MonoBehaviour {
        // Stats
        public float movementSpeed = 5.0f;
        protected int healthPoints = 3;
        protected int shieldPoints = 0;

        public bool dead;
        public bool climbing;

        public Transform groundPoint;
        public LayerMask whatIsGround;
        public bool isActive = false;
        public bool isGrounded => Physics.Raycast(transform.position, Vector3.down, 0.6f, whatIsGround);
        protected bool facingRight;

        // Components
        protected Backpack backpack;
        protected CharacterManager characterManager;
        protected Player nextCharachter;
        protected Player previusCharachter;
        Vector2 direction;

        // Anim
        public AnimationClip dammagedAnimClip;
        public AnimationClip deathAnimClip;

        public virtual void Awake() {
            characterManager = FindObjectOfType<CharacterManager>();
            backpack = GetComponent<Backpack>();
        }

        public virtual void Update() {
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
            if (isGrounded) {

            }
        }

        public void PushObject() {
            if (isGrounded) {

            }
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
                Die();
            }
        }

        public Backpack GetBackpack() {
            return this.backpack;
        }

        public void useItem(InputAction.CallbackContext context) {
            backpack.slots[backpack.itemIndex].UseItem();
            backpack.slots[backpack.itemIndex] = null;
        }

        public void giveHealth(int healthPoints) {
            if (this.healthPoints + healthPoints >= 3)
                this.healthPoints = 3;
            else
                this.healthPoints += healthPoints;
        }
        public void AddShield(int shieldPoints) {

        }

        public Player GetNextCharacter() { return nextCharachter; }
        public Player GetPreviusCharacter() { return previusCharachter; }

        private bool myNextFriendIsDead => GetNextCharacter() == null;
        private bool myPreviusFriendIsDead => GetPreviusCharacter() == null;
        private bool allMyFriendsAreDead => (myNextFriendIsDead && myPreviusFriendIsDead);
        private void Die() {
            backpack.ClearInventory();
            dead = true;
            // Play dead anim
            if (allMyFriendsAreDead) {
                // Play game over cutscene
            } else if (myNextFriendIsDead) {
                characterManager.SwitchCharacterLeft();
            } else if (myPreviusFriendIsDead) {
                characterManager.SwitchCharacterRight();
            }
        }
    }
}