using UnityEngine;
using System.Collections;

public class EscKeyMenu : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
        }
    }
}
