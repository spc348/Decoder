using UnityEngine;
using System.Collections;

public class KeypadCancel : MonoBehaviour
{

	void OnMouseDown ()
	{
		GetComponentInParent <Keypad> ().Reset ();
	}
}
