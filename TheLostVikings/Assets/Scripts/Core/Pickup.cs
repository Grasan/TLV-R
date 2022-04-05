using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings {
    public abstract class Pickup:MonoBehaviour {
        protected Player owner;

        void OnTriggerEnter(Collider other) {
            owner = other.GetComponent<Player>();

            if (!owner.backpackFull) {
                owner.AddItemToPack(this);
                Debug.Log(owner.name + " Picked up a " + name);
                gameObject.SetActive(false);
            }
        }

        public abstract void UseItem();

    }
}