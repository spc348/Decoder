using UnityEngine;
using System.Collections;

public class SquareParent : MonoBehaviour
{

	KeypadSquare[] squares;
	string[] Letters = { "A", "C", "E", "F", "N", "T", "I", "O", "Y" };

	// Use this for initialization
	void Awake ()
	{
		squares = GetComponentsInChildren<KeypadSquare> ();
		for (int i = 0; i < squares.Length; i++) {
			squares [i].Letter = Letters [i];
		}
	}

}
