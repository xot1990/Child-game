using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyFigureScript : MonoBehaviour
{
    public int ColorID;
    public int FormID;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LvL" && transform.position.y < -1f && transform.position.x < ControlScript.Crab.transform.position.x)
        {
            if (ControlScript.LeftRule.GetComponent<RuleScript>().ColorRule == ColorID && ControlScript.LeftRule.GetComponent<RuleScript>().FormRule == FormID) ControlScript.TotalTimer++;
            Destroy(gameObject);
        }
    }
}
