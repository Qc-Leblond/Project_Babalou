using UnityEngine;
using System.Collections;

public class Camera_Setings : MonoBehaviour {

	GameObject Player;


	void Start ()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update ()
	{
		Vector3 NewPos = Player.transform.position;
		NewPos.z -= 10;
		transform.position = NewPos;
	}
}