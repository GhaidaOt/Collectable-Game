using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Collect : MonoBehaviour
{
    [SerializeField] GameObject win;
    [SerializeField] int inGameCollectables;
    public PlayerJump jumpScript;
    public float count;
    [SerializeField] Text countText;

    void Start()
    {
        jumpScript = GetComponent<PlayerJump>();
    }

    private void Update()
    {
        countText.text = (""+count); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            jumpScript.sm.PlayCollectSound();
            count++;
            Destroy(other.gameObject);
            if (count == inGameCollectables)
            {
                jumpScript.sm.PlayWinSound();
                win.SetActive(true);

            }

        }
    }
}
