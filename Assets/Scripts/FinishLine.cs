using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter()
	{
		GameManager.instance.Win ();

	}
}
