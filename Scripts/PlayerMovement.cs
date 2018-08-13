using System;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof (ThirdPersonCharacter))]
public class PlayerMovement : MonoBehaviour
{
	[SerializeField] float walkMoveStopRadius = 0.2f;
	[SerializeField] float attackMoveRadius = 4f;


    ThirdPersonCharacter thirdPersonChar;   // A reference to the ThirdPersonCharacter on the object
    CameraRaycaster cameraRaycaster;
	Vector3 currentDestination, clickPoint;

        
	bool isInDirectMode = false;






	private void Start()
    {
        cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
		thirdPersonChar = GetComponent<ThirdPersonCharacter>();
        currentDestination = transform.position;
    }




	private void FixedUpdate()
	{
		if(Input.GetKeyDown(KeyCode.G)){ //G for Gamepad

			isInDirectMode = !isInDirectMode; //toggles the mode
			currentDestination = transform.position; //clear clickTarget
		}


		if (isInDirectMode) {
			ProcessDirectMovement ();
		}

		else {
			ProcessMouseMovement ();
		}
			
	}





	//controller/WSAD
	private void ProcessDirectMovement() {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		// calculate camera relative direction to move:
		Vector3 camForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
		Vector3 movement = v*camForward + h* Camera.main.transform.right;

		thirdPersonChar.Move (movement, false, false);

	}


	//mouse
	private void ProcessMouseMovement ()
	{
		if (Input.GetMouseButton (0)) {
			//print ("Cursor raycast hit layer: " + cameraRaycaster.layerHit);
			clickPoint = cameraRaycaster.hit.point;
			switch (cameraRaycaster.currentLayerHit) {
			case Layer.Walkable:
				currentDestination = ShortDestination(clickPoint,walkMoveStopRadius);
				break;
			case Layer.Enemy:
				currentDestination = ShortDestination(clickPoint, attackMoveRadius);
				break;
			default:
				print ("error");
				return;
			}
		}

		WalkToDestination ();
	}




	void WalkToDestination ()
	{
		var playerToClickPoint = currentDestination - transform.position;
		//if (playerToClickPoint.magnitude >= walkMoveStopRadius) { <----old code
		if (playerToClickPoint.magnitude >= 0.25) {               //updated, I think it performs the same
			thirdPersonChar.Move (playerToClickPoint, false, false);
		}
		else {
			thirdPersonChar.Move (Vector3.zero, false, false);
		}
	}




	Vector3 ShortDestination(Vector3 destination, float shortening){
		Vector3 reductionVector = (destination-transform.position).normalized*shortening;
		return destination-reductionVector;
	}



	void OnDrawGizmos(){

		Gizmos.color = Color.green;
		Gizmos.DrawLine (transform.position, currentDestination);
		Gizmos.DrawSphere (currentDestination, 0.1f);
		Gizmos.DrawSphere (clickPoint,0.2f);

		//Gizmos.color = Color.red;
		//Gizmos.DrawSphere (transform.position, attackMoveRadius);


		
	}

}

