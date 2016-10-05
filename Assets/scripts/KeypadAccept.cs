using UnityEngine;
using System.Collections;

public class KeypadAccept : MonoBehaviour
{
	public string PressedLetter{ get; set; }

	void OnMouseDown ()
	{
		if (!string.IsNullOrEmpty (PressedLetter)) {
			GetComponentInParent<Keypad> ().Accepted (PressedLetter);
		}
	}
}
