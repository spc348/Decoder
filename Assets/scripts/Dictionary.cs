using UnityEngine;
using System.Collections;

public class Dictionary : MonoBehaviour
{

	Code[] codex;

	// Use this for initialization
	void Start ()
	{
		codex = GetComponentsInChildren<Code> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
