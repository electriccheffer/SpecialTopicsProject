using UnityEngine;

public class GridObject
{
	protected GridSystem gridSystem; 

	protected GridPosition gridPosition; 


	public GridObject(GridSystem gridSystem,GridPosition gridPosition){
		
		this.gridSystem = gridSystem; 
		this.gridPosition = gridPosition; 

	}	    

	public GridPosition getGridPosition(){
		
		return this.gridPosition; 

	}
	

	public override string ToString(){

		return this.gridPosition.ToString();
		
	}
}
