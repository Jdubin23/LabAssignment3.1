using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SomeDollarBillsProblems : MonoBehaviour
{
    public int Paycheck;
    public int TwentyDollarBills;
    public int TenDollarBills;
    public int FiveDollarBills;
    public int OneDollarBills;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //starting line that shows what will be outputed
        Debug.Log("Your Paycheck will come out to");


        //check if there are any twenty dollar bills
        if (Paycheck / 20 != 0)
        {
            TwentyDollarBills = Paycheck / 20;  
            Paycheck -= TwentyDollarBills * 20;
            Debug.LogFormat("{0} Twenty Dollar Bills", TwentyDollarBills);
        }
        //check if there are any ten dollar bills
        if (Paycheck / 10 != 0)
        {
            TenDollarBills = Paycheck / 10;
            Paycheck -= TenDollarBills * 10;
            Debug.LogFormat("{0} Ten Dollar Bills", TenDollarBills);
        }
        //check if there are any five dollar bills
        if (Paycheck / 5 != 0)
        {
            FiveDollarBills = Paycheck / 5;
            Paycheck -= FiveDollarBills * 5;
            Debug.LogFormat("{0} Five Dollar Bills", FiveDollarBills);
        }
        //check if there are any one dollar bills
        if (Paycheck / 1 != 0)
        {
            OneDollarBills = Paycheck / 1;
            Paycheck -= OneDollarBills;
            Debug.LogFormat("{0} One Dollar Bills", OneDollarBills);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
