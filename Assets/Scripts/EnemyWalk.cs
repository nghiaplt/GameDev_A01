using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    Vector2 pos;
    Vector2 screenBounds;
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        m_Animator = gameObject.GetComponent<Animator>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenBounds.x)
        {
            Destroy(gameObject);
        }
        float speed = 0.1f;
        float time = 2f;
        if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Flying"))
        {
            float goal = -2.23f;
            float flyingSpeed = (transform.position.y - goal)/time;
            pos.y -= flyingSpeed*0.1f;
        }
        else
        {
            pos.x -= speed;
        }
        transform.position = pos;
    }
}
