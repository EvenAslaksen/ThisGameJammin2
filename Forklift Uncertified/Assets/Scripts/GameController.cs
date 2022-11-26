using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public bool boxInZone = false;
    public bool playerInZone = false;
    public GameObject youwin;

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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Dennis level");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Level 2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Level 3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Level 4");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("Level 5");
        }
    }

    public void BoxEnterZone()
    {
        boxInZone = true;
        if (boxInZone == true && playerInZone == true)
        {
            Debug.Log("You win :)");
            youwin.SetActive(true);
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
            youwin.SetActive(true);
        }
    }
    public void PlayerExitZone()
    {
        playerInZone = false;
    }
}
