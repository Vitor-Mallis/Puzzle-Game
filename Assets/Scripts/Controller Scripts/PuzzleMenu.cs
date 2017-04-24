using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMenu : MonoBehaviour {

	public static PuzzleMenu instance;

	[SerializeField]
	GameObject puzzlePanel, levelSelect;
	[SerializeField]
	Animator puzzleAnimator, levelSelectAnimator;

	string selectedPuzzle;
	int selectedLevel;

	void Awake() {
		if (instance == null)
			instance = this;
	}

	public void SelectPuzzle() {
		selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

		StartCoroutine (SelectPuzzleRoutine ());
	}

	public void Back() {
		StartCoroutine (BackRoutine());
	}

	public void ChooseLevel() {
		selectedLevel = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

		SelectLevel.instance.LoadPuzzle (selectedLevel, selectedPuzzle);
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