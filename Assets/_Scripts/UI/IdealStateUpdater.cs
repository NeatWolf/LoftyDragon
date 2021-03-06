﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IdealStateUpdater : MonoBehaviour 
{
	[SerializeField]
	private InputManager inputManager;

	private Text text;

	void Start()
	{
		text = this.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () 
	{
		text.text = inputManager.IdealState.ToString();
	}
}
