using UnityEngine;
using System.Collections.Generic; 

public class TrackerMine : MonoBehaviour
{

	[SerializeField] GameObject bullet; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	        
    }

    // Update is called once per frame
    void Update()
    {
     }

    public void explode(GameObject target){

	// Instantiate a bullet going in each of the directions		
	Vector3 directionOne = Vector3.up; 
	Vector3 directionTwo = Vector3.down; 
 	Vector3 directionThree = Vector3.left; 
	Vector3 directionFour = Vector3.right; 
	Vector3 directionFive = Vector3.forward; 
	Vector3 directionSix = Vector3.back;

	List<Vector3> directions = new List<Vector3>{directionOne,directionTwo,
						     directionThree,directionFour,
						     directionFive, directionSix}; 
	foreach(Vector3 direction in directions){

		GameObject newBullet = Instantiate(this.bullet,this.transform.position,Quaternion.identity);
		newBullet.GetComponent<TrackerMineBullet>().setInitialDirection(direction);
		newBullet.GetComponent<TrackerMineBullet>().setTarget(target);
		
	}	
	Destroy(this.gameObject); 	
 


 
    }

}
