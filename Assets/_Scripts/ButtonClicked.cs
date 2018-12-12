using UnityEngine;
using System.Collections;

public class ButtonClicked : MonoBehaviour {

	public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
