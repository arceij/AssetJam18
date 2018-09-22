using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof ( Controller2D))]

public class Player : MonoBehaviour
{

    Vector3 velocity;

    Controller2D controller;
    private void Start()
    {
        controller = GetComponent<Controller2D>();

    }
}

	
