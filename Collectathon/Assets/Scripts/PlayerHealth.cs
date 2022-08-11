using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject gameover;
    [SerializeField] private float health;
    [SerializeField] Image healthBar;
    public PlayerMovement pm;


    void Update()
    {
        healthBar.fillAmount = health;

        if(health <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameover.SetActive(true);
            pm.enabled = false;

}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            health -= 1/3f ;
        }
    }
}
