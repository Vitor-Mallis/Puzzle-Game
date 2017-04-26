using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCards : MonoBehaviour {

	[SerializeField]
	Button card;

	int puzzle1 = 6, puzzle2 = 12, puzzle3 = 18, puzzle4 = 24, puzzle5 = 30;

	List<Button> puzzle1Cards = new List<Button>();
	List<Button> puzzle2Cards = new List<Button>();
	List<Button> puzzle3Cards = new List<Button>();
	List<Button> puzzle4Cards = new List<Button>();
	List<Button> puzzle5Cards = new List<Button>();

	List<Animator> puzzle1Anim = new List<Animator>();
	List<Animator> puzzle2Anim = new List<Animator>();
	List<Animator> puzzle3Anim = new List<Animator>();
	List<Animator> puzzle4Anim = new List<Animator>();
	List<Animator> puzzle5Anim = new List<Animator>();

	void Awake() {
		CreateTheCards ();
		GetAnimators ();
	}

	void CreateTheCards() {
		for (int i = 0; i < puzzle1; i++) {
			Button obj = Instantiate (card);
			obj.name = i.ToString ();
			obj.gameObject.SetActive (false);
			puzzle1Cards.Add (obj);
		}

		for (int i = 0; i < puzzle2; i++) {
			Button obj = Instantiate (card);
			obj.name = i.ToString ();
			obj.gameObject.SetActive (false);
			puzzle2Cards.Add (obj);
		}

		for (int i = 0; i < puzzle3; i++) {
			Button obj = Instantiate (card);
			obj.name = i.ToString ();
			obj.gameObject.SetActive (false);
			puzzle3Cards.Add (obj);
		}

		for (int i = 0; i < puzzle4; i++) {
			Button obj = Instantiate (card);
			obj.name = i.ToString ();
			obj.gameObject.SetActive (false);
			puzzle4Cards.Add (obj);
		}

		for (int i = 0; i < puzzle5; i++) {
			Button obj = Instantiate (card);
			obj.name = i.ToString ();
			obj.gameObject.SetActive (false);
			puzzle5Cards.Add (obj);
		}

		LayoutCards.instance.puzzle1Cards = puzzle1Cards;
		LayoutCards.instance.puzzle2Cards = puzzle2Cards;
		LayoutCards.instance.puzzle3Cards = puzzle3Cards;
		LayoutCards.instance.puzzle4Cards = puzzle4Cards;
		LayoutCards.instance.puzzle5Cards = puzzle5Cards;
	}

	void GetAnimators() {
		for (int i = 0; i < puzzle1; i++) {
			puzzle1Anim.Add (puzzle1Cards [i].GetComponent<Animator> ());
		}

		for (int i = 0; i < puzzle2; i++) {
			puzzle2Anim.Add (puzzle2Cards [i].GetComponent<Animator> ());
		}

		for (int i = 0; i < puzzle3; i++) {
			puzzle3Anim.Add (puzzle3Cards [i].GetComponent<Animator> ());
		}

		for (int i = 0; i < puzzle4; i++) {
			puzzle4Anim.Add (puzzle4Cards [i].GetComponent<Animator> ());
		}

		for (int i = 0; i < puzzle5; i++) {
			puzzle5Anim.Add (puzzle5Cards [i].GetComponent<Animator> ());
		}

		LayoutCards.instance.puzzle1Anim = puzzle1Anim;
		LayoutCards.instance.puzzle2Anim = puzzle2Anim;
		LayoutCards.instance.puzzle3Anim = puzzle3Anim;
		LayoutCards.instance.puzzle4Anim = puzzle4Anim;
		LayoutCards.instance.puzzle5Anim = puzzle5Anim;
	}
}
