﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ToryUX;

public class TitleSceneManager : MonoBehaviour
{
    public GameObject title;

    public GameObject flowerPiano;
    public GameObject piano;

    public GameObject pond_1;
    public GameObject spider_2;
    public GameObject rabbit_3;
    public GameObject bear_4;
    public GameObject funtorySonge_5;
    public GameObject freeMode_6;
    [SerializeField] GameObject timerUI;

    public GameObject[] stageBalloon;
    int stageNum = 0;

    public GameObject lifeManager;

    private void OnEnable()
    {
        TF.Scene.Title.Started += StartTitle;
        TF.Scene.Title.Updated += UpdateTitle;
        TF.Scene.Title.Ended += EndedTitle;

        TitleAnimation.PondClear += PondClearEvent;
        TitleAnimation.SpiderClear += SpiderClearEvent;
        TitleAnimation.RabbitClear += RabbitClearEvent;
        TitleAnimation.BearClear += BearClearEvent;
        TitleAnimation.FuntoryClear += FuntoryClearEvent;
        TitleAnimation.FreeClear+= FreeClearEvent;
    }

    private void OnDisable()
    {
        TF.Scene.Title.Started -= StartTitle;
        TF.Scene.Title.Updated -= UpdateTitle;
        TF.Scene.Title.Ended -= EndedTitle;

        TitleAnimation.PondClear -= PondClearEvent;
        TitleAnimation.SpiderClear -= SpiderClearEvent;
        TitleAnimation.RabbitClear -= RabbitClearEvent;
        TitleAnimation.BearClear -= BearClearEvent;
        TitleAnimation.FuntoryClear -= FuntoryClearEvent;
        TitleAnimation.FreeClear -= FreeClearEvent;
    }

    void StartTitle()
    {
        Score.Reset();
    }

    void UpdateTitle()
    {  

    }

    void PondClearEvent()
    {
        title.SetActive(false);
        flowerPiano.SetActive(true);

        pond_1.SetActive(true);
        Score.ShowUI();

        TF.Scene.Proceed();
        lifeManager.SetActive(true);
    }

    void SpiderClearEvent()
    {
        title.SetActive(false);
        flowerPiano.SetActive(true);

        spider_2.SetActive(true);
        Score.ShowUI();

        TF.Scene.Proceed();
        lifeManager.SetActive(true);
    }

    void RabbitClearEvent()
    {
        title.SetActive(false);
        flowerPiano.SetActive(true);

        rabbit_3.SetActive(true);
        Score.ShowUI();

        TF.Scene.Proceed();
        lifeManager.SetActive(true);
    }

    void BearClearEvent()
    {
        title.SetActive(false);
        flowerPiano.SetActive(true);

        bear_4.SetActive(true);
        Score.ShowUI();

        TF.Scene.Proceed();
        lifeManager.SetActive(true);
    }

    void FuntoryClearEvent()
    {
        title.SetActive(false);
        flowerPiano.SetActive(true);

        funtorySonge_5.SetActive(true);
        Score.ShowUI();

        TF.Scene.Proceed();
        lifeManager.SetActive(true);
    }

    void FreeClearEvent()
    {
        title.SetActive(false);
        piano.SetActive(true);

        freeMode_6.SetActive(true);

        timerUI.SetActive(true);
        Timer.ShowUI();
        TF.Scene.Proceed();
    }

    void EndedTitle()
    {
        TF.Scene.Proceed();
    }
}
