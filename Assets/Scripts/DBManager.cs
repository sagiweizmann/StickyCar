using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager 
{
    public static int id;
    public static string username="";
    public static int coins;
    public static int currentskin = 0;
    public static string currentitems;

    public static bool LoggedIn{ get { return username != null; } }
    public static void LogOut()
    {
        username = null;
    }
}
