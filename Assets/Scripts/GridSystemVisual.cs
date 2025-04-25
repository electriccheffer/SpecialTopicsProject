using UnityEngine;
using System.Collections; 
using System.Collections.Generic; 

public class GridSystemVisual : MonoBehaviour
{
    	
	[SerializeField] protected Transform gridSystemVisualPrefab; 
	protected GridDebugObject[,] gridSystemVisualSingleArray; 
	protected GridSystem gridSystem; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	gridSystemVisualSingleArray = new GridDebugObject[gridSystem.GetWidth(),gridSystem.GetHeight()];
	
	for(int x = 0 ; x < gridSystem.GetWidth() ; x++){
		
		for(int z = 0 ; z < gridSystem.GetHeight()  ; z++){
			
			GridPosition gridPosition = new GridPosition(x,z);
			Transform gridSystemVisualSingleTransform = 
				Instantiate(gridSystemVisualPrefab,gridSystem.GetWorldPosition(gridPosition),Quaternion.identity);
	
			gridSystemVisualSingleTransform.parent = this.transform; 
			gridSystemVisualSingleTransform.localScale *= gridSystem.GetCellSize(); 
			gridSystemVisualSingleArray[x,z] = gridSystemVisualSingleTransform.GetComponent<GridDebugObject>();
			gridSystemVisualSingleArray[x,z].SetGridObject(this.gridSystem.GetGridObject(x,z));	
		}
			
	} 
    }

    // Update is called once per frame
    void Update()
    {
    	    
    }

	
	public void SetGridSystem(GridSystem gridSystem){
		
		this.gridSystem = gridSystem; 

	}
}
