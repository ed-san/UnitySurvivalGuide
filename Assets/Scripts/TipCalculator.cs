using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //Bill is $40
    //Tip is 20% or based on what the user wants
    //Calculate total amount
    public double bill;
    public double tip;
    private double totalAmount;
    private double calculatedTip;


    // Start is called before the first frame update
    void Start()
    {
        calculatedTip = bill * (tip / 100);
        totalAmount = bill + calculatedTip;
    //Your bill is: and your tip amount is : so you owe: totalAmount
        Debug.Log("Your Bill is: " + bill + "\n" + "Tip is: " + tip + "\n" + "Total Price: " + totalAmount);
    }


}
