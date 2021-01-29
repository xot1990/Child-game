using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Sprite Default;
    public Sprite OtherSide;
    public int ID;
    public int Num;

    AudioSource AV;


    void Start()
    {
        AV = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    public void SwitchIcone()
    {
        if (GetComponent<Image>().sprite == Default) GetComponent<Image>().sprite = OtherSide;
        else if (GetComponent<Image>().sprite == OtherSide) GetComponent<Image>().sprite = Default;
    }

    public void ActiveTile()
    {
        if (ControlScript.ActiveTile1 == null && ControlScript.ActiveTile2 == null)
        {
            ControlScript.ActiveTile1 = gameObject;
            return;
        }
        if (ControlScript.ActiveTile2 == null && gameObject != ControlScript.ActiveTile1)
        {
            ControlScript.ActiveTile2 = gameObject;
            return;
        }
    }

    public void OffGO()
    {
        GetComponent<Image>().sprite = Default;
        gameObject.SetActive(false);
    }

    public void Pressed()
    {
        AV.PlayOneShot(SoundControler.Tup);
        GetComponent<Animator>().SetBool("Pressed", true);
    }

    public void Check()
    {
        ControlScript.Self.GetComponent<ControlScript>().ActiveGuessing();        
    }

    public void ToNormal()
    {
        GetComponent<Animator>().SetBool("Back", false);
    }

    public void ToNormalOnPressed()
    {
        GetComponent<Animator>().SetBool("Pressed", false);
    }

    public void StopStarter()
    {
        GetComponent<Animator>().SetBool("Starter", false);
        
    }

    public void StopEnder()
    {
        GetComponent<Animator>().SetBool("Ender", false);
        GetComponent<Button>().interactable = true;
    }

    public IEnumerator Ender()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Animator>().SetBool("Ender", true);
    }
}
