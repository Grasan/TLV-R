using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings {
    public class Boom : Pickup {

        public override void UseItem() {
            Debug.Log(owner.name + " dropped a bomb");

            // set Location to player location
            transform.position = owner.transform.position;

            // start explosion timer
            //StartCoroutine("BOOM");

            // Remove object entirely from game scene.
            Destroy(gameObject);
        }

        /*private IEnumerator BOOM() {
            // Start anim

            new WaitForSeconds(3);
            // Dammage nearby objects (even the player (No one is safe)).

            StopCoroutine("BOOM");
        }*/
    }
}
