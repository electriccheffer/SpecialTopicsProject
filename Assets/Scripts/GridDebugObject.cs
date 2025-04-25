using UnityEngine;
using TMPro; 

public class GridDebugObject : MonoBehaviour
{
	private GridObject gridObject; 
	[SerializeField] TextMeshPro textMeshPro; 
	
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start(){
        
	}

	public void SetGridObject(GridObject gridObject){
	
		this.gridObject = gridObject; 
	}

	// Update is called once per frame
	void Update(){
        
		if(gridObject != null){

			this.textMeshPro.text = gridObject.ToString(); 			

		}		

	}
}
