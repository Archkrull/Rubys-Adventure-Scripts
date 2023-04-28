using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)

        {
            if(controller.cogs  < controller.maxCogs)
            {
            
                controller.ChangeCogs(5);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
                }
            
        }
    }
}
