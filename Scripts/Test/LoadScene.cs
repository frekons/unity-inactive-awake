using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private void Awake()
    {
        /* loads next scene of this gameObject in build scene list */
        SceneManager.LoadSceneAsync(gameObject.scene.buildIndex + 1, LoadSceneMode.Additive);
    }
}
