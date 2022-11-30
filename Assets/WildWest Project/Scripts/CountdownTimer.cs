using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public string LevelToLoad;
    public float timer = 10f;
    //private Text timerSeconds;
    //  public Enemy enemy;

    public TextMeshProUGUI ClockTimer;
    //public int Player1Hits;
    //public int Player2Hits;

    //public int Player1Hits;

    //Timer
    public GameObject DisableTimer;
    public GameObject DisableTimerHUD;
    public GameObject DisableTimerText;

    //music
    public GameObject DisableCurrentMusic;
    public GameObject DisableVictoryMusic;


    //Player models
    public GameObject DisableP1Model;
    public GameObject DisableP2Model;

    //cameras
    public GameObject DisableCamera1;
    public GameObject DisableCamera2;
    public GameObject DisableCamera3;
    public GameObject DisableCamera4;

    //win condtions
    public GameObject DisableP1VictoryModel;
    public GameObject DisableP2VictoryModel;
    public GameObject DisableP1LoseModel;
    public GameObject DisableP2LoseModel;
    public GameObject DisableP1DrawModel;
    public GameObject DisableP2DrawModel;

    //PlayerUI
    public GameObject DisableP1HUD;
    public GameObject DisableP1HUDBackground;
    public GameObject DisableP1HUDScore;

    public GameObject DisableP2HUD;
    public GameObject DisableP2HUDBackground;
    public GameObject DisableP2HUDScore;

    //UI 
    public GameObject DisableUIP1Victory;
    public GameObject DisableUIP1Lose;
    public GameObject DisableUIP2Victory;
    public GameObject DisableUIP2Lose;
    public GameObject DisableUIDraw;

    public GameObject Icon;
    public GameObject IconDead;
    public GameObject Continue;
    public GameObject Gameover;
    public GameObject Yes;







    // Use this for initialization
    void Start()
    {
        ClockTimer = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        ClockTimer.text = timer.ToString("f2");



        //Debug.Log("Shrek");
        if (timer <= 0)
        {
            DisableTimer.SetActive(false);
            DisableTimerHUD.SetActive(false);
            DisableTimerText.SetActive(false);
            Icon.SetActive(false);
            IconDead.SetActive(true);
            Continue.SetActive(false);
            Gameover.SetActive(true);
            Yes.SetActive(false);
            /* if (TwoPlayerHitCounter.Player2Hits > PlayerHitCounter.Player1Hits)
             {
                 DisableTimer.SetActive(false);
                 DisableTimerHUD.SetActive(false);
                 DisableTimerText.SetActive(false);
                 DisableP1Model.SetActive(false);
                 DisableP2Model.SetActive(false);
                 DisableCamera1.SetActive(false);
                 DisableP1HUD.SetActive(false);
                 DisableP1HUDBackground.SetActive(false);
                 DisableP1HUDScore.SetActive(false);
                 DisableP2HUD.SetActive(false);
                 DisableP2HUDBackground.SetActive(false);
                 DisableP2HUDScore.SetActive(false);
                 DisableCurrentMusic.SetActive(false);

                 DisableCamera2.SetActive(true);
                 DisableVictoryMusic.SetActive(true);
                 DisableP2VictoryModel.SetActive(true);
                 DisableP1LoseModel.SetActive(true);
                 DisableUIP2Victory.SetActive(true);
             }

            /* if (PlayerHitCounter.Player1Hits > TwoPlayerHitCounter.Player2Hits)
             {
                 DisableTimer.SetActive(false);
                 DisableTimerHUD.SetActive(false);
                 DisableTimerText.SetActive(false);
                 DisableP1Model.SetActive(false);
                 DisableP2Model.SetActive(false);
                 DisableCamera1.SetActive(false);
                 DisableP1HUD.SetActive(false);
                 DisableP1HUDBackground.SetActive(false);
                 DisableP1HUDScore.SetActive(false);
                 DisableP2HUD.SetActive(false);
                 DisableP2HUDBackground.SetActive(false);
                 DisableP2HUDScore.SetActive(false);
                 DisableCurrentMusic.SetActive(false);

                 DisableCamera2.SetActive(true);
                 DisableVictoryMusic.SetActive(true);
                 DisableP1VictoryModel.SetActive(true);
                 DisableP2LoseModel.SetActive(true);
                 DisableUIP1Victory.SetActive(true);


             }*/
        }

    }
    public void AddTime()
    {
        timer += 3f;
    }
}
