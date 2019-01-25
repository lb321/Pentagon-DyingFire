using UnityEngine;

public class Fire : MonoBehaviour {
    public float durationPerWood = 5.0f;
    public float fireDurationLeft = 5.0f;
    public GameObject fire;

    private void Start() {
        fireDurationLeft = durationPerWood;
    }

    // Update is called once per frame
    void Update() {
        fireDurationLeft -= Time.deltaTime;

        if (fireDurationLeft <= 0) {
            fireDurationLeft = 0;
            fire.SetActive(false);
        }
    }

    public void addWood(int amount) {
        fireDurationLeft += durationPerWood * amount;
        fire.SetActive(true);
    }
}