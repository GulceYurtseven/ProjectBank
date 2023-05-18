using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cardstoAcc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cardToAcc()
    {
        SceneManager.LoadScene("accountMain");
    }
    public void cardTomenu()
    {
        SceneManager.LoadScene("menu");
    }
}
