using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour
{
    private Transform m_Transform;
    private SpriteRenderer m_SpriteRenderer;
    public float velocity;
    public float xDirection;
    public float yDirection;
    // Start is called before the first frame update
    private void Awake()
    {
        m_Transform = GetComponent<Transform>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Transform.position = new Vector2(m_Transform.position.x + velocity * xDirection * Time.deltaTime, m_Transform.position.y + velocity * yDirection * Time.deltaTime);
        if (m_Transform.position.x >= 7.17)
        {
            xDirection = -1;
            m_SpriteRenderer.flipX = true;
        }
        else if(m_Transform.position.x <= -7.17)
        {
            xDirection = +1;
            m_SpriteRenderer.flipX = false;
        }
        else if (m_Transform.position.y >= 3.5)
        {
            yDirection = -1;
            m_SpriteRenderer.flipY = true;
        }
        else if (m_Transform.position.y <= -3.5)
        {
            yDirection = +1;
            m_SpriteRenderer.flipY = false;
        }


    }
}
