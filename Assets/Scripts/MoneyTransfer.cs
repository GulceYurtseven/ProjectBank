using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyTransfer : MonoBehaviour
{
  public TMP_Text money;
    public TMP_InputField amount;
    private AccountToTransfer AccountToTransfer;
    // Start is called before the first frame update
    void Start()
    {
       // AccountToTransfer = FindAnyObjectByType<AccountToTransfer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConfirmButton()
    {
        int toAmount = int.Parse(amount.text);
        Debug.Log("amount" + toAmount);
        int money2 = int.Parse(money.text);
        Debug.Log("money2" + money2);
      money.text= (money2 - toAmount).ToString();

        Debug.Log(money.text);
    }
}
