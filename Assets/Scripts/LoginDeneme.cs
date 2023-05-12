using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginDeneme: MonoBehaviour
{
    public Button login;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void butonCalisma()
    {
        Debug.Log("buton");
        SceneManager.LoadScene(1);
        Debug.Log("buton");
        Debug.Log("buton");
        Debug.Log("buton");
        Debug.Log("buton");
    }
}
