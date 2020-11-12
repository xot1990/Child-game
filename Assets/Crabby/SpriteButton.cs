using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour
{

    private void OnMouseDown()
    {
        switch(gameObject.name)
        {
            case "MenuCrabNext":
                {
                    ControlScript.MenuCrab1.SetActive(false);
                    Time.timeScale = 1;
                    ControlScript.Self.GetComponent<ControlScript>().CrabbyNextLvL();
                }
                break;
            case "MenuCrabReset":
                {
                    ControlScript.MenuCrab1.SetActive(false);
                    ControlScript.MenuCrab2.SetActive(false);
                    Time.timeScale = 1;
                    ControlScript.Self.GetComponent<ControlScript>().CrabbyResetLvL();
                }
                break;
            case "MenuCrabExit":
                {
                    ControlScript.MenuCrab2.SetActive(false);
                    Time.timeScale = 1;
                    ControlScript.Self.GetComponent<ControlScript>().CrabbyBackToMenu();
                }
                break;
            case "Exit":
                {
                    Time.timeScale = 0;
                    ControlScript.MenuCrab2.SetActive(true);
                }
                break;
        }
    }
}
