﻿using UnityEngine;
using System.Collections;

public class ItemScript : MonoBehaviour 
{
	public GameObject[] itemArray = new GameObject[10];
	public int counter = 0;
	//public bool isActive;

	// Use this for initialization
	void Start () 
	{
		//itemArray [0] = GameObject.Find ("Key");
		//itemArray = GameObject.FindGameObjectsWithTag ("Item");
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{

		itemArray[counter] = this.gameObject;
		Debug.Log("You picked up: " + itemArray[counter].name);
		counter ++;

		this.gameObject.SetActive (false);
			//Debug.Log ("THIS ITEM IS COLLECTED");
		//isActive = false;

	}
}
