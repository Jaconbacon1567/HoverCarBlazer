using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public GUIText ScoreText;
    private int _scoreAm;

	// Use this for initialization
	void Start ()
	{
	    _scoreAm = 0;
        UpdateScore();
	}

    void AddScore()
    {
        
    }

    void UpdateScore()
    {
        ScoreText.text = "Score: " + _scoreAm;
    }

}
