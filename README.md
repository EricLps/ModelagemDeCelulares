# Sistema de Modelagem de Celulares 📱
Este projeto é uma implementação do desafio proposto no **Bootcamp Trilha .NET POO da Digital Innovation One (DIO)**, focado em demonstrar os pilares da Programação Orientada a Objetos (POO) em C#.

## 🚀 Visão Geral do Projeto
O sistema simula a funcionalidade de diferentes smartphones, utilizando conceitos de **abstração, herança e polimorfismo** para criar um código flexível e reutilizável. Ele permite modelar celulares genéricos e especializá-los para marcas e modelos específicos, com comportamentos distintos.

## ✨ Funcionalidades Implementadas
- **Abstração**: Uma classe base abstrata ``Smartphone`` define características e comportamentos comuns a todos os celulares (Número, Modelo, IMEI, Memória, Ligar, ReceberLigacao).

- **Herança**: Classes específicas como ``Nokia`` e ``Iphone`` herdam da classe ``Smartphone``, reutilizando suas propriedades e métodos.

- **Polimorfismo**: O método ``InstalarAplicativo(string nomeApp)`` é abstrato na classe ``Smartphone`` e é sobrescrito (``override``) nas classes ``Nokia`` e ``Iphone``, demonstrando um comportamento diferente para cada marca ao instalar um aplicativo.

## 📂 Estrutura do Projeto
```
AbstraindoUmCelular/
├── Models/
│   ├── Smartphone.cs
│   ├── Nokia.cs
│   └── Iphone.cs
├── Program.cs
├── AbstraindoUmCelular.csproj
└── .gitignore
```

## ▶️ Como Executar
1. **Clone o repositório**:
```
git clone <https://github.com/EricLps/ModelagemDeCelulares>
````

2. **Navegue até a pasta do projeto**:
```
cd AbstraindoUmCelular
```

3. **Execute a aplicação**:
```
dotnet run
```
## 🎓 Conclusão do Bootcamp
Este projeto foi desenvolvido como parte do meu aprendizado e conclusão do **Bootcamp Trilha .NET POO da DIO**. Ele representa a aplicação prática dos conhecimentos adquiridos em Programação Orientada a Objetos e desenvolvimento C#.
