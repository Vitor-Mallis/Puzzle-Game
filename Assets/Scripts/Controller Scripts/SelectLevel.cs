using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour {

	public static SelectLevel instance;

	[SerializeField]
	GameObject levelSelect, levelPanel;

	[SerializeField]
	Animator levelSelectAnimator, levelAnimator;

	int selectedLevel;

	int puzzle1 = 6, puzzle2 = 12, puzzle3 = 18, puzzle4 = 24, puzzle5 = 30;

	void Awake() {
		if(instance == null)
			instance = this;
	}

	public void LoadPuzzle(int level, string puzzle) {
		StartCoroutine (LoadLevelRoutine ());


	}
		
	public void Back() {
		StartCoroutine (BackRoutine ());
	}

	IEnumerator BackRoutine() {
		levelAnimator.Play ("SlideOut");
		levelSelect.SetActive (true);
		levelSelectAnimator.Play ("SlideIn");
		yield return new WaitForSeconds (.5f);
		levelPanel.SetActive (false);
	}

	IEnumerator LoadLevelRoutine() {
		levelSelectAnimator.Play ("SlideOut");
		levelPanel.SetActive (true);
		levelAnimator.Play ("SlideIn");
		yield return new WaitForSeconds (.5f);
		levelSelect.SetActive (false);
	}

}
