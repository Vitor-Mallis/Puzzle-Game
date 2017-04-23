using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMenu : MonoBehaviour {

	[SerializeField]
	GameObject puzzlePanel, levelSelect;
	[SerializeField]
	Animator puzzleAnimator, levelSelectAnimator;

	string selectedPuzzle;

	public void SelectPuzzle() {
		selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

		Debug.Log (selectedPuzzle);

		StartCoroutine (SelectPuzzleRoutine ());
	}

	public void Back() {
		StartCoroutine (BackRoutine());
	}

	IEnumerator SelectPuzzleRoutine() {
		puzzleAnimator.Play ("SlideOut");
		yield return new WaitForSeconds (.5f);
		puzzlePanel.SetActive (false);
		levelSelect.SetActive (true);
		levelSelectAnimator.Play ("SlideIn");
	}

	IEnumerator BackRoutine() {
		levelSelectAnimator.Play ("SlideOut");
		yield return new WaitForSeconds (.5f);
		levelSelect.SetActive (false);
		puzzlePanel.SetActive (true);
		puzzleAnimator.Play ("SlideIn");
	}
}
