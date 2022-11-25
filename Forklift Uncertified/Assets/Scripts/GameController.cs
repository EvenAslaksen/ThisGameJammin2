using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public bool boxInZone = false;
    public bool playerInZone = false;

    void Awake()                //Activates earleir than Start function
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        } //"Singleton pattern"; Restricts itself to only one existing at a time to prevent other scripts from reading from multiple instances
    }

    public void BoxEnterZone()
    {
        boxInZone = true;
        if (boxInZone == true && playerInZone == true)
        {
            Debug.Log("You win :)");
        }
    }
    public void BoxExitZone()
    {
        boxInZone = false;
    }

    public void PlayerEnterZone()
    {
        playerInZone = true;
        if (boxInZone == true && playerInZone == true)
        {
            Debug.Log("You win :)");
        }
    }
    public void PlayerExitZone()
    {
        playerInZone = false;
    }
}
