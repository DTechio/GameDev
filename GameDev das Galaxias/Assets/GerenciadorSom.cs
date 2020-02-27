using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorSom : MonoBehaviour
{
    [SerializeField]
    private AudioClip _morteSlime;

    private List<AudioSource> _audios;


    private void Awake()
    {
        _audios = new List<AudioSource>();
        if(_morteSlime != null)
        {
            var ac = gameObject.AddComponent<AudioSource>();
            ac.clip = _morteSlime;
            ac.name = "Morte Slime";
            _audios.Add(ac);
        }

    }

    public void TocaAudio(string nome)
    {
        foreach(var audio in _audios)
        {
            if(audio.name.Equals(nome))
            {
                audio.Play();
                break;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
