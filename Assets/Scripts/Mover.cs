using UnityEngine;

public class Mover : MonoBehaviour
{ 
    public float accellerationConstant = .5f; 
    public float rotationConstant = 1.5f; 
    Vector3 yRotation; 
    Vector3 zRotation; 
    Vector3 xRotation; 
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	yRotation = new Vector3(0f,rotationConstant,0f);
	zRotation = new Vector3(0f,0f,rotationConstant); 
	xRotation = new Vector3(rotationConstant,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetKey(KeyCode.W)){
		this.transform.position += this.transform.forward * accellerationConstant * 4; 
		Debug.Log("W Key Pressed Moving Forward");
	}
	if(Input.GetKey(KeyCode.S)){
		this.transform.position += -this.transform.forward * accellerationConstant;
		Debug.Log("S Key Pressed Moving Backward");
	}
	if(Input.GetKey(KeyCode.UpArrow)){
		this.transform.Rotate(-xRotation);
		Debug.Log("Up Key Pressed Moving Up");
	}
	if(Input.GetKey(KeyCode.DownArrow)){
		this.transform.Rotate(xRotation);
		Debug.Log("Down Key Pressed Moving Down");
	}
	if(Input.GetKey(KeyCode.LeftArrow)){
		this.transform.Rotate(-yRotation);	
		Debug.Log("Left Key Pressed Turning Left");
	}
	if(Input.GetKey(KeyCode.RightArrow)){
		this.transform.Rotate(yRotation);
		Debug.Log("Right Key Pressed Turning Right");
	}
        if(Input.GetKey(KeyCode.RightShift)){
		this.transform.Rotate(-zRotation); 
		Debug.Log("Right Shift Pressed Rotating Right");
	}
	if(Input.GetKey(KeyCode.LeftShift)){
		this.transform.Rotate(zRotation); 
		Debug.Log("Left Shift Pressed Rotation Left");
	}
	this.transform.position += this.transform.forward * accellerationConstant; 		        	        
    }

}
