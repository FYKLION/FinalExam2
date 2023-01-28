using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Kuzen"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
