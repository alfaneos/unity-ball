using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 v = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(v * speed);
    }

	void OnTriggerEnter(Collider other) {
//		Destroy(other.gameObject);
		if(other.gameObject.CompareTag("Pick Up")){
			other.gameObject.SetActive (false);
		}
	}
}
