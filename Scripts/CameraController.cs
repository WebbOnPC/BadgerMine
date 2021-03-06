using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Player thePlayer;

	private Vector3 lastPlayerPosition;
	private float distanceXToMove;
    private float distanceYToMove;

    void Start () 
	{
		thePlayer = FindObjectOfType<Player>();
		lastPlayerPosition = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
        distanceYToMove = thePlayer.transform.position.y - lastPlayerPosition.y;
        distanceXToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceXToMove, transform.position.y + distanceYToMove, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;
    }
}
