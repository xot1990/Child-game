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

    void Start()
    {
        StartPos = transform.position;
        anim = GetComponent<Animator>();
        Back = GameObject.Find("BackGround");
    }

    
    void Update()
    {
        Debug.Log(transform.position);
        if (BackOnPos)
        {
            transform.Translate((StartPos - transform.position) * Time.deltaTime *2);
            
        }
        if (StartPos.x - 0.2f <= transform.position.x && StartPos.x + 0.2f >= transform.position.x && StartPos.y - 0.2f <= transform.position.y && StartPos.y + 0.2f >= transform.position.y && BackOnPos)
        {
            Debug.Log("2");
            transform.position = StartPos;
            BackOnPos = false;
        }
    }

    public void SelectFragment()
    {

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
            transform.position = ControlScript.Field.transform.position;
            transform.parent = Back.transform;
            anim.SetBool("Done", true);
            ControlScript.TotalTimer++;
           
        }
        else
        {
            anim.SetBool("Deselected", true);
            if (transform.position.x < Back.transform.position.x) BackOnPos = true;
            else StartPos = transform.position;
            GetComponent<Image>().raycastTarget = true;
            ControlScript.SelectedFragment = -1;
        }        
    }

    public void DelGO()
    {
        Destroy(gameObject);
    }
    public void StopAnim()
    {        
        anim.SetBool("Deselected", false);
        anim.SetBool("Selected", false);
    }
}
