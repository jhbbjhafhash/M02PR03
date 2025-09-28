using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerCollision.collided += Change;
    }

    void OnDisable()
    {
        PlayerCollision.collided -= Change;
    }

    private void Change()
    {
        gameObject.GetComponent<Transform>().localScale = new Vector3(5, 2, 2);
    }

}
