using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDoLabirinto : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jogador")
        {
            Debug.Log("Você chegou ao fim!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
