using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject Food;
    public GameObject game;

    Vector3 lastpos;
    float Size;
    void Start()
    {
        lastpos = Food.transform.position;
        Size = Food.transform.localScale.x;

        for (int i = 0; i < 10; i++)
        {
            Spawner();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawner()
    {
        int Rand = Random.Range(0, 7);

        if (Rand < 3)
        {
            SpawnX();
        }
        else if (Rand >= 3)
        {
            SpawnZ();
        }
    }

    void SpawnX()
    {
        Vector3 pos = lastpos;
        pos.x += Size;
        lastpos = pos;
        int Rand = Random.Range(0, 4);
        if (Rand < 1)
        {

            Instantiate(Food, pos, Quaternion.identity);
        }

    }

    void SpawnZ()
    {
        Vector3 pos = lastpos;
        pos.z += Size;
        lastpos = pos;
        int Rand = Random.Range(0, 4);
        if (Rand < 1)
        {

            Instantiate(Food, pos, Quaternion.identity);
        }
    }

    private void OnCollisonEnter(Collision other)
    {
        if (other.gameObject.tag == "Snake")
        {
            Destroy(other.gameObject,.5f);
        }
    }


}
