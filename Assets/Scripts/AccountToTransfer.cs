using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AccountToTransfer : MonoBehaviour
{
    public TMP_Text money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TransferPage()
    {
        SceneManager.LoadScene("moneyTransfer");
    }
}
