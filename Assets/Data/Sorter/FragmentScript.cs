using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FragmentScript : MonoBehaviour
{
    public int ID;
    public Vector3 StartPos;
    public GameObject Back;
    public bool BackOnPos;
    Animator anim;

    // Audio

    public AudioClip Info;
    public AudioSource AV;
    

    void Start()
    {
        AV = GetComponent<AudioSource>();
        StartPos = transform.position;
        anim = GetComponent<Animator>();
        Back = GameObject.Find("BackGround");
    }

    
    void Update()
    {

        if (BackOnPos)
        {

            transform.Translate((StartPos - transform.position) * Time.deltaTime *2);
            
        }
        if (StartPos.x - 0.2f <= transform.position.x && StartPos.x + 0.2f >= transform.position.x && StartPos.y - 0.2f <= transform.position.y && StartPos.y + 0.2f >= transform.position.y && BackOnPos)
        {
            
            transform.position = StartPos;
            BackOnPos = false;
        }
    }

    public void SelectFragment()
    {
        AV.PlayOneShot(Info);
        ControlScript.SelectedFragment = ID; 
    }

    public void DropFragment()
    {
        ControlScript.SelectedFragment = -1;
    }

    public void DragFragment()
    {
        ControlScript.SelectedFragment = ID;
        BackOnPos = false;
        GetComponent<Image>().raycastTarget = false;
        
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
        
    }

    public void StartDrug()
    {
        anim.SetBool("Selected", true);
        BackOnPos = false;
    }

    public void EndDrug()
    {
        if (ControlScript.SelectedFragment == ControlScript.SelectedSensFild)
        {
            AV.PlayOneShot(SoundControler.RightStep);
            transform.position = ControlScript.Field.transform.position;
            transform.parent = Back.transform;
            anim.SetBool("Done", true);
            //audio.PlayOneShot(Right);
            ControlScript.TotalTimer++;
            if (ControlScript.TotalTimer >= ControlScript.WinTimer)
            {
                AV.PlayOneShot(SoundControler.Victory);
                ControlScript.SorterMenuNextLvL.SetActive(true);
            }
           
        }
        else
        {
            AV.PlayOneShot(SoundControler.WrongStep);
            anim.SetBool("Deselected", true);
            //audio.PlayOneShot(Wrong);
            if (transform.position.x < Back.transform.position.x)
            {
                BackOnPos = true;
                
            }
            else StartPos = transform.position;
            GetComponent<Image>().raycastTarget = true;
            ControlScript.SelectedFragment = -1;
        }

        
        
    }

    public void DelGO()
    {
        gameObject.SetActive(false);
    }
    public void StopAnim()
    {        
        anim.SetBool("Deselected", false);
        anim.SetBool("Selected", false);
    }
}
