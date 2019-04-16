using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance2Camera : MonoBehaviour {

    public Transform mainCamera;

    private Vector3 offset;
    
    // Use this for initialization
    void Start () {
        offset = transform.position - mainCamera.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = mainCamera.position + offset;
	}
}
