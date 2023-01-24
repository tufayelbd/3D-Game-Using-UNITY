function OnTriggerEnter (info : Collider){
		Destroy(gameObject);
		ScoreCount.gscore+=300;
			ScoreCount.count+=1;
		if(ScoreCount.count<3){
		  Application.LoadLevel ("asset"); 
		  }
		else
		Application.LoadLevel ("Menu"); 

}