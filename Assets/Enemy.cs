using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
	}
}
