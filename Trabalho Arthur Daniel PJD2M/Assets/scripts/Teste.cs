using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Mago Mago1;
    public Mago Mago2;

    
    void Start()
    {
        Mago1.Nome = "Arthur mestre do fogo";
        Mago1.Nivel = 12;
        Mago1.Vida = 120;
        Mago1.Mana = 250;
        Mago1.HabilidadeEspecial = "Bola de fogo";
        Mago1.TipoDeDano = "Quimadura";
        
        Mago2.Nome = "Zarek";
        Mago2.Nivel = 8;
        Mago2.Vida = 90;
        Mago2.Mana = 180;
        Mago2.HabilidadeEspecial = "Bola de fogo";
        Mago2.TipoDeDano = "Queimadura";
        
        
        Debug.Log($"Mago 1: {Mago1.Nome}, Nível: {Mago1.Nivel}, Magia: {Mago1.TipoDeDano}");
        Debug.Log($"Feiticeiro 2: {Mago2.Nome}, Nível: {Mago2.Nivel}, Magia: {Mago2.TipoDeDano}");
        Debug.Log($"{Mago1.Nome} tem nível maior que {Mago2.Nome}? {Mago1.CompararNivel(Mago2)}");

    }
}
