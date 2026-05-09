using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguidora : MonoBehaviour
{
    public Transform jogador;
    public Vector3 offset = new Vector3(0, 10, -5);

    void LateUpdate()
    {
        transform.position = jogador.position + offset;
        transform.LookAt(jogador);
    }
}