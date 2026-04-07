using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : PickUp
{
    public int clock = 5;
    public bool addTake; //T: dodaje, F: zabiera
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Picked()
    {
        int sign;
        if (addTake)
        {
            sign = 1;
        }
        else
        {
            sign = -1;
        }
        GameManager.gameManager.AddTime((int)clock * sign);
        base.Picked();
    }
}
