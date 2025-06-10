using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Arthur Mago1;
    public Arthur Mago2;

    void Start()
    {
        Mago1.Nome = "Arthur mestre do fogo";
        Mago1.Forca = 12;
        Mago1.Vida = 120;
        Mago1.Mana = 250;
        Mago1.HabilidadeEspecial = "Explosão Arcana";
        Mago1.TipoDeDano = "Magia Caótica";
        
        Mago2.Nome = "Zarek";
        Mago2.Forca = 8;
        Mago2.Vida = 90;
        Mago2.Mana = 180;
        Mago2.HabilidadeEspecial = "Explosão Arcana";
        Mago2.TipoDeDano = "Magia Negra";
        
        Debug.Log($"Feiticeiro 1: {Mago1.Nome}, Nível: {Mago1.Forca}, Magia: {Mago1.TipoDeDano}");
        Debug.Log($"Feiticeiro 2: {Mago2.Nome}, Nível: {Mago2.Forca}, Magia: {Mago2.TipoDeDano}");

        Debug.Log($"{Mago1.Nome} tem nível maior que {Mago2.Nome}? {Mago1.TemNivelMaiorQue(Mago2)}");
    }
}
