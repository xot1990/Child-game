using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PictureScript : MonoBehaviour
{

    public int ID;
    public Sprite Picture;
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public List<Sprite> Images;
    public List<AudioClip> Sounds;
    Data.Animal animal;

    void Start()
    {
        animal = Data.SorterList.Animals.Find(X => X.ID == ID);
        Picture = animal.Picture;

        Images.Add(animal.Image1);
        Images.Add(animal.Image2);
        Images.Add(animal.Image3);

        Sounds.Add(animal.Sound1);
        Sounds.Add(animal.Sound2);
        Sounds.Add(animal.Sound3);

        GetComponent<Image>().sprite = Picture;
    }

    public void onClick()
    {
        ControlScript.AnimalImage.GetComponent<Image>().sprite = Images[0];
        ControlScript.AnimalImage.GetComponent<ImageScript>().Images = Images;
        ControlScript.AnimalImage.GetComponent<ImageScript>().Num = 0;
        ControlScript.AnimalImage.GetComponent<ImageScript>().Sounds = Sounds;

    }
    
}
