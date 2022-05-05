using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateReplacement : MonoBehaviour
{
    private const int characterNumber = 11;
    GameObject[] characters = new GameObject[characterNumber];
    GameObject FinishLine;
    float[] distances = new float[characterNumber];
    float[] orderedDistances = new float[characterNumber];
    //  If the number of opponents is too high, it will be corrected again.
    string[] opponents = { "Player", "Opponent1", "Opponent2", "Opponent3", "Opponent4", "Opponent5", "Opponent6", "Opponent7", "Opponent8", "Opponent9", "Opponent10" };
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;
    public Text text11;

    void Start()
    {

        var Player = GameObject.FindGameObjectWithTag("Player");
        var Opponents = GameObject.FindGameObjectsWithTag("Opponent");
        FinishLine = GameObject.FindGameObjectWithTag("Finish");


        characters[0] = Player;

        for(int i = 1; i <= Opponents.Length; i++)
        {
            characters[i] = Opponents[i-1];
        }

 
        
    }

    // Update is called once per frame
    void Update()
    {

        for(int j = 0; j < characters.Length; j++)
        {
            float distance = Vector3.Distance(characters[j].transform.position,FinishLine.transform.position);
            distances[j] = distance;
        }


        for(int k = 0; k < distances.Length; k++)
        {
            orderedDistances[k] = distances[k];
        }


        Array.Sort(orderedDistances);


        for(int i = 0; i < distances.Length; i++)
        {

            //  If the number of opponents is too high, it will be corrected again.

            if (orderedDistances[0].Equals(distances[i]))
            {
                text1.text = "1. "+opponents[i];
            }
            else if (orderedDistances[1].Equals(distances[i]))
            {
                text2.text = "2. " + opponents[i];
            }
            else if (orderedDistances[2].Equals(distances[i]))
            {
                text3.text = "3. " + opponents[i];
            }
            else if (orderedDistances[3].Equals(distances[i]))
            {
                text4.text = "4. " + opponents[i];
            }
            else if (orderedDistances[4].Equals(distances[i]))
            {
                text5.text = "5. " + opponents[i];
            }
            else if (orderedDistances[5].Equals(distances[i]))
            {
                text6.text = "6. " + opponents[i];
            }
            else if (orderedDistances[6].Equals(distances[i]))
            {
                text7.text = "7. " + opponents[i];
            }
            else if (orderedDistances[7].Equals(distances[i]))
            {
                text8.text = "8. " + opponents[i];
            }
            else if (orderedDistances[8].Equals(distances[i]))
            {
                text9.text = "9. " + opponents[i];
            }
            else if (orderedDistances[9].Equals(distances[i]))
            {
                text10.text = "10. " + opponents[i];
            }
            else if (orderedDistances[10].Equals(distances[i]))
            {
                text11.text = "11. " + opponents[i];
            }

        } 
    }
}
