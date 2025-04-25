using UnityEngine;

public class GridSystem
{
	protected int width; 
	protected int height; 
	protected float cellSize; 
	protected Vector3 origin; 
	protected GridObject[,] gridObjectArray; 
	
	
	public GridSystem(){}
	
	public GridSystem(int width, int height,float cellSize,Vector3 origin){
	
		this.width = width; 
		this.height = height; 
		this.cellSize = cellSize; 
		this.origin = origin; 
		
		this.gridObjectArray = new GridObject[width,height]; 
		
		for(int x = 0;  x < this.width; x++){
			for(int z = 0 ; z < this.height ; z++){
				
				GridPosition gridPosition = new GridPosition(x,z);
				gridObjectArray[x,z] = new GridObject(this,gridPosition);
	
			}
		}	

	}

	public float GetCellSize(){return this.cellSize;}
	
	public int GetHeight(){return this.height;}

	public int GetWidth(){return this.width;}

	public void drawDebugLines(){
		for(int x = 0 ; x < this.width ; x++){
			
			for(int z = 0 ; z < this.height  ; z++){
			
				Debug.DrawLine(GetWorldPosition(x,z),GetWorldPosition(x,z) + Vector3.right * 0.2f,Color.white,0.1f);					
	
			}
		
		}
	}


	public GridObject GetGridObject(int x, int z){
		
		return this.gridObjectArray[x,z];

	}
	
	public Vector3 GetWorldPosition(GridPosition gridPosition){

		return new Vector3(gridPosition.x,0,gridPosition.z) * cellSize + origin; 	
	
	}


	public Vector3 GetWorldPosition(int x, int z){
		
		return GetWorldPosition(GetGridPosition(x,z)); 
		
	}
	

	public GridPosition GetGridPosition(int x, int z){
			
		return gridObjectArray[x,z].getGridPosition(); 
		
	}

	
	public void SetOrigin(Vector3 origin){
			
		this.origin = origin; 
	}
	
}
