# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto ✅ **CONCLUÍDO**
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. ✅ Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. ✅ O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. ✅ Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## ✨ Implementações Realizadas

### 🔧 Métodos Implementados na Classe Reserva

#### `CadastrarHospedes(List<Pessoa> hospedes)`
- ✅ **Validação de capacidade**: Verifica se a suíte comporta o número de hóspedes
- ✅ **Exception personalizada**: Retorna erro detalhado quando a capacidade é excedida
- ✅ **Mensagem clara**: Informa exatamente quantos hóspedes cabem vs quantos foram informados

#### `ObterQuantidadeHospedes()`
- ✅ **Contagem precisa**: Retorna o número total de hóspedes na reserva
- ✅ **Implementação simples**: Utiliza `Hospedes.Count` para eficiência

#### `CalcularValorDiaria()`
- ✅ **Cálculo base**: Dias reservados × Valor da diária
- ✅ **Desconto automático**: 10% de desconto para reservas ≥ 10 dias
- ✅ **Precisão decimal**: Utiliza tipo `decimal` para cálculos monetários precisos

### 🐛 Correções Realizadas

#### Ordem de Execução no Program.cs
- **Antes**: `CadastrarHospedes()` era chamado antes de `CadastrarSuite()`
- **Depois**: Corrigida a ordem para cadastrar a suíte primeiro, evitando erros de referência nula

## 🚀 Como Executar

1. **Clone o repositório**
   ```bash
   git clone [url-do-repositorio]
   cd DesafioProjetoHospedagem
   ```

2. **Execute o projeto**
   ```bash
   dotnet run
   ```

3. **Resultado esperado**
   ```
   Hóspedes: 2
   Valor diária: 150
   ```

## 🧪 Cenários de Teste

### Cenário 1: Reserva Normal (< 10 dias)
- **Hóspedes**: 2
- **Suíte**: Premium (capacidade: 2, valor: R$ 30/dia)
- **Dias**: 5
- **Resultado**: R$ 150,00 (sem desconto)

### Cenário 2: Reserva com Desconto (≥ 10 dias)
- **Hóspedes**: 2
- **Suíte**: Premium (capacidade: 2, valor: R$ 30/dia)
- **Dias**: 12
- **Resultado**: R$ 324,00 (R$ 360 com 10% desconto)

### Cenário 3: Capacidade Excedida
- **Hóspedes**: 3
- **Suíte**: Premium (capacidade: 2)
- **Resultado**: Exception com mensagem explicativa

## 🛠️ Tecnologias Utilizadas

- **C# 12**
- **.NET 8**
- **Programação Orientada a Objetos**
  - Classes e Objetos
  - Encapsulamento
  - Tratamento de Exceções
  - Coleções (List<T>)

## 📝 Estrutura do Projeto

```
DesafioProjetoHospedagem/
├── Models/
│   ├── Pessoa.cs          # Classe para representar hóspedes
│   ├── Suite.cs           # Classe para representar suítes do hotel
│   └── Reserva.cs         # Classe principal com lógica de negócio ✨
├── Program.cs             # Programa principal com exemplo de uso
└── README.md              # Este arquivo
```

## 🎯 Aprendizados

Este projeto demonstra conceitos fundamentais de C#:
- **Validação de entrada** com exceptions
- **Cálculos monetários** precisos com `decimal`
- **Lógica condicional** para regras de negócio
- **Manipulação de coleções** com `List<T>`
- **Organização de código** em classes e namespaces

---

**Status**: ✅ Projeto Concluído com Sucesso!

**Autor**: Natasha Brandão  
**Data**: Junho 2025  
**Curso**: WEX-End-to-End-Engineering 