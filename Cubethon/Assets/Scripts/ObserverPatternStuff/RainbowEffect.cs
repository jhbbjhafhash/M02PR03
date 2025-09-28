using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowEffect : MonoBehaviour
{
    float curSize = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Score.ScoreUp += Change;
        curSize = gameObject.GetComponent<Transform>().localScale.y;
    }

    void OnDisable()
    {
        Score.ScoreUp -= Change;
    }

    private void Change()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
