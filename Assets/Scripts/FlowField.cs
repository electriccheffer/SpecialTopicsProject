using UnityEngine;

public class FlowField : MonoBehaviour
{
	
	private GridSystem gridSystem; 
	[SerializeField] GameObject childObject; 
	[SerializeField] Transform debugObjectTransform; 	

	public void Awake(){
		
		this.gridSystem = new GridSystem(100,100,1,this.transform.position);
		childObject.GetComponent<GridSystemVisual>().SetGridSystem(this.gridSystem);
	}	

    	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{	
				
	}

    	// Update is called once per frame
	void Update()
	{
        
		gridSystem.SetOrigin(this.transform.position);
		gridSystem.drawDebugLines(); 
	}
}
