using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameContreoll : MonoBehaviour {
    public Text welcome;
    public GameObject canvas;
	// Use this for initialization
	void Start () {
        DisplayText("Welcome");
        StartCoroutine("DestroyMessage");
      
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void DisplayText(string welcomeString)
    {

        welcome.text = welcomeString;
       
    }

    IEnumerator DestroyMessage()
    {
        yield return new WaitForSeconds(2.5f);

        canvas.SetActive(false);

    }
}
