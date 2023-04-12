using System.Collections;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
	}
}
