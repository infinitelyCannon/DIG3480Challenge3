﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    private AudioSource sound;

	// Use this for initialization
	void Start () {
        sound = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
	}
	
	void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        sound.Play();
    }
}
