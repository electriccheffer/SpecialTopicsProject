using UnityEngine;

public class ParticleSensor : MonoBehaviour
{

    [SerializeField] GameObject enemy; 

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
		
		Debug.Log("Collision! With sense sphere"); 
		transform.parent.Find("ObservationPoint").GetComponent<TurretFacer>().FaceTarget(enemy.gameObject); 			
	}
    }
}
