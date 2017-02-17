using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour {
    public static int score;
    public Text textScore;
	// Use this for initialization
	void Awake () {
        score = 0;
        textScore = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        textScore.text = "Score : " + score;
	}
}
