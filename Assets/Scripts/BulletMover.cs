using UnityEngine;

public class BulletMover : MonoBehaviour
{
    
    [SerializeField] private float accelleration; 
    Vector3 velocity; 
    private float totalTime = 0f; 
    private float deathTime = 3f; 
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(this.velocity != Vector3.zero){

		this.transform.position += accelleration * this.velocity * Time.deltaTime;  
       		Debug.Log("Bullet velocity is " + (accelleration * this.velocity)); 
	}
	this.totalTime += Time.deltaTime; 

	if(this.totalTime > this.deathTime){
		
		Destroy(gameObject); 

	}      
    }

    public void SetTarget(GameObject target){

	this.velocity = (target.transform.position - this.transform.position).normalized;	
	Debug.Log("The velocity is " + this.velocity );
    }

    public void SetDirection(Vector3 direction){

	this.velocity = direction; 

    }
}
