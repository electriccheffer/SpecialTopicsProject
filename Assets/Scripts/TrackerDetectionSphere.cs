using UnityEngine;

public class TrackerDetectionSphere : MonoBehaviour
{
    [SerializeField] GameObject trackerBullet;
    [SerializeField] GameObject currentBullet; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnTriggerEnter(Collider enemy){

	if(this.currentBullet == null){

		Destroy(this.currentBullet); 
	}	
		
	if(enemy.gameObject.name.StartsWith("Aircraft") ){
		//
		Debug.Log("Collision! With TrackerDetectionSphere");
	
		this.currentBullet = Instantiate(trackerBullet);
		this.currentBullet.GetComponent<TrackerBulletMover>().setTarget(enemy.gameObject);	
	}
	
    } 

}
