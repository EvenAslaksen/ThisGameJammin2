using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<WinnerBox>() != null)
        GameController.instance.BoxEnterZone();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<WinnerBox>() != null)
            GameController.instance.BoxExitZone();
    }
}
