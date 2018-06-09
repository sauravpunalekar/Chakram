using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour
{
    public static bool isCollision = false;
    public Text levelUp;
    public Text score;
    public Button continueButton;

    // Use this for initialization
    void Start()
    {
        levelUp.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        score.gameObject.SetActive(true);
        continueButton.onClick.AddListener(delegate
        {
            Time.timeScale = 1;
            levelUp.gameObject.SetActive(false);
            continueButton.gameObject.SetActive(false);
            score.gameObject.SetActive(true);
            isCollision = false;
        });
    }

    // Update is called once per frame
    void Update()
    {
        /*if (!isCollision) {
		} else {
			if (myScore.fontSize < 300) {
				if (ScoreCount.score == 0 || ScoreCount.score == 9) {
					if (ScoreCount.score == 0) {
						myScore.text = "Level Up!";
					} else {
						myScore.text = "You Win";
						SceneManager.LoadScene ("GameOver");
						CanvasScript.t1 = "You Win!";
					}
				} else {
					myScore.text = ScoreCount.score.ToString ();
				}

				myScore.fontSize += 11;
			} else {
				isCollision = false;
				myScore.text = "";
				myScore.fontSize = 14;
			}
		}*/

        if (isCollision)
        {
            if (ScoreCount.score == 0)
            {
                Time.timeScale = 0;
                levelUp.gameObject.SetActive(true);
                continueButton.gameObject.SetActive(true);
                score.gameObject.SetActive(false);
            }
            else if (ScoreCount.score == 9)
            {
                SceneManager.LoadScene("GameOver");
                CanvasScript.t1 = "You Win!";
            }
            /*else
            {
                isCollision = false;
            }*/
        }
    }
}