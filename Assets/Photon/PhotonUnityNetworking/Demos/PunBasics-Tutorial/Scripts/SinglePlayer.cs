using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SinglePlayer : MonoBehaviour
{
   public static bool isSinglePlayer;
   void start()
    {
        isSinglePlayer = false;
    }

    public static void makeSinglePlayer()
    {
        isSinglePlayer = true;
    }
}
