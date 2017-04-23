using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMenu : MonoBehaviour {

	[SerializeField]
	GameObject puzzlePanel;
	[SerializeField]
	Animator puzzleAnimator;

	string selectedPuzzle;

	public void SelectPuzzle() {
		selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

		Debug.Log (selectedPuzzle);
	}
}
