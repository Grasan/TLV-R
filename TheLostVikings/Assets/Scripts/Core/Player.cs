using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings.Core {
    public abstract class Player : MonoBehaviour {
        // Stats
        private int healthPoints = 3;
        private int shieldPoints = 0;
        private bool dead;
        private bool active = false;

        // Components
        protected Backpack backpack;
        protected CharacterManager characterManager;
        protected PlayerMovement movement;
        protected Player nextCharachter;
        protected Player previusCharachter;

        protected virtual void Awake() {
            characterManager = FindObjectOfType<CharacterManager>();
            backpack = GetComponent<Backpack>();
            movement = GetComponent<PlayerMovement>();
        }

        public bool isActive() { return active; }
        public void setActive(bool value) {
            active = value;
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

        public bool isDead() { return dead; } 
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