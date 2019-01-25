using UnityEngine;

public class ChopTree : MonoBehaviour {
    private Inventory inventory;

    void Start() {
        inventory = GetComponent<Inventory>();
    }


    private void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("tree") && Input.GetKey(KeyCode.Space) && inventory.woodAmount < 2) {
            Destroy(other.gameObject);
            inventory.woodAmount++;
        }
    }
}