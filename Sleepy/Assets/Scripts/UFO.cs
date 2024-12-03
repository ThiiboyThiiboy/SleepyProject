using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UFO : MonoBehaviour
{
	[SerializeField]
	private float speed;

	private void Start()
	{
		speed = Random.Range(3, 6);
	}

	private void Update()
	{
		if(tag == "rightUFO")
			transform.position -= Vector3.right * speed * Time.deltaTime;
		else
			transform.position += Vector3.right * speed * Time.deltaTime;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "deader")
		{
			Destroy(gameObject);
		}
	}
}
