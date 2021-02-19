using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour
{
    public bool isMovingLeft;
    public bool isMovingRight;

    private void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "MenuCrabNext":
                {
                    ControlScript.MenuCrab1.SetActive(false);
                    ControlScript.Self.GetComponent<ControlScript>().CrabbyNextLvL();
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.ButtonClick3);
                }
                break;
            case "MenuCrabReset":
                {
                    ControlScript.MenuCrab1.SetActive(false);
                    ControlScript.MenuCrab2.SetActive(false);
                    ControlScript.Self.GetComponent<ControlScript>().CrabbyResetLvL();
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.ButtonClick3);
                }
                break;
            case "MenuCrabExit":
                {
                    ControlScript.MenuCrab2.SetActive(false);
                    Time.timeScale = 1;
                    ControlScript.Self.GetComponent<ControlScript>().CrabbyBackToMenu();
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.ButtonClick3);
                }
                break;
            case "Exit":
                {
                    Time.timeScale = 0;
                    ControlScript.MenuCrab2.SetActive(true);
                }
                break;
            case "RotationButton":
                {
                    ControlScript.Crab.GetComponent<Crab>().Rotation = true;
                }
                break;

        }
    }

    public void StartMoveLeft()
    {
        isMovingLeft = true;
    }

    public void StartMoveRight()
    {
        isMovingRight = true;
    }

    public void EndMoveLeft()
    {
        isMovingLeft = false;
    }

    public void EndMoveRight()
    {
        isMovingRight = false;
    }

#if UNITY_IOS || UNITY_ANDROID

    
#endif

    private void Update()
    {
        if (isMovingLeft)
        {
            Debug.Log("left step");
            ControlScript.Crab.gameObject.transform.Translate(Vector2.left * Crab.speed * Time.deltaTime);
            ControlScript.Crab.GetComponent<Crab>().Anim.SetBool("Run left", true);
            ControlScript.Crab.GetComponent<Crab>().AV.PlayOneShot(SoundControler.CrabbyStep);
        }
        else if (isMovingRight)
        {
            Debug.Log("Right step");
            ControlScript.Crab.gameObject.transform.Translate(Vector2.right * Crab.speed * Time.deltaTime);
            ControlScript.Crab.GetComponent<Crab>().Anim.SetBool("Run right", true);
            ControlScript.Crab.GetComponent<Crab>().AV.PlayOneShot(SoundControler.CrabbyStep);
        }

    }
}
