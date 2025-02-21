using UnityEngine;

public class Fire : MonoBehaviour
{
	
    GameObject target; 
    [SerializeField] GameObject bullet; 
    private float totalTime = 0f; 
    private float fireTime = 1f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.target != null){
		
		this.totalTime += Time.deltaTime; 
		if(this.totalTime > this.fireTime){

			this.bullet = Instantiate(this.bullet,this.transform.position,this.transform.rotation);		
			this.bullet.GetComponent<BulletMover>().SetTarget(this.target);
			this.fireTime += 1f; 
		}	

	}
    }
    
    public void FireAt(GameObject target){
	this.target = target; 	
    }
}
