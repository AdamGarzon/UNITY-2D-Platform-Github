using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Expirimental.UIElements;

public class Patrol : MonoBehaviour
{

    public float speed;

    private bool movingLeft = true;

    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

}
