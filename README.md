# DIO - Trilha .NET - A batalha dos RPGistas: herança e subclasse!

## Desafio de projeto
Para este desafio, usei os conhecimentos de Herança e Subclasses adquiridos no módulo de POO, da trilha .NET da DIO.

## Contexto
Em jogos de RPG, os personagens frequentemente possuem subclasses que representam especializações em determinadas áreas de combate, como por exemplo, "mago", "guerreiro", "ladino", etc. Neste desafio, você deve criar duas classes, "Personagem" e "Subclasse", que ilustrem o conceito de herança em POO.

Crie a classe "Personagem" que possua o atributo "nome" e "mana".

Crie a classe "Subclasse" que herda de "Personagem" e acrescenta o atributo "dano_base" e o método "calcular_dano", que recebe como argumento a quantidade de mana que será usada no ataque e retorna o dano causado pelo ataque, que é calculado como o valor de "dano_base" multiplicado pela quantidade de mana usada.

## Entrada
A entrada será dada pela chamada da classe "Subclasse" e seus métodos, para obter os valores dos atributos de cada personagem e a quantidade de mana usada no ataque.Os valores a serem recebidos serão:

    nome: nome do personagem
    mana: quantidade de mana do personagem
    dano base: referente ao dano base da subclasse

Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.

## Saída
A saída deverá ser a impressão da mensagem "Nome do personagem atacou e causou X de dano!", onde "Nome do personagem" é o nome do personagem fornecido na entrada e "X" é o valor de dano calculado pela subclasse a partir da quantidade de mana usada no ataque. Conforme exemplos abaixo.


 ## <a name="Exemplos"></a> Exemplos
<table>
<th><p>Entrada</h3></>
 <th><p>Saída</p></th>
  <tr>
      <td>
        <p>sauron</p>
        <p>30</p>
        <p>30</p>
      </td>
      <td>
        <p>sauron atacou e causou 900 de dano!</p>
      </td>
  </tr>
  <tr>
      <td>
        <p>frodo</p>
        <p>10</p>
        <p>5</p>
      </td>
      <td>
        <p>frodo atacou e causou 50 de dano!</p>
      </td>
  </tr>
  <tr>
      <td>
        <p>legolas</p>
        <p>23</p>
        <p>20</p>
      </td>
      <td>
        <p>legolas atacou e causou 460 de dano!</p>
      </td>
  </tr>
</table>
