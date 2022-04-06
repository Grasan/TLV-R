using UnityEngine;

namespace TheLostVikings {
    public class Backpack : MonoBehaviour {
        public Pickup[] slots = new Pickup[4];
        public int itemIndex = 0;

        private void Awake() {
            ClearInventory();
        }

        public bool inventoruIsFull => (
            slots[0] != null &&
            slots[1] != null &&
            slots[2] != null &&
            slots[3] != null
        );

        public void AddItemToPack(Pickup item) {
            if (slots[0] == null) {
                slots[0] = item;
            } else
            if (slots[1] == null) {
                slots[1] = item;
            } else
            if (slots[2] == null) {
                slots[2] = item;
            } else {
                slots[3] = item;
            }
        }

        public void ClearInventory() {
            for (int i = 0; i < slots.Length; i++) {
                slots[i] = null;
            }
        }
    }
}
