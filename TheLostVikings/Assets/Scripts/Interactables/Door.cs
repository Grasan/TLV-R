using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool locked;

    public void UnlockDoor() {
        locked = false;
        KeepDoorOpen();
    }

    public void OpenCloseDoor() {

    }

    private void KeepDoorOpen() {

    }
}
