using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour {

	[SerializeField]
	GameObject settingsPanel;
	[SerializeField]
	Animator settingsAnimator;

	public void OpenSettings() {
		settingsPanel.SetActive (true);
		settingsAnimator.Play ("SlideIn");
	}

	public void CloseSettings() {
		StartCoroutine (CloseSettingsRoutine ());
	}

	IEnumerator CloseSettingsRoutine() {
		settingsAnimator.Play ("SlideOut");
		yield return new WaitForSeconds (.5f);
		settingsPanel.SetActive (false);
	}
}
