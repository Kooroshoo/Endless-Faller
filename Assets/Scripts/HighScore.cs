using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update

    void Update()
    {
        text.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }


}
