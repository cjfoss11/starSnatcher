using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour {

    public void setWelcomeScreen() {
        SceneManager.LoadScene("welcomeScreen");
    }

    public void setSetupScreen() {
       SceneManager.LoadScene("SetupScreen"); 
    }

    public void setGameScreen() {
    	SceneManager.LoadScene("gameScreen");
    }

    public void setSettingsScreen() {
    	SceneManager.LoadScene("SettingsScreen");
    }
    
    public void setHTP() {
    	SceneManager.LoadScene("HowToPlay");
    }
}
