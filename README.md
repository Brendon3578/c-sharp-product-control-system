# Product Control System

Este projeto em C# .NET foi desenvolvido para explorar conceitos fundamentais de Programação Orientada a Objetos (POO), como polimorfismo e sobrecarga de métodos. O sistema simula um controle de produtos, onde diferentes tipos de produtos (comuns, usados e importados) podem ser registrados e exibidos com informações específicas.

## 💻 Descrição

O sistema permite ao usuário inserir dados de diferentes produtos e exibir uma etiqueta de preço personalizada para cada tipo de produto. O polimorfismo é usado para permitir que diferentes classes derivadas (`UsedProduct` e `ImportedProduct`) implementem suas próprias versões do método `PriceTag`, enquanto a sobrecarga é utilizada na classe base para oferecer várias maneiras de construir objetos.

## 🔮 Funcionalidades

- **Cadastro de Produtos**: O sistema permite cadastrar produtos comuns, usados e importados.
- **Etiquetas de Preço Personalizadas**: Cada tipo de produto possui uma exibição específica de sua etiqueta de preço, levando em conta atributos como taxa alfandegária e data de fabricação.
- **Polimorfismo**: As subclasses `UsedProduct` e `ImportedProduct` sobrescrevem o método `PriceTag` da classe base `Product` para fornecer comportamentos específicos.
- **Sobrecarga**: A classe `Product` utiliza sobrecarga no método construtor, permitindo criar instâncias de produtos de diferentes formas.

## Pilares de POO Utilizados

Este projeto demonstra o uso dos seguintes pilares da Programação Orientada a Objetos:

1. **Herança**: As classes `UsedProduct` e `ImportedProduct` herdam da classe base `Product`, reutilizando código comum e especializando comportamentos.
1. **Polimorfismo**: Através do uso de métodos e atributos virtuais e sobrescritos, como `PriceTag` e o atributo `Price`, o projeto demonstra polimorfismo, permitindo que o mesmo método e atributo seja utilizado de maneiras diferentes nas subclasses.

## 📁 Estrutura do Código

- **Classe `Product`**: Classe base que representa um produto comum. Inclui propriedades como `Name` e `Price`, e um método virtual `PriceTag` que pode ser sobrescrito.
- **Classe `UsedProduct`**: Subclasse de `Product` que adiciona a propriedade `ManufactureDate` e sobrescreve o método `PriceTag` para exibir informações adicionais.
- **Classe `ImportedProduct`**: Subclasse de `Product` que adiciona a propriedade `CustomsFee` e modifica o cálculo do preço total. Também sobrescreve o método `PriceTag`.

## 🎈 Exemplo de Uso

O usuário pode registrar um número de produtos, especificando se eles são comuns, usados ou importados. Após o registro, o sistema exibirá as etiquetas de preço personalizadas para cada produto, com informações como data de fabricação e taxas alfandegárias incluídas conforme necessário.

## ✨ Exemplo de Uso

- **C#**
- **.NET 8.0**

---

<h3 align="center">
    Feito com ☕ por <a href="https://github.com/Brendon3578"> Brendon Gomes</a>
</h3>
