using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayoutCards : MonoBehaviour {

	public static LayoutCards instance;

	[HideInInspector]
	public List<Button> puzzle1Cards, puzzle2Cards, puzzle3Cards, puzzle4Cards, puzzle5Cards;
	[HideInInspector]
	public List<Animator> puzzle1Anim, puzzle2Anim, puzzle3Anim, puzzle4Anim, puzzle5Anim;

	[SerializeField]
	GameObject puzzle1Panel, puzzle2Panel, puzzle3Panel, puzzle4Panel, puzzle5Panel;

	[SerializeField]
	Sprite candyBack, foodBack, transportBack;

	void Awake() {
		if (instance == null)
			instance = this;
	}

	public void LayoutTheCards(int level, string puzzle) {
		List<Button> cards = new List<Button>();
		GameObject panel = new GameObject();

		puzzle1Panel.SetActive (false);
		puzzle2Panel.SetActive (false);
		puzzle3Panel.SetActive (false);
		puzzle4Panel.SetActive (false);
		puzzle5Panel.SetActive (false);

		switch (level) {
		case 1:
			cards = puzzle1Cards;
			panel = puzzle1Panel;
			break;
		case 2:
			cards = puzzle2Cards;
			panel = puzzle2Panel;
			break;
		case 3:
			cards = puzzle3Cards;
			panel = puzzle3Panel;
			break;
		case 4:
			cards = puzzle4Cards;
			panel = puzzle4Panel;
			break;
		case 5:
			cards = puzzle5Cards;
			panel = puzzle5Panel;
			break;
		default:
			break;
		}

		panel.SetActive (true);

		foreach (Button card in cards) {
			card.gameObject.transform.SetParent (panel.transform, false);
			card.gameObject.SetActive (true);
		}

		if (puzzle == "Candy Puzzle") {
			foreach (Button card in cards)
				card.image.sprite = candyBack;
		} else if (puzzle == "Food Puzzle") {
			foreach (Button card in cards)
				card.image.sprite = foodBack;
		} else if (puzzle == "Transport Puzzle") {
			foreach (Button card in cards)
				card.image.sprite = transportBack;
		}
	}
}
