﻿using System;

class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

class Subclasse : Personagem
{
    public int DanoBase { get; set; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    public void CalcularDano()
    {
        Console.WriteLine($"{Nome} atacou e causou {DanoBase * Mana} de dano!");
    }
}

class Program
{
    static void Main()
    {
        string nome;
        int mana, danoBase;

        nome = Console.ReadLine();
        mana = int.Parse(Console.ReadLine());
        danoBase = int.Parse(Console.ReadLine());

        Subclasse subclasse = new Subclasse(nome, mana, danoBase);
        subclasse.CalcularDano();
    }
}