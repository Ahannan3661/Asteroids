using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour
{
    [SerializeField]
    Text Timer;
    [SerializeField]
    Text scoreText;

    int score;
    const string ScorePrefix = "Score: ";
    // game timer support
    float elapsedSeconds = 0;
    bool running = true;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        scoreText.text = ScorePrefix + score+"";
        Timer.text = "0";
    }


    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = ScorePrefix + score + "";
    }
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            Timer.text = ((int)elapsedSeconds).ToString();
        }
	}

    /// <summary>
    ///  Stops the game timer
    /// </summary>
    public void StopGameTimer()
    {
        running = false;
    }
}
