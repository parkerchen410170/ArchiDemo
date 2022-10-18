using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    //void OnTriggerStay(Collider other)
    //{
        
    //    SceneManager.LoadScene("ExhibitHall");


    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float timeLeft = 15.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("ExhibitHall");
        }
    }

}
    