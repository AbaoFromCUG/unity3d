using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    public float moveSpeed = 2f;
    public float upSpeed = 2f;
    public Rigidbody rd;
    //public float rotateSpeed = 0.01f;


	// Use this for initialization
	void Start () {
        rd = GetComponent<Rigidbody>();


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {

            //rd.AddForce(Vector3.up * 20, ForceMode.Acceleration);
        }


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //this.transform.Rotate(Vector3.down * rotateSpeed);
            this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right*moveSpeed*Time.deltaTime);
        }
    }

   

}
