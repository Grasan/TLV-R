using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings {
    public abstract class Pickup:MonoBehaviour {
        protected Player owner;
        protected BoxCollider col;
        protected MeshRenderer mesh;

        protected void Awake() {
            col = GetComponent<BoxCollider>();
            mesh = GetComponentInChildren<MeshRenderer>();
        }

        void OnTriggerEnter(Collider other) {
            owner = other.GetComponent<Player>();

            if (!owner.GetBackpack().inventoruIsFull && other.tag.Equals("Player")) {
                // Add item to character bag.
                owner.GetBackpack().AddItemToPack(this);
                Debug.Log(owner.name + " Picked up a " + name);

                // Deactivate collider and renderer for object.
                col.gameObject.SetActive(false);
                mesh.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }

        public abstract void UseItem();

    }
}