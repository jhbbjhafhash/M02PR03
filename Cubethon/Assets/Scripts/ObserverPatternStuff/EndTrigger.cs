using UnityEngine;
using System;    
public class EndTrigger : MonoBehaviour
{
    public static event Action EndOfLevel;
    public GameManager gameManager;

   void OnTriggerEnter ()
   {
        EndOfLevel?.Invoke();
        gameManager.CompleteLevel();
   }
}
