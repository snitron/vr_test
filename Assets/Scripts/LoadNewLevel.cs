using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour {
    public string name;
    public void LoadScene() {
        SceneManager.LoadScene(name);
    }
}
