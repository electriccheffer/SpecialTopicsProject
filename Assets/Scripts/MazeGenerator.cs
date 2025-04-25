using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    
    private MazeSystem maze; 
    [SerializeField] private int numberOfIterations; 
    private int totalIterations; 
    [SerializeField] private GameObject generatedObject; 
    	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	this.maze = new MazeSystem(100,100,1.0f,new Vector3(0f,0f,0f));	        

	for(;this.totalIterations < this.numberOfIterations;this.totalIterations++){
		
		if(this.totalIterations  < this.numberOfIterations ){
		
			this.totalIterations++; 
			this.maze.applyRules(); 
					
		}

	}

	// Create the game objects
	for(int i = 0 ; i < 100 ; i++){
		
		for(int j =0 ; j < 100 ; j++){

			MazeGridObject currentGridObject = (MazeGridObject)
								this.maze.GetGridObject(i,j);
			if(currentGridObject.GetIsAlive()){
				GridPosition currentGridObjectPosition = 
						currentGridObject.GetGridPosition(); 
				Instantiate(generatedObject,
					     new Vector3(currentGridObjectPosition.x,
				             2,currentGridObjectPosition.z),
					     Quaternion.identity);
			}
			
		
		}

	}				

    }

    // Update is called once per frame
    void Update()
    {
	    	
    }
}
