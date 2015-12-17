using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManagerEnd : MonoBehaviour
{

    public static int score;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = ScoreManager.score;
    }

    void Update()
    {
        if (score > 0)
            text.text = "YOU WIN" + "\nScore: " + score;
        else
            text.text = "R.I.P" + "\nGAME OVER";
    }
}
