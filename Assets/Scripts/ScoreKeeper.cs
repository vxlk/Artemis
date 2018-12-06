using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public Text output;
    public int score;
    public GameObject selectedGO;
    public bool selected;

    void Update()
    {
        if(selectedGO == null && selected)
        {
            score += 10;
            output.text = "Score: " + score.ToString();
            selected = false;
        }
    }
}
