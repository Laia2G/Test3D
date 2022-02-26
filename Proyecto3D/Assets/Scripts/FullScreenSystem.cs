using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenSystem : MonoBehaviour
{
    public Toggle _toggle;
    // Start is called before the first frame update
    void Start()
    {
        if (Screen.fullScreen)
        {
            _toggle.isOn = true;
        }
        else
        {
            _toggle.isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateFS(bool FScreen)
    {
        Screen.fullScreen = FScreen;
    }
}
