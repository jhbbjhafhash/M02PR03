using System;
using UnityEngine;
using UnityEngine.Events;
public class PlayerCollision : MonoBehaviour
{
    public static event Action collided;
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            collided?.Invoke();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
