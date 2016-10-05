using UnityEngine;
using System.Collections;

public class KeypadCancel : MonoBehaviour
{
	Keypad keypad;

	void OnMouseDown ()
	{
		GetComponentInParent<Keypad> ().ToggleOff ();
	}
}
