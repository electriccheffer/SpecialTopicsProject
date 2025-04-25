using UnityEngine;

public class GridSystemVisualSingle : MonoBehaviour
{
	[SerializeField] private MeshRenderer meshRenderer; 
	    
// Start is called once before the first execution of Update after the MonoBehaviour is created

	public void Show(){
	
		meshRenderer.enabled = true; 
		
	}

	public void Hide(){

		meshRenderer.enabled = false; 
		
	}
	

 
}
