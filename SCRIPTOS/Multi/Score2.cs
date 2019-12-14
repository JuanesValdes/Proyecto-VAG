using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    //Sistema de score, con el cual se irá actualizando de la mano con cada objeto que el player obtenga, aumentando el puntaje determinado en cada obj
    public static int score2;
    Text text;

    // Use this for initialization
    void Start()
    {

        text = GetComponent<Text>();
        score2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score2 < 0)
            score2 = 0;
        text.text = "" + score2;

    }
    public static void AddPoints(int pointsToAdd)
    {
        score2 += pointsToAdd;
    }
    public static void Reset()
    {
        score2 = 0;
    }
}