using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_UP : Controller_Player
{
    private int swordVar = 0;
    public GameObject sword;

    public override void FixedUpdate()
    {
        base.FixedUpdate();

        if (Input.GetKeyDown(KeyCode.F3))
        {
            if (swordVar == 0)
            {
                sword.SetActive(true);
                swordVar = 1;
            }
            else
            {
                sword.SetActive(false);
                swordVar = 0;
            }
        }
    }
}

       
