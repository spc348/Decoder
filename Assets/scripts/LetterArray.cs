using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LetterArray : MonoBehaviour
{
	HexagonalButton[] letters;

	// Use this for initialization
	void Start ()
	{
		letters = GetComponentsInChildren<HexagonalButton> ();
	}

	public void AddLetterToHex (int index, string letter)
	{
		print (index.ToString () + " , " + letter);
		letters [index].GetComponentInChildren<Text> ().text = letter;
	}
}
