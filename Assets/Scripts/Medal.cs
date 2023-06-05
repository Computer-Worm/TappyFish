using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    public Sprite medal, bronzMedal, silverMedal, goldMedal;
    Image img;

    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        int gameScore = GameManager.gameScore;

        if (gameScore > 0 && gameScore <= 5)
        {
            img.sprite = medal;
        }

        else if (gameScore > 5 && gameScore <= 10)
        {
            img.sprite = bronzMedal;
        }

        else if (gameScore > 10 && gameScore <= 15)
        {
            img.sprite = silverMedal;
        }

        else if (gameScore > 15)
        {
            img.sprite = goldMedal;
        }
    }
}
