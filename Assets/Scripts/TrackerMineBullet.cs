using UnityEngine;

public class TrackerMineBullet : MonoBehaviour
{
    [SerializeField] GameObject target;  
    [SerializeField] float velocity; 
    [SerializeField] float timeToLive; 
    [SerializeField] float initialMovementTime;
    float timeAlive = 0f; 
    Vector3 direction; 
   


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
	if(this.target != null && this.timeAlive > this.initialMovementTime){
		
		Vector3 normalizedVelocityDirection = (target.transform.position - this.transform.position).normalized; 
		this.transform.position += (this.velocity * normalizedVelocityDirection);
		return; 
	}	
	if(this.target != null && this.timeAlive < this.initialMovementTime){
		
		this.transform.position += (this.velocity * direction); 
		
	}
	
    }

   public void setTarget(GameObject target){

	this.target = target; 
	
	}

   public void setInitialDirection(Vector3 direction){

	this.direction = direction; 

   }
}
