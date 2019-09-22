using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.1f;
        if(Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetBool("Running", true);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetBool("Running", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Running", false);
        }

        transform.position = pos;
    }
}
