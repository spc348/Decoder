using UnityEngine;
using System.Collections;
using System.Globalization;

public class Keypad : MonoBehaviour
{
	public Vector2 HiddenPosition;
	public Vector2 VisualPosition;
	public bool Hidden;
	int[] valuesPressed;
	int index;
	Square[] Squares;

	// Use this for initializatio
	void Start ()
	{
		Squares = GetComponentsInChildren <Square> ();
		valuesPressed = new int[3];
		VisualPosition = Vector2.zero;
		HiddenPosition = new Vector2 (12f, 0);
		index = 0;
		Hidden = true;
		transform.position = HiddenPosition;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Hidden)
				Visualize ();
			else
				Hide ();
		}
	}

	public void SquarePressed (int number, int row)
	{
		index++;

		foreach (var item in Squares) {
			if (row == item.Row) {
				item.Disable ();
			}
			if (number == item.Number) {
				item.Activate ();
			}
		}
	}


	void Visualize ()
	{
		Hidden = false;
		LeanTween.moveLocal (gameObject, VisualPosition, 1f);
	}

	void Hide ()
	{
		Hidden = true;
		LeanTween.moveLocal (gameObject, HiddenPosition, 1f);
	}

	public void Reset ()
	{
		index = 0;
		foreach (var s in Squares) {
			s.Reset ();
		}
	}
}
