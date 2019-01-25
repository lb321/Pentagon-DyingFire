
using UnityEngine;

public class Move : MonoBehaviour {
    public Vector2 velocity = new Vector2(0, 0);
    public float moveSpeed = 0.1f;
    
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W)) {
            velocity.y = moveSpeed;
        } else if (Input.GetKey(KeyCode.S)) {
            velocity.y = -1 * moveSpeed;
        }

        if (Input.GetKey(KeyCode.A)) {
            velocity.x = -moveSpeed;
        } else if (Input.GetKey(KeyCode.D)) {
            velocity.x = moveSpeed;
        }
        
        transform.Translate(velocity.x, velocity.y, 0);
        
    }
}
