using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GR_Bot : MonoBehaviour 
{

    private AudioSource audioSource;
    public AudioClip[] GRlines;
    private AudioClip GRClip;

	// Use this for initialization
	void Start () 
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, GRlines.Length);
            GRClip = GRlines[index];
            audioSource.clip = GRClip;
            audioSource.Play();
        }
    }
}
