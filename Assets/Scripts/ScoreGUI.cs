using UnityEngine;
using System.Collections;

public class ScoreGUI : MonoBehaviour {

    public GUIText ScoreText;
    private float _scoreAm;

	// Use this for initialization
	void Start ()
	{
	    _scoreAm = 0;
        UpdateScore();
	}

    void AddScore()
    {
        _scoreAm +=  _scoreAm * Time.deltaTime;
    }

    void UpdateScore()
    {
        ScoreText.text = "Score: " + _scoreAm;
    }

}
