using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtiraScript : MonoBehaviour
{
    [SerializeField]
    private Transform _posicaoDeTiro;
    [SerializeField]
    private GameObject _laserPrefab;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Atira();
        }
    }

    private void Atira()
    {
        Instantiate(_laserPrefab, _posicaoDeTiro.position, _posicaoDeTiro.rotation);
    }
}
