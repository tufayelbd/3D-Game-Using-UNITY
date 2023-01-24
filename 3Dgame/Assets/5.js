function OnTriggerEnter (info : Collider){

		///private var count: int=1;
			
		Destroy(gameObject);

		ScoreCount.gscore+=5;
		//count+=1;
		ScoreCount.count+=1;
		if(ScoreCount.count<3){
		  Application.LoadLevel ("asset"); 
		  }
		else
		Application.LoadLevel ("Menu"); 

	//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
}