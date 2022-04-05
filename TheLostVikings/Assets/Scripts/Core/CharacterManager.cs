using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheLostVikings {
    public class CharacterManager : MonoBehaviour {

        public Player activeCharacter;

        private void Start() {
            activeCharacter = GameObject.FindObjectOfType<Erik>();
            activeCharacter.isActive = true;
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton5))
                SwitchCharacterRight();

            if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.JoystickButton4))
                SwitchCharacterLeft();
        }

        public void SwitchCharacterRight() {
            Debug.Log("Current character: " + activeCharacter.name);
            activeCharacter.isActive = false;
            if (activeCharacter.GetNextCharacter().dead == false) {
                Debug.Log(activeCharacter.GetNextCharacter().name + " is alive. switching to him");
                activeCharacter = activeCharacter.GetNextCharacter();
                activeCharacter.isActive = true;
                return;
            } else if (activeCharacter.GetPreviusCharacter().dead == false) {
                Debug.Log(activeCharacter.GetNextCharacter().name + " is dead. switching to " + activeCharacter.GetPreviusCharacter().name + " instead");
                activeCharacter = activeCharacter.GetPreviusCharacter();
                activeCharacter.isActive = true;
                return;
            } else {
                Debug.Log("Everyone else is dead");
                return;
            }
        }

        public void SwitchCharacterLeft() {
            Debug.Log("Current character: " + activeCharacter.name);
            activeCharacter.isActive = false;
            if (activeCharacter.GetPreviusCharacter().dead == false) {
                Debug.Log(activeCharacter.GetPreviusCharacter().name + " is alive. switching to him");
                activeCharacter = activeCharacter.GetPreviusCharacter();
                activeCharacter.isActive = true;
                return;
            } else if (activeCharacter.GetNextCharacter().dead == false) {
                Debug.Log(activeCharacter.GetPreviusCharacter().name + " is dead. switching to " + activeCharacter.GetNextCharacter().name + " instead");
                activeCharacter = activeCharacter.GetNextCharacter();
                activeCharacter.isActive = true;
                return;
            } else {
                Debug.Log("Everyone else is dead");
                return;
            }
        }
    }
}
