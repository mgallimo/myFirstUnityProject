using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime * speed);
	
	// Classes are blueprints for object-oriented programming.
	}
}
