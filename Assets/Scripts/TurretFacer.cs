using UnityEngine;

public class TurretFacer : MonoBehaviour
{
    GameObject target; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.target != null){
		Debug.Log("Target's position: "+this.target.transform.position);	
		Debug.Log("Turrets position: "+this.transform.position);
		this.transform.LookAt(this.target.transform.position - this.transform.position);
		this.transform.rotation *= Quaternion.Euler(260f,0f,-110f);
	}
	
    }
	
    public void FaceTarget(GameObject target){

		this.target = target;
		this.transform.Find("Cannon").GetComponent<Fire>().FireAt(target); 
    }
}
