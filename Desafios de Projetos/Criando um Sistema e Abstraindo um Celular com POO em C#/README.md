# Sistema de Smartphones - Programação Orientada a Objetos

## 📱 Sobre o Projeto

Este projeto implementa um sistema de smartphones utilizando os conceitos fundamentais de **Programação Orientada a Objetos (POO)** em C#. O sistema modela diferentes tipos de celulares (Nokia e iPhone) através de abstração, herança e polimorfismo.

## 🎯 Objetivos Alcançados

- ✅ Criação de uma classe abstrata `Smartphone` como modelo base
- ✅ Implementação de herança através das classes `Nokia` e `Iphone`
- ✅ Aplicação de polimorfismo no método `InstalarAplicativo`
- ✅ Demonstração prática dos conceitos de POO
- ✅ Sistema funcional de console em .NET

## 🏗️ Arquitetura do Sistema

O projeto segue a estrutura definida no diagrama UML, implementando:

### Classe Abstrata: `Smartphone`
- **Propriedades:**
  - `Numero` (público)
  - `Modelo` (privado)
  - `IMEI` (privado) 
  - `Memoria` (privado)
- **Métodos:**
  - `Ligar()` - Funcionalidade comum
  - `ReceberLigacao()` - Funcionalidade comum
  - `InstalarAplicativo(string nomeApp)` - Método abstrato

### Classes Filhas: `Nokia` e `Iphone`
- Herdam todas as propriedades e métodos da classe `Smartphone`
- Implementam o método `InstalarAplicativo` de forma específica:
  - **Nokia**: Instalação via "Nokia Store"
  - **iPhone**: Instalação via "App Store"

## 🔧 Conceitos de POO Implementados

### 1. **Abstração**
```csharp
public abstract class Smartphone
{
    public abstract void InstalarAplicativo(string nomeApp);
}
```

### 2. **Herança**
```csharp
public class Nokia : Smartphone
public class Iphone : Smartphone
```

### 3. **Polimorfismo**
```csharp
// Mesmo método, comportamentos diferentes
nokia.InstalarAplicativo("WhatsApp");    // Via Nokia Store
iphone.InstalarAplicativo("Instagram");  // Via App Store
```

### 4. **Encapsulamento**
- Propriedades privadas protegem os dados internos
- Acesso controlado através de construtores

## 🚀 Como Executar

1. Clone o repositório
2. Abra o projeto no Visual Studio ou VS Code
3. Execute o comando:
   ```bash
   dotnet run
   ```

## 📋 Funcionalidades Demonstradas

O programa executa testes que demonstram:

- ✅ Criação de objetos Nokia e iPhone
- ✅ Execução de métodos comuns (Ligar, ReceberLigacao)
- ✅ Instalação de aplicativos com comportamentos específicos
- ✅ Polimorfismo através de lista de objetos Smartphone

## 📊 Exemplo de Saída

```
=== TESTE DO SISTEMA DE SMARTPHONES ===

--- TESTANDO NOKIA ---
Número: 11999998888
Ligando...
Recebendo ligação...
Instalando aplicativo "WhatsApp" via Nokia Store...

--- TESTANDO IPHONE ---
Número: 11777776666
Ligando...
Recebendo ligação...
Instalando aplicativo "Instagram" via App Store...

--- DEMONSTRANDO POLIMORFISMO ---
Smartphone 1:
Instalando aplicativo "Angry Birds" via Nokia Store...
Smartphone 2:
Instalando aplicativo "Spotify" via App Store...
```

## 📁 Estrutura do Projeto

```
DesafioPOO/
├── Models/
│   ├── Smartphone.cs    # Classe abstrata base
│   ├── Nokia.cs         # Implementação Nokia
│   └── Iphone.cs        # Implementação iPhone
├── Program.cs           # Programa principal com testes
└── README.md           # Documentação
```

## 🎓 Conceitos Aprendidos

Este projeto demonstra na prática:
- Como criar e usar classes abstratas
- Implementação de herança em C#
- Polimorfismo e sobrescrita de métodos
- Encapsulamento e controle de acesso
- Diferença entre propriedades públicas e privadas
- Uso de construtores em hierarquias de classes

## 🛠️ Tecnologias Utilizadas

- **C#** - Linguagem de programação
- **.NET** - Framework de desenvolvimento
- **Console Application** - Tipo de aplicação

---

*Projeto desenvolvido como parte da trilha .NET da DIO, aplicando conceitos fundamentais de Programação Orientada a Objetos.*