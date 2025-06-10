using UnityEngine;
using UnityEngine;
using UnityEngine.Serialization;

public class Mago : Personagem
{
    [SerializeField] private string habilidadeEspecial = "Explosão Arcana";
    [FormerlySerializedAs("tipoMagia")] [SerializeField] private string tipoDano = "Magia Caótica";

    public string HabilidadeEspecial {
        get { return habilidadeEspecial; }
        set { habilidadeEspecial = value; }
    }

    public string TipoDeDano {
        get { return tipoDano; }
        set { tipoDano = value; }
    }
}
