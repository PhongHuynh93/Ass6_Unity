using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public static int wave;

    Text text;

    void Awake ()
    {
        text = GetComponent<Text> ();
        score = 20;
        wave = 0;
    }

    void Update()
    {
        if (wave != -1)
            text.text = "Score: " + score + "\nWAVE " + wave;
        else
            text.text = "Score: " + score + "\nFINAL WAVE ";
    }
}
