using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HexagonalButton : MonoBehaviour
{
	public Keypad keyPad;
	public int id;

	void OnMouseDown ()
	{
		if (keyPad.isActiveAndEnabled)
			keyPad.ToggleOn (id);
		else {
			keyPad.enabled = true;
			keyPad.ToggleOn (id);
		}
	}
}
