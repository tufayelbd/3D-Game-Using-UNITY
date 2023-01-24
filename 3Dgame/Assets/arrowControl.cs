using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowControl : MonoBehaviour {

    public Transform clubObj;
    public float zForce = 100;
    public Transform arrowObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


   

		if (Input.GetKey("a"))
        {   
            int c = 1;
			    if(c<=1){
            transform.Rotate(0, 0, -1);
            c++;
                }
       //  Destroy(gameObject);
		}
		if (Input.GetKey("d"))
		{

			transform.Rotate(0, 0, 1);

		}
		//if (Input.GetKeyDown("space"))
	//	{
			//GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
			//Instantiate(clubObj,transform.position,clubObj.rotation);
		//	GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
	//	}
	//}
	}
    public void exitBtn() {
       
        Application.Quit();
    
    }
    public void startBtn() {


        if (Input.GetButtonDown("Fire1"))
        {

            GetComponent<Rigidbody>().AddRelativeForce(0, 0, zForce);
        }
        else {

            GetComponent<Rigidbody>().AddRelativeForce(0, 0, zForce);
        
        }
      
    }
    public void leftBtn() {
        transform.Rotate(0, 0, 1);
    }
    public void rightBtn() {
        transform.Rotate(0, 0, -1);
    
    }


}
