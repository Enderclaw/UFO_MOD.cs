using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HazardController : MonoBehaviour
{
    public Text failText;


    void Start()
    {
        print("Hazard is active");
        failText.text = "";
    }

    
    void OnTriggerEnter2D(Collider2D Hazard)
    {
        if(Hazard.gameObject.CompareTag("Hazard"))
        {
            Hazard.gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SetFailText();
        }
    }

    void SetFailText()
    {
        failText.text = "Oops! Not that pickup! Try again";
    }
}
