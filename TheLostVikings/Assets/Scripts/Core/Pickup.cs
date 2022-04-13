using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings.Core {
    public abstract class Pickup:MonoBehaviour {
        protected Player owner;
        protected BoxCollider col;
        protected MeshFilter mesh;
        protected MeshRenderer meshRenderer;

        protected virtual void Awake() {
            col = GetComponent<BoxCollider>();
            mesh = GetComponentInChildren<MeshFilter>();
            meshRenderer = GetComponentInChildren<MeshRenderer>();
        }

        void OnTriggerEnter(Collider other) {
            owner = other.GetComponent<Player>();

            if (!owner.GetBackpack().inventoruIsFull && other.tag.Equals("Player")) {
                // Add item to character bag.
                owner.GetBackpack().AddItemToPack(this);
                Debug.Log(owner.name + " Picked up a " + name);

                // Deactivate collider and renderer for object.
                Destroy(mesh);
                Destroy(col);
            }
        }

        public abstract void UseItem();

    }
}