﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageScript : MonoBehaviour
{

    public List<Sprite> Images;
    public AudioClip Sound;
    public int Num;
    Image Image;
    AudioSource audio;

    void Start()
    {
        Image = GetComponent<Image>();
        audio = GetComponent<AudioSource>();
        Image.sprite = Resources.Load<Sprite>("AnimalSound/Default");
    }

   
    void Update()
    {
        
    }

    public void NextPicture()
    {
        Num++;
        if (Num >= 3) Num = 0;
        Image.sprite = Images[Num];
    }

    public void BackPicture()
    {
        Num--;
        if (Num < 0) Num = 2;
        Image.sprite = Images[Num];
    }

    public void PlaySound()
    {
        audio.PlayOneShot(Sound);
    }

    public void BackToMenu()
    {
        Images = null;
        Num = 0;
        Sound = null;
        Image.sprite = null;
        ControlScript.AnimalSound.SetActive(false);
        ControlScript.MainMenu.SetActive(true);
        Image.sprite = Resources.Load<Sprite>("AnimalSound/Default");
    }

}
