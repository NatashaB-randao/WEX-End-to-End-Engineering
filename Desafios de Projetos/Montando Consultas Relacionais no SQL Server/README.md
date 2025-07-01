# 🎬 Desafio DIO - Banco de Dados de Filmes

## 📋 Sobre o Projeto

Este repositório contém a resolução do **Desafio de Banco de Dados** da **Trilha .NET** da **DIO (Digital Innovation One)**. O projeto consiste em realizar 12 consultas SQL específicas em um banco de dados de filmes, demonstrando conhecimentos em:

- Consultas básicas (SELECT, WHERE, ORDER BY)
- Funções de agregação (COUNT, GROUP BY)
- Relacionamentos entre tabelas (INNER JOIN)
- Filtros avançados e ordenação de dados

## 🎯 Objetivo do Desafio

Você é responsável pelo banco de dados de um site de filmes e precisa realizar consultas para análises específicas. O banco contém informações sobre:

- **Filmes** (nome, ano, duração)
- **Atores** (nome, gênero)
- **Gêneros** cinematográficos
- **Relacionamentos** entre filmes-atores e filmes-gêneros

## 🗃️ Estrutura do Banco de Dados

### Tabelas Principais:
- **Filmes**: Informações dos filmes (Id, Nome, Ano, Duracao)
- **Atores**: Dados dos atores (Id, PrimeiroNome, UltimoNome, Genero)
- **Generos**: Gêneros cinematográficos (Id, Genero)

### Tabelas de Relacionamento:
- **ElencoFilme**: Relaciona filmes com atores (muitos-para-muitos)
- **FilmesGenero**: Relaciona filmes com gêneros (muitos-para-muitos)

![Diagrama do Banco](diagrama.png)

## 🚀 Como Executar

### Pré-requisitos:
- SQL Server ou SQL Server Express
- SQL Server Management Studio (SSMS) ou Azure Data Studio

### Passos:
1. **Clone o repositório:**
   ```bash
   git clone https://github.com/seu-usuario/desafio-dio-banco-filmes.git
   ```

2. **Execute o script de criação:**
   - Abra o arquivo `Scripts/Script Filmes.sql`
   - Execute no seu SQL Server para criar o banco e inserir os dados

3. **Execute as consultas:**
   - Abra o arquivo `Consultas/12-consultas-filmes.sql`
   - Execute cada consulta individualmente ou todas juntas

## 📊 As 12 Consultas Realizadas

### 1️⃣ **Buscar nome e ano dos filmes**
```sql
SELECT Nome, Ano FROM Filmes;
```

### 2️⃣ **Filmes ordenados por ano crescente**
```sql
SELECT Nome, Ano FROM Filmes ORDER BY Ano ASC;
```

### 3️⃣ **Filme "De Volta para o Futuro"**
```sql
SELECT Nome, Ano, Duracao FROM Filmes 
WHERE Nome = 'De Volta para o Futuro';
```

### 4️⃣ **Filmes lançados em 1997**
```sql
SELECT Nome, Ano, Duracao FROM Filmes WHERE Ano = 1997;
```

### 5️⃣ **Filmes lançados após 2000**
```sql
SELECT Nome, Ano, Duracao FROM Filmes WHERE Ano > 2000;
```

### 6️⃣ **Filmes entre 100-150 min ordenados por duração**
```sql
SELECT Nome, Ano, Duracao FROM Filmes 
WHERE Duracao > 100 AND Duracao < 150 
ORDER BY Duracao ASC;
```

### 7️⃣ **Quantidade de filmes por ano**
```sql
SELECT Ano, COUNT(*) AS Quantidade FROM Filmes 
GROUP BY Ano ORDER BY Quantidade DESC;
```

### 8️⃣ **Atores masculinos**
```sql
SELECT PrimeiroNome, UltimoNome FROM Atores WHERE Genero = 'M';
```

### 9️⃣ **Atrizes ordenadas por nome**
```sql
SELECT PrimeiroNome, UltimoNome FROM Atores 
WHERE Genero = 'F' ORDER BY PrimeiroNome;
```

### 🔟 **Filmes e seus gêneros**
```sql
SELECT f.Nome, g.Genero FROM Filmes f
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON fg.IdGenero = g.Id;
```

### 1️⃣1️⃣ **Filmes do gênero "Mistério"**
```sql
SELECT f.Nome, g.Genero FROM Filmes f
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON fg.IdGenero = g.Id
WHERE g.Genero = 'Mistério';
```

### 1️⃣2️⃣ **Filmes, atores e papéis**
```sql
SELECT f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel FROM Filmes f
INNER JOIN ElencoFilme ef ON f.Id = ef.IdFilme
INNER JOIN Atores a ON ef.IdAtor = a.Id;
```

## 📈 Resultados Principais

- **28 filmes** cadastrados (1954-2009)
- **23 atores** (18 masculinos, 5 femininos)
- **13 gêneros** diferentes
- **1997** foi o ano com mais lançamentos (4 filmes)
- **3 filmes** classificados como "Mistério"

## 📁 Estrutura do Projeto

```
📦 desafio-dio-banco-filmes/
├── 📂 Scripts/
│   └── Script Filmes.sql
├── 📂 Consultas/
│   └── 12-consultas-filmes.sql
├── 📂 Documentacao/
│   ├── diagrama-banco.png
│   └── resultados-esperados.md
└── README.md
```

## 🛠️ Tecnologias Utilizadas

- **SQL Server**: Sistema de gerenciamento de banco de dados
- **T-SQL**: Linguagem de consulta estruturada da Microsoft
- **SSMS**: SQL Server Management Studio

## 📚 Conceitos SQL Demonstrados

### Consultas Básicas:
- `SELECT` - Seleção de dados
- `FROM` - Especificação de tabelas
- `WHERE` - Filtros condicionais
- `ORDER BY` - Ordenação de resultados

### Funções de Agregação:
- `COUNT()` - Contagem de registros
- `GROUP BY` - Agrupamento de dados

### Relacionamentos:
- `INNER JOIN` - União de tabelas
- Relacionamentos **1:N** e **N:N**
- Uso de **tabelas de ligação**

### Operadores:
- Comparação (`=`, `>`, `<`)
- Lógicos (`AND`, `OR`)
- Ordenação (`ASC`, `DESC`)

## 👨‍💻 Autor

**[Natasha Brandão]**
- GitHub: [@NatashaB-randao](https://github.com/NatashaB-randao)
- LinkedIn: [Natasha Brandão](https://www.linkedin.com/in/natasha-brand%C3%A3o/)
- DIO: [Perfil DIO](https://web.dio.me/users/natashabrandao57?name=&page=1%3D%3D&tab=achievements)

## 🏆 Certificação

Este projeto faz parte da **Trilha .NET** da **Digital Innovation One (DIO)** e demonstra competências em:

- Modelagem de banco de dados
- Consultas SQL avançadas
- Relacionamentos entre tabelas
- Análise de dados

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

⭐ **Se este projeto te ajudou, deixe uma estrela!**

🔗 **Conecte-se comigo nas redes sociais e vamos trocar conhecimento!**