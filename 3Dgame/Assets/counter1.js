function OnTriggerEnter (info : Collider){
		Destroy(gameObject);
		ScoreCount.gscore=00;
			ScoreCount.count+=1;
		
		Application.LoadLevel ("Menu"); 

}
