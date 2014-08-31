using UnityEngine;
using System.Collections;

public class Character_Controller : MonoBehaviour 
{
    private float CharMaxSpeed = 4f;
    private float CharMouvForce = 20f;

    void Awake()
    {
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy")); //Disable Collision Between Characters and Enemies
    }

    void Update()
    {
        //Mouvement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h * rigidbody2D.velocity.x < CharMaxSpeed)
        {
            rigidbody2D.AddForce(Vector2.right * h * CharMouvForce);
        }
        if (h * rigidbody2D.velocity.x < CharMaxSpeed)
        {
            rigidbody2D.AddForce(Vector2.up * v * CharMouvForce);
        }

		RotationToMouse();
    }
	
	//Rotation To Mouse
	void RotationToMouse()
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.2f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
	}
}
