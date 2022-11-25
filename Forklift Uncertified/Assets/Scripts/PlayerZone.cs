using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Forklift>() != null)
            GameController.instance.PlayerEnterZone();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Forklift>() != null)
            GameController.instance.PlayerExitZone();
    }
}
