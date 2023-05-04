using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Color randomcolorpick = GetRandomColor();
        GetComponent<Renderer>().material.color = randomcolorpick;
    }


    private Color GetRandomColor()
    {
        return new Color(
           UnityEngine.Random.Range(0f, 1f),
           UnityEngine.Random.Range(0f, 1f),
           UnityEngine.Random.Range(0f, 1f)

                       );


    }
}
