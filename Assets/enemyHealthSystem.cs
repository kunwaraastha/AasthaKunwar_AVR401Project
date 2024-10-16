using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealthSystem : MonoBehaviour
{
    public int numofBullettokill = 4;
    int numofBulletTaken = 1;

    public void bulletHit()
    {
        if (numofBullettokill > numofBulletTaken)
        {
            numofBulletTaken++;
            Debug.Log("Bullet Hit : " + numofBulletTaken);

        }
        else
        {
            Destroy(gameObject);
        }

    }
}
