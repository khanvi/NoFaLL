using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneSave : MonoBehaviour
{
    int score;
    public Text scoreText;
    void Start()
    {
        score = PlayerPrefs.GetInt("savescore");
        scoreText.text = "score " + score;
    }

}
