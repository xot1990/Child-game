using System.Collections;
using System.Collections.Generic;
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
    }

    
    void Update()
    {
        if (BackOnPos)
        {
            transform.Translate((StartPos - transform.position) * Time.deltaTime *2);
            
        }
        if (StartPos.x - 0.2f <= transform.position.x && StartPos.x + 0.2f >= transform.position.x && StartPos.y - 0.2f <= transform.position.y && StartPos.y + 0.2f >= transform.position.y)
        {
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
        
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
    }

    public void StartDrug()
    {
        anim.SetBool("Selected", true);
    }

    public void EndDrug()
    {
        if (ControlScript.SelectedFragment == ControlScript.SelectedSensFild)
        {
            transform.position = ControlScript.Field.transform.position;
            anim.SetBool("Done", true);
           
        }
        else
        {
            anim.SetBool("Deselected", true);
            if (transform.position.x < Back.transform.position.x) BackOnPos = true;
            else StartPos = transform.position;
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
