using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //variables for the book cost and number of books
    public int Bookcost;
    public int NumberofBooks;
    public float cost;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //starting line that shows what will be outputed
        float cost = 1;
        //Checking if there are two or more books
                    //because the shipping cost changes depending on the number of books
        if (NumberofBooks >= 2)
        {
            //calculating the cost of making the books
            cost = (float)((Bookcost * .40) + 3 + (NumberofBooks - 1 * 0.75));
            //outputting the cost of making the books
            Debug.LogFormat("The cost of making the books is {0}", cost);
        }

        //checking if there is only one book
                    //because the shipping cost changes depending on the number of books
        else if (NumberofBooks <= 1)
        {
            //calculating the cost of making the books
            cost = (float)((Bookcost * .40) + 3);
            //outputting the cost of making the books
            Debug.LogFormat("The cost of making the books is {0}", (Bookcost * .40) + 3);
            
        }
        //if there are no books
        else
        { }

        //outputting the profit of making the books
        Debug.LogFormat("The profit of making the books is {0}", (NumberofBooks * (Bookcost * .60)) - cost);
    
    }
}
