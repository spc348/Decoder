using UnityEngine;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;

public class Keypad : MonoBehaviour
{
	public Vector2 HiddenPosition;
	public Vector2 VisualPosition;
	public bool Hidden;
	public LetterArray letters;
	int index;
	KeypadSquare[] squares;

	void Start ()
	{
		VisualPosition = Vector2.zero;
		HiddenPosition = new Vector2 (25f, 0);
		Hidden = true;
		index = -1;
		transform.position = HiddenPosition;
		squares = GetComponentsInChildren<KeypadSquare> ();
	}

	public void ToggleOn (int id)
	{
		index = id;
		if (Hidden)
			Visualize ();
		else
			Hide ();
	}

	public void ToggleOff ()
	{
		if (!Hidden)
			Hide ();
		else
			Visualize ();
	}

	public void Accepted (string letter)
	{
		letters.AddLetterToHex (index, letter);
		Hide ();
	}

	void Visualize ()
	{
		Hidden = false;
		LeanTween.moveLocal (gameObject, VisualPosition, .3f);
		foreach (var item in squares) {
			item.Activate ();
		}
	}

	void Hide ()
	{
		Hidden = true;
		LeanTween.moveLocal (gameObject, HiddenPosition, .3f);
	}
}
