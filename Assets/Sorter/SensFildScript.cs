using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensFildScript : MonoBehaviour
{

    public int ID;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SelectField()
    {
        ControlScript.SelectedSensFild = ID;
        ControlScript.Field = gameObject;
    }

    public void DropField()
    {
        ControlScript.SelectedSensFild = -2;
        ControlScript.Field = null;
    }
}
