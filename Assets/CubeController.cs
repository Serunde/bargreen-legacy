using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;

        transform.Translate(y, 0, 0);
        transform.Translate(0, 0, z);
    }
}
