using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EmptyFigureScript : MonoBehaviour
{
    public int ColorID;
    public int FormID;
    public GameObject Crab;
    public GameObject Inte;
    bool _Done = false;

    private void Start()
    {
        Crab = GameObject.Find("Crab");
        ControlScript.stroke = GameObject.Find("Integer");
    }
    private void FixedUpdate()
    {
        
        if (transform.position.y - Crab.transform.position.y < 2f && !_Done)
        {
            Crab.GetComponent<Crab>().FigureContact = true;
            Crab.GetComponent<Crab>().ContactFigure = gameObject;
            _Done = true;
        }

         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool Done = false;

        if (collision.gameObject.name == "LvL" && transform.position.y < -1f && transform.position.x < ControlScript.Crab.transform.position.x)
        {
            for(int i = 0; ControlScript.CrabbyLvL > i; i++)
            {
                if (ControlScript.rules[i] != null && ControlScript.rules[i].ColorRule == ColorID && ControlScript.rules[i].FormRule == FormID)
                {
                    ControlScript.WinTimer--;
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.RightFigure);
                    Done = true;
                    break;
                }
            }
            if (!Done)
            {
                ControlScript.WinTimer++;
                ControlScript.SecondAudio.PlayOneShot(SoundControler.WrongFigure);
            }
            ControlScript.LvLCount.text = "" + ControlScript.WinTimer;
            if (ControlScript.WinTimer <= ControlScript.TotalTimer)
            {
                ControlScript.SecondAudio.PlayOneShot(SoundControler.CrabbyVictory);
                Crab.GetComponent<Crab>().Anim.SetBool("Victory", true);
                ControlScript.MenuCrab1.SetActive(true);
                Time.timeScale = 0;
            }
            Destroy(gameObject);
        }               

        if (collision.gameObject.name == "LvL" && transform.position.y < -1f && transform.position.x > ControlScript.Crab.transform.position.x)
        {
            for (int i = 0; ControlScript.CrabbyLvL > i; i++)
            {
                if (ControlScript.rules[i + ControlScript.CrabbyLvL] != null && ControlScript.rules[i + ControlScript.CrabbyLvL].ColorRule == ColorID && ControlScript.rules[i + ControlScript.CrabbyLvL].FormRule == FormID)
                {
                    ControlScript.WinTimer--;
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.RightFigure);
                    Done = true;
                    break;
                }
            }
            if (!Done)
            {
                ControlScript.SecondAudio.PlayOneShot(SoundControler.WrongFigure);
                ControlScript.WinTimer++;
            }
            ControlScript.LvLCount.text = "" + ControlScript.WinTimer;
            if (ControlScript.WinTimer <= ControlScript.TotalTimer)
            {
                Crab.GetComponent<Crab>().Anim.SetBool("Victory", true);
                ControlScript.SecondAudio.PlayOneShot(SoundControler.CrabbyVictory);
                ControlScript.MenuCrab1.SetActive(true);
                Time.timeScale = 0;
            }
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "LvL" && transform.position.y > -1f && transform.position.x > -3.5f && transform.position.x < 3.2f)
        {
            ControlScript.WinTimer++;
            ControlScript.LvLCount.text = "" + ControlScript.WinTimer;
            Destroy(gameObject);
        }

    }

    public IEnumerator DestroyGO()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    
}
