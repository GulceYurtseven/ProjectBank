using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Choose : MonoBehaviour
{
    public GameObject title;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseTitle()
    {
        title.SetActive(false);
    }
}
