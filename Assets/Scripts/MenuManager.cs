using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MenuToLoan()
    {
        SceneManager.LoadScene("loanapp");
    }
    public void MenuToChangeLanguage()
    {
        SceneManager.LoadScene("changeLanguage");
    }
    public void MenuToMoneyTransfer()
    {
        SceneManager.LoadScene("moneyTransfer");
    }
    public void MenuToViewAccounts()
    {
        SceneManager.LoadScene("viewAccounts");
    }
    public void MenuToCards()
    {
        SceneManager.LoadScene("Cards");
    }
    public void MenuToInvestments()
    {
        SceneManager.LoadScene("Invesments");
    }
    public void MenuToPayments()
    {
        SceneManager.LoadScene("payment");
    }
    public void MenuToMain()
    {
        SceneManager.LoadScene("accountMain");
    }
}
