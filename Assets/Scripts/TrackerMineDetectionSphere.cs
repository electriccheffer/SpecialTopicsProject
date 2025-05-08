using UnityEngine;

public class TrackerMineDetectionSphere : MonoBehaviour
{
	[SerializeField] GameObject mine; 

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

		Debug.Log("Collision! With Tracker Mine Detection Sphere");
		mine.GetComponent<TrackerMine>().explode(enemy.gameObject); 
	}
    }
    
}
