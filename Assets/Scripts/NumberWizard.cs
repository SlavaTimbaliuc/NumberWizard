using UnityEngine;
using System.Collections;
using System;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		
		System.Random random = new System.Random();
		guess = random.Next(min, max);
	
		print("=========================");
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("UP arrow = higher, DOWN = lower, RETURN = equal");
		
		// solves guessing 1000 edge case
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("UP arrow pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print("DOWN arrow pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
	
	void NextGuess() {
		System.Random random = new System.Random();
		guess = random.Next(min, max);
		
		print ("Higher or lower than " + guess + "?");
		print ("UP arrow = higher, DOWN = lower, RETURN = equal");
	}
}
