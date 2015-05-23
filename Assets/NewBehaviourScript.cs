using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
	public const int SPEED = 5;

	private void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis ("Vertical");
		transform.Translate(Vector3.right * x * SPEED * Time.deltaTime);
		transform.Translate(Vector3.forward * y * SPEED * Time.deltaTime);
	}
}