using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestoryGameObj", 5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<enemyHealthSystem>().bulletHit();
            DestoryGameObj();
        }
    }

    void DestoryGameObj()
    {
        Destroy(gameObject);
    }
}
