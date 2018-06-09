using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGameButton : MonoBehaviour
{
    public Button playGame;

    // Use this for initialization
    private void Start()
    {
        playGame.onClick.AddListener(delegate { LoadGameScene(); });
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}