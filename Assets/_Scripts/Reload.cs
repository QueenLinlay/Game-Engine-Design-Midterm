using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    public static Reload instance;
    int life;
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            life = ScoreManager.instance.ReturnLife();
            ScoreManager.instance.FinalScore(life);
           // Reload.instance.LoadThing();

        }
    }
   // void LoadThing()
   // {
     //   SceneManager.LoadScene(0);
    //}
}
