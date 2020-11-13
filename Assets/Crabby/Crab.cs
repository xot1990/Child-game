using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    public static float speed = 4;
    Vector3 Pos;
    public bool Rotation = false;

    void Start()
    {
        Pos = transform.position;
    }


    void Update()
    {

# if UNITY_EDITOR
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector2.right * speed * Time.deltaTime);
#endif
        if (Rotation) Rot();        
        if (transform.rotation.z > 0.3f || transform.rotation.z < -0.3) ControlScript.RotationButton.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.x > collision.transform.position.x) collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1) * 200);
        if (transform.position.x < collision.transform.position.x) collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 1) * 200);
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
}
