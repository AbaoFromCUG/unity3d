using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCubeMove : MonoBehaviour {
    //Cube的初始速度
    public float CubeSpeed = 1f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CubeSpeed += 0.1f;
        this.transform.Translate(Vector3.left * CubeSpeed * Time.deltaTime);
	}
}
