using UnityEngine;

public class MazeGridObject : GridObject 
{
 	protected bool isAlive; 
	protected bool previous; 
	
	public MazeGridObject(GridSystem gridSystem,GridPosition gridPosition,bool isAlive):
		base(gridSystem,gridPosition) {

			
		this.isAlive = isAlive; 

	}  

	public bool GetIsAlive(){
		
		return this.isAlive; 
	}	
	 
	public void SetIsAlive(bool isAlive){
		
		this.previous = this.isAlive; 
		this.isAlive = isAlive; 
	
	}

	public bool GetPrevious(){
		
		return this.previous; 
	}
	
	public GridPosition GetGridPosition(){

		return this.gridPosition; 
	}
			
	public void SetPrevious(bool previous){
		
		this.previous = previous; 
		
	}
}
