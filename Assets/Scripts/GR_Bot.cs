using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GR_Bot : MonoBehaviour 
{

    public float nextPlayTime;
    public float delay = 2;
    private AudioSource audioSource;
    public AudioClip[] GRlines;
    private AudioClip GRClip;

	// Use this for initialization
	void Start () 
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        nextPlayTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Time.time >= nextPlayTime)
        {
            int index = Random.Range(0, GRlines.Length);
            GRClip = GRlines[index];
            audioSource.clip = GRClip;
            audioSource.Play();
            nextPlayTime = Time.time + delay;
        }
    }
}
