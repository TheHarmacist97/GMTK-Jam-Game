using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] PlayerMovement Player;
    bool startTimer = true;
    int timeStart = 0;
    private void Update()
    {
        if(Player.canMove && startTimer)
        {
            startTimer = false;
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        while(Player.canMove)
        {
            timeStart++;
            yield return new WaitForSeconds(1f);
        }
    }
}
