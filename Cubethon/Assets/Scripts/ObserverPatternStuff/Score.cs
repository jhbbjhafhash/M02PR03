using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public static event Action ScoreUp;
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    public void Update()
    {
        ScoreUp?.Invoke();
        scoreText.text = player.position.z.ToString("0");
    }
}
