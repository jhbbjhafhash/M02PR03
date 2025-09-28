using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EndTrigger.EndOfLevel += Change;
    }

    void OnDisable()
    {
       EndTrigger.EndOfLevel -= Change;
    }

    private void Change()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(0, 10, 0);
    }
}
