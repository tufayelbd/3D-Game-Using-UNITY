using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControll : MonoBehaviour
{
	public Transform clubObj;
	public float zForce = 100;
	public Transform arrowObj;


   


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

		if (Input.GetButtonDown("Fire1")) {

			GetComponent<Rigidbody>().AddRelativeForce (0,0,zForce);
		}
        if (Input.GetButtonDown("Fire2"))
        {
            Application.Quit();
        }
        if (Input.GetButtonDown("q"))
        {

            Debug.Log("Quit!");
            Application.Quit();
        }
		else if (Input.GetKeyDown("space"))
		{
			GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			//Instantiate(clubObj,transform.position,clubObj.rotation);
			GetComponent<Transform>().eulerAngles = new Vector3(0,0,0);
			arrowObj.GetComponent<Transform>().position = transform.position;
		}
		if (Input.GetKeyDown("a"))
		{
			transform.Rotate(0, -1, 0);

		}
		if (Input.GetKeyDown("d"))
		{

			transform.Rotate(0, 1, 0);

		}
		if (Input.GetKey("w")) {
            Debug.Log("Quit!");
            Application.Quit();
		
		}
		if (Input.GetKey("s"))
		{
			zForce -= 5;

		}



	}
 
	void OnTriggerEnter(Collider other)
	{

		if (other.name == "cup")
		{
			Debug.Log("Completed");
			GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
			//StartCoroutine(delayLoad());

		}

	}

}