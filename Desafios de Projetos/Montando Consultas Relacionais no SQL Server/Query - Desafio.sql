-- Objetivo 1 - Buscar o nome e ano dos filmes
SELECT Nome, Ano
FROM Filmes;

-- Objetivo 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
SELECT Nome, Ano
FROM Filmes
ORDER BY Ano ASC;

-- Objetivo 3 - Buscar pelo filme "De volta para o futuro"
SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Nome = 'De Volta para o Futuro';

-- Objetivo 4 - Buscar os filmes lan�ados em 1997
SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Ano = 1997;

-- Objetivo 5 - Buscar os filmes lan�ados AP�S o ano 2000
SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Ano > 2000;

-- Objetivo 6 - Filmes com dura��o entre 100 e 150 minutos
SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao ASC;

-- Objetivo 7 - Quantidade de filmes por ano
SELECT Ano, COUNT(*) AS Quantidade 
FROM Filmes 
GROUP BY Ano 
ORDER BY Quantidade DESC;

-- Objetivo 8 - Atores do g�nero masculino
SELECT Id, PrimeiroNome, UltimoNome, Genero 
FROM Atores 
WHERE Genero = 'M';

-- Objetivo 9 - Atrizes do g�nero feminino ordenadas por nome
SELECT Id, PrimeiroNome, UltimoNome, Genero
FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome;

-- Objetivo 10 - Nome do filme e g�nero (INNER JOIN)
SELECT f.Nome, g.Genero
FROM Filmes f
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON fg.IdGenero = g.Id;

-- Objetivo 11 - Filmes do g�nero "Mist�rio"
SELECT f.Nome, g.Genero
FROM Filmes f
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON fg.IdGenero = g.Id
WHERE g.Genero = 'Mist�rio';

-- Objetivo 12 - Nome do filme, atores e pap�is
SELECT f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel
FROM Filmes f
INNER JOIN ElencoFilme ef ON f.Id = ef.IdFilme
INNER JOIN Atores a ON ef.IdAtor = a.Id;
