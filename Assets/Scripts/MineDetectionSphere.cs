using UnityEngine;

public class MineDetectionSphete : MonoBehaviour
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
		
		Debug.Log("Collision! With Mine Detection Sphere");
		this.mine.GetComponent<Mine>().explode(); 	
	}
	

    }
}
