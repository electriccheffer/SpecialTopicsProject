using UnityEngine;

public class TrackerDetectionSphere : MonoBehaviour
{
    [SerializeField] GameObject trackerBullet; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnTriggerEnter(Collider enemy){

	if(enemy.gameObject.name.StartsWith("Aircraft")){
		//
		Debug.Log("Collision! With TrackerDetectionSphere");
	
		Instantiate(trackerBullet);
		trackerBullet.GetComponent<TrackerBulletMover>().setTarget(enemy.gameObject);	
		Destroy(gameObject); 
	}
	
    } 

}
