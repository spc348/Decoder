using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeypadSquare : MonoBehaviour
{
	public string Letter;
	SpriteRenderer squareRend;
	Keypad keypad;
	BoxCollider2D col;
	Text squareText;

	void Start ()
	{
		keypad = GetComponentInParent <Keypad> ();
		squareRend = GetComponent <SpriteRenderer> ();
		col = GetComponent <BoxCollider2D> ();

		squareText = GetComponentInChildren<Text> ();
		squareText.text = Letter;

		Activate ();
	}

	void HideSquare ()
	{
		squareRend.enabled = false;
	}

	public void Disable ()
	{
		squareRend.enabled = false;
		col.enabled = false;
	}

	public void Activate ()
	{
		squareRend.enabled = true;
		col.enabled = true;
	}

	void OnMouseDown ()
	{
		keypad.Accepted (Letter);
		col.enabled = false;
	}

}
