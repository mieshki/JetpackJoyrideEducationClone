﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    [Header("MUST BE SET")]
    public Rigidbody2D playerRB;


    [Header("Player/physics settings")]
    public float forceMultiplier = 12000f;


    void MoveUp()
    {
        playerRB.AddForce(Vector2.up * Time.deltaTime * forceMultiplier);
    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if (Input.GetKey("w")) MoveUp();
	}
}
