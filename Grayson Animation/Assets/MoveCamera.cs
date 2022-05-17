using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
	public Transform center;
    public float panSpeed = 100f;
    void Update()
    {
    	transform.LookAt(center);
    	transform.RotateAround(center.position, Vector3.up, panSpeed*Time.deltaTime);
    }
}
