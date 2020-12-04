using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    public static float speed = 4;
    Vector3 Pos;
    public bool Rotation = false;
    public Animator Anim;
    public bool FigureContact;
    public GameObject ContactFigure;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Pos = transform.position;
    }


    void Update()
    {

# if UNITY_EDITOR
        if (Input.GetKey(KeyCode.A))
        {
            Anim.SetBool("Run left", true);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            Anim.SetBool("Run right", true);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
#endif
        if (Rotation) Rot();        
        if (transform.rotation.z > 0.3f || transform.rotation.z < -0.3) ControlScript.RotationButton.SetActive(true);
        if (ContactFigure != null)
        {       
            if (transform.position.x > ContactFigure.transform.position.x && FigureContact)
            {
                Anim.SetBool("Huk left", true);
                FigureContact = false;
                ContactFigure = null;
            }

            else if (transform.position.x < ContactFigure.transform.position.x && FigureContact)
            {
                Anim.SetBool("Huk right", true);
                FigureContact = false;
                ContactFigure = null;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.x > collision.transform.position.x && collision.gameObject.tag != "LvL")
        {
            
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1) * 200);

        }
        if (transform.position.x < collision.transform.position.x && collision.gameObject.tag != "LvL")
        {
            
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 1) * 200);
        }
        if (transform.position.y < -1f && collision.gameObject.name == "LvL")
        {
            
            transform.position = Pos;
            Time.timeScale = 0;
            ControlScript.Self.GetComponent<ControlScript>().CrabbyResetLvL();
        }
    }

    public void Rot()
    {
        ControlScript.Crab.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 3);
        if (transform.rotation.z < 0.01 && transform.rotation.z > -0.01)
        {
            Rotation = false;
            ControlScript.RotationButton.SetActive(false);
        }
    }

    public void AnimaOff()
    {
        Anim.SetBool("Huk left", false);
        Anim.SetBool("Huk right", false);
        Anim.SetBool("Run right", false);
        Anim.SetBool("Run left", false);
        Anim.SetBool("Victory", false);
    }
}
