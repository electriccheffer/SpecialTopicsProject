using UnityEngine;

public class TrackerBulletMover : MonoBehaviour
{
    [SerializeField] GameObject target;  
    [SerializeField] float velocity; 
    
    // initial follow time
    [SerializeField] float upwardMovementTime; 
  
    // death time 
    [SerializeField] float timeToLive; 
    float timeAlive = 0f; 

    // 
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){

	this.timeAlive += Time.deltaTime; 
	if(this.timeAlive >= this.timeToLive){
	
		Destroy(gameObject); 
	}	
		
	// calculate the velocity vector based on the current position of bullet and target.  Normalize it. 
	if(this.target != null && this.upwardMovementTime <= this.timeAlive){
		
		Vector3 normalizedVelocityDirection = (target.transform.position - this.transform.position).normalized; 
		this.transform.position += (this.velocity * normalizedVelocityDirection);
		return; 
	}	
	if(this.target != null && this.upwardMovementTime >= this.timeAlive){
	
		this.transform.position += (this.velocity * Vector3.up); 	
	}
    }

    public void setTarget(GameObject target){
	this.target = target; 

    }

}
