using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public int woodAmount = 0;

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("fire") && Input.GetKey(KeyCode.Space)) {
            Fire fire = other.gameObject.GetComponent<Fire>();
            fire.addWood(woodAmount);
            woodAmount = 0;
        }
    }
}