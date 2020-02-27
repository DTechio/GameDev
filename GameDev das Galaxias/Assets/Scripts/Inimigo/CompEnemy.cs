using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompEnemy : MonoBehaviour
{
    [SerializeField]
    private int _vida = 3;

    [SerializeField]
    private GerenciadorSom _gerenciadorSom;

    public void TomaDano(int dano)
    {
        _vida -= dano;

        if(_vida <= 0)
        {
            Morre();
        }
    }

    private void Morre()
    {
        if(_gerenciadorSom != null)
        {
            _gerenciadorSom.TocaAudio("Morte Slime");
        }
        Destroy(gameObject);
    }
}
