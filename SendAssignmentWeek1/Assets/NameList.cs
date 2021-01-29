using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameList : MonoBehaviour
{
    public string[] namelist;
    public Text findlist;
    public Text Result;   
    
    public void GI455object()
    {
        for (int namaewa = 0; namaewa <= 4; namaewa++)
        {
            if (findlist.text == namelist[namaewa])
            {
                Result.text = "<color=blue>" + findlist.text + "</color>" + " is found";
                return;
            }
            else if (findlist.text != namelist[0] && namaewa == 4)
            {
                Result.text = "<color=blue>" + findlist.text + "</color>" + " is not found";
                return;
            }            
        }
    }
}