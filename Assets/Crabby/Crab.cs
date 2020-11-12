using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }


    void Update()
    {
#if UNITY_ANDROID
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        if (dir.sqrMagnitude > 1) dir.Normalize();

        dir *= Time.deltaTime;

        transform.Translate(dir * speed);

#endif

#if UNITY_EDITOR

        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector2.right * speed * Time.deltaTime);

#endif

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.x > collision.transform.position.x) collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1) * 200);
        if (transform.position.x < collision.transform.position.x) collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 1) * 200);
    }
}
