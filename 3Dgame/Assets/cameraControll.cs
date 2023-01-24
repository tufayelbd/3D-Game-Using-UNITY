using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControll : MonoBehaviour {

	// Use this for initialization
	public Transform ballObj;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().velocity=new Vector3(0,0,ballObj.GetComponent<Rigidbody>().velocity.z);
		if(Input.GetAxis("Mouse ScrollWheel")>0){
			GetComponent<Camera>().fieldOfView -=1;


		}
		if(Input.GetAxis("Mouse ScrollWheel")<0){
			GetComponent<Camera>().fieldOfView +=1;


		}
	
	}
}
