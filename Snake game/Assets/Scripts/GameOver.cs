using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public AnimationClip a;
    Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Collision  (Collision other)
    {
        if (other.gameObject.tag =="Snake")
        {
            anim.clip = a;
            anim.Play();
        }
    }
}
