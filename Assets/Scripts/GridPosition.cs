using UnityEngine;
using System; 

public struct GridPosition : IEquatable<GridPosition>
{
	public int x; 
 	public int z; 
	

	public GridPosition(int x, int z){
		this.x = x; 
		this.z = z; 	
	}

	public override bool Equals(object obj){

		return obj is GridPosition position && 
			x == position.x && 
			z == position.z; 	

	}

	public bool Equals(GridPosition otherGridPosition){
	
		return this == otherGridPosition; 	

	}

	public override int GetHashCode(){
		
		return HashCode.Combine(this.x,this.z); 
	}
	
	public override string ToString(){
		
		return "x: " + this.x + ", z: " + this.z; 	
	
	}	
	
	public static bool operator==(GridPosition onePosition, GridPosition otherPosition){
		
		return onePosition.x == otherPosition.x && onePosition.z == otherPosition.z; 	
		
	}
	
	public static bool operator!=(GridPosition  onePosition, GridPosition otherPosition){

		return !(onePosition == otherPosition); 
		
	}

	public static GridPosition operator +(GridPosition  onePosition, GridPosition otherPosition){

		return new GridPosition(onePosition.x + otherPosition.x,onePosition.z + otherPosition.z);
	
	}

	public static GridPosition operator -(GridPosition  onePosition, GridPosition otherPosition){

		return new GridPosition(onePosition.x - otherPosition.x, onePosition.z - otherPosition.z);
		
	}
}
