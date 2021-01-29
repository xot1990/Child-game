using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageScript : MonoBehaviour
{

    public List<Sprite> Images;
    public List<AudioClip> Sounds;
    public int Num;
    Image Image;
    AudioSource AV;

    void Start()
    {
        Image = GetComponent<Image>();
        AV = GetComponent<AudioSource>();
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
        AV.PlayOneShot(Sounds[Num]);
    }

    public void BackToMenu()
    {
        Images = null;
        Num = 0;
        Sounds = null;
        Image.sprite = null;
        ControlScript.AnimalSound.SetActive(false);
        ControlScript.MainMenu.SetActive(true);
        Image.sprite = Resources.Load<Sprite>("AnimalSound/Default");
    }

}
