using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLostVikings.Interactables {
    public class Ladder : MonoBehaviour {
        private BoxCollider trigger;

        public Transform ladderPiece;
        public Transform ladderEnd;
        private int height;

        // Start is called before the first frame update
        void Start() {
            height = (int)ladderEnd.transform.localPosition.y;
            trigger = GetComponent<BoxCollider>();

            trigger.size = new Vector3(2.0f, height, 1.0f);
            trigger.center = new Vector3(0.0f, (float)height / 2, -1.0f);

            for (float i = 1; i < (height); i++) {
                Instantiate(
                    ladderPiece,
                    new Vector3(
                        transform.position.x,
                        transform.position.y + i,
                        transform.position.z
                    ),
                    Quaternion.identity,
                    this.transform
                );
            }
        }

    }
}
