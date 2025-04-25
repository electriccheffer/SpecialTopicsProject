using UnityEngine;

public class MazeSystem : GridSystem
{
   	GridPosition[] neighborsAddingArray = {new GridPosition(-1,1),new GridPosition(0,1),
					       new GridPosition(-1,0),new GridPosition(1,0),
					       new GridPosition(-1,-1),new GridPosition(0,-1),
					       new GridPosition(1,-1)};
	 
	public MazeSystem(int width, int height, float cellSize,Vector3 origin):base(){
		
		this.width = width; 
		this.height = height; 
		this.cellSize = cellSize; 
		this.origin = origin; 
	
		this.gridObjectArray = new MazeGridObject[width,height];
			
	
		for(int i = 0 ; i < this.width  ; i++){

		
			for(int j = 0 ; j < this.height ; j++){
				int rand = Random.Range(1,100); 	
				if(rand  % 4 == 0){
				
					this.gridObjectArray[i,j] = new MazeGridObject(this,
								     new GridPosition(i,j),
								     true); 	

				}
				else{
					this.gridObjectArray[i,j] = new MazeGridObject(this,
								     new GridPosition(i,j),
								     false);	

				}				
	
			}

		}		
		
	}	
	

	public void applyRules(){
			
		MazeGridObject[,] replacementGrid = new MazeGridObject[this.width,this.height];	

		for(int i = 0 ; i < this.width ; i++){

			for(int j = 0 ; j < this.height  ; j++){
					
				MazeGridObject currentMazeGridObject = 
						(MazeGridObject)this.gridObjectArray[i,j];
				bool currentStatus = currentMazeGridObject.GetIsAlive(); 
				GridPosition currentPosition = currentMazeGridObject.
								GetGridPosition();
				
				int neighborCount = getNeighbors(currentPosition);
				if(currentStatus){
					
					if(neighborCount > 3  || neighborCount < 2){
						
						currentMazeGridObject.SetIsAlive(false); 
		
					}
	
				}
				else{

					if(neighborCount == 3){
					
						currentMazeGridObject.SetIsAlive(true); 
					
					}				
		
				}
			}		

		}			
		
	}

	private int getNeighbors(GridPosition position){


		int neighborCount = 0; 
		int xPosition = position.x; 
		int zPosition = position.z;
		int sizeOfNeighborsArray = this.neighborsAddingArray.Length; 
		foreach(GridPosition neighborPosition in neighborsAddingArray){
		
			if(neighborPosition.x + xPosition < 0 
		           || neighborPosition.z + zPosition < 0){
				continue; 

			}
			if(neighborPosition.x + xPosition >= this.width || 
			   neighborPosition.z + zPosition >= this.height){
				continue; 

			}
			

			MazeGridObject neighbor = (MazeGridObject)this.GetGridObject(
								neighborPosition.x + xPosition,
								neighborPosition.z + zPosition);
			if(neighbor.GetIsAlive()){
				neighborCount++; 				
			}				
			

		}		
		return neighborCount; 
	}
	 
}
