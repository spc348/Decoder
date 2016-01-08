using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour
{
	public int Number;
	public int Row;
	Dot dotChild;
	SpriteRenderer dotRend, squareRend;
	Keypad keypad;
	BoxCollider2D col;

	void Start ()
	{
		dotChild = GetComponentInChildren <Dot> ();
		dotChild.Pressed = false;
		dotRend = dotChild.GetComponent <SpriteRenderer> ();
		dotRend.enabled = false;
		keypad = GetComponentInParent <Keypad> ();
		squareRend = GetComponent <SpriteRenderer> ();
		col = GetComponent <BoxCollider2D> ();
	}

	void HideSquare ()
	{
		squareRend.enabled = false;
	}

	public void Reset ()
	{
		squareRend.enabled = true;
		dotChild.Pressed = false;
		dotRend.enabled = false;
		col.enabled = true;
	}

	public void Disable ()
	{
		squareRend.enabled = false;
		dotRend.enabled = false;
		col.enabled = false;
	}

	public void Activate ()
	{
		squareRend.enabled = true;
		dotChild.Pressed = false;
		dotRend.enabled = false;
		col.enabled = true;
	}

	void Hide ()
	{
		LeanTween.alpha (dotChild.gameObject, 0f, 1f);
		dotChild.Pressed = false;
		dotRend.enabled = false;
	}

	void Pressed ()
	{
		keypad.SquarePressed (Number, Row);
		dotRend.enabled = true;
		LeanTween.alpha (dotChild.gameObject, 1f, 1f);
		dotChild.Pressed = true;
	}

	void OnMouseDown ()
	{
		if (!dotChild.Pressed)
			Pressed ();
	}

}
