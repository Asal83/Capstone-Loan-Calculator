using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MonthlyLoanCalculation : MonoBehaviour
{
    public TMP_InputField LoanAmount;
    public TMP_InputField DownPayment;
    public TMP_InputField InterestRate;
    public TMP_Dropdown LoanPeriod;
    public TextMeshProUGUI MonthlyLoanPayment;


    public void LoanCalculation()
    {
        float LoanAmountf = float.Parse(LoanAmount.text);
        float DownPaymentf = float.Parse(DownPayment.text);
        float InterestRatef = float.Parse(InterestRate.text);
        float loanAmount = LoanAmountf - DownPaymentf;
        float interestRate = (InterestRatef / 100) / 12;
        float x = (1f / (1f + interestRate));
        float y=0;
        float z = loanAmount * interestRate;
        if (LoanPeriod.value == 0)
        {
           y= Mathf.Pow(x, 20 * 12);
        }
        else if (LoanPeriod.value == 1)
        {
           y= Mathf.Pow(x, 30 * 12);
        }
        else if (LoanPeriod.value == 2)
        {
           y= Mathf.Pow(x, 35 * 12);
        }
        float result = z / (1 - y);
        MonthlyLoanPayment.text = result.ToString();







    }

}
