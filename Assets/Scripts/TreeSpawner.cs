using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour {
    public GameObject treePrefab;
    public float treeWidth = 3;
    public float treeHeight = 10;
    public float gameWidth = 750;
    public float gameHeight = 750;
    
    // Start is called before the first frame update
    void Start() {
        for (float x = -gameWidth / 2.0f; x <= gameWidth / 2.0; x += treeWidth) {
            for (float y = -gameHeight / 2.0f; y <= gameHeight / 2.0; y += treeHeight) {
                Instantiate(treePrefab, new Vector3(x, y), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update() {
    }
}