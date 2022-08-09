using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public PlayerJump jumpScript;
    public float count;
    // Start is called before the first frame update
    void Start()
    {
        jumpScript = GetComponent<PlayerJump>();
    }

    private void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            jumpScript.sm.PlayCollectSound();
            count++;
            Destroy(other.gameObject);
            if (count == 20)
            {
                jumpScript.sm.PlayWinSound();
            }

        }
    }
}
