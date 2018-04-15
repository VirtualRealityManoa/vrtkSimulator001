using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkPath : MonoBehaviour {

    //public Transform startingPoint;
    public Transform[] destinationPoints;
    public bool reverse = false;
    private int index = 0;

	// Use this for initialization
	void Start () 
    {
       // startingPoint = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (index == destinationPoints.Length)
        {
            reverse = true;
        }
        if (transform.position != destinationPoints[index].position && index < destinationPoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, destinationPoints[index].position, Time.deltaTime * 1);
 
        }
        else if(reverse == false && index != destinationPoints.Length)
        {
            index++;
        }
        else
        {
            index--;
        }

	}
}
