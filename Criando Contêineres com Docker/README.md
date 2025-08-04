# API de Gestão Escolar com FastAPI e Docker

> Status: Concluído ✔️
>
> Projeto desenvolvido para o **Desafio de Projeto: "Criando um Container de uma Aplicação WEB da DIO**.

![FastAPI](https://img.shields.io/badge/FastAPI-009688?style=for-the-badge&logo=fastapi)![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker)![Python](https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python)

---

## 📖 Sobre o Projeto

Este projeto consiste na criação de uma API RESTful para gerenciar alunos, cursos e matrículas em uma instituição de ensino. A aplicação foi desenvolvida utilizando **FastAPI** e foi totalmente **containerizada com Docker**, garantindo um ambiente de desenvolvimento e produção consistente, portátil e escalável.

O projeto foi originalmente baseado nos aprendizados da Imersão DevOps da Alura e foi reestruturado e aprimorado para atender aos requisitos do Desafio de Projeto da Digital Innovation One.

---

## ✨ Funcionalidades

- **API RESTful completa** para gestão de uma escola.
- **Operações de CRUD** (Create, Read, Update, Delete) para Alunos.
- **Documentação interativa** automática (Swagger UI e ReDoc).
- **Ambiente 100% containerizado** com Docker e Docker Compose, facilitando a execução em qualquer máquina.
- **Banco de dados SQLite** persistente através de volumes Docker.

---

## 🛠️ Tecnologias Utilizadas

- **Backend:** Python 3.10, FastAPI
- **Containerização:** Docker, Docker Compose
- **Banco de Dados:** SQLAlchemy, SQLite
- **Validação de Dados:** Pydantic
- **Servidor ASGI:** Uvicorn

---

## ✅ Pré-requisitos

Para executar este projeto, você precisará ter as seguintes ferramentas instaladas em sua máquina:

- **[Docker](https://www.docker.com/get-started/)**
- **[Docker Compose](https://docs.docker.com/compose/install/)** (geralmente já vem com o Docker Desktop)
- **[Git](https://git-scm.com/downloads)** (para clonar o repositório)

---

## 🚀 Como Executar com Docker (Método Principal)

A maneira mais simples e recomendada de executar a aplicação é através do Docker Compose.

**1. Clone o repositório:**
```bash
git clone <url-do-seu-repositorio>
```

**2. Navegue até a pasta raiz do projeto:**
```bash
cd api-gestao-escolar
```

**3. Inicie a aplicação com Docker Compose:**

Este único comando irá construir a imagem Docker (se ainda não existir), criar o container e iniciar a API.

```bash
docker-compose up -d --build
```

**4. Acesse a documentação da API:**

Após a execução, a API estará disponível. Abra seu navegador e acesse a documentação interativa:

[**http://localhost:8000/docs**](http://localhost:8000/docs)

Pronto! A partir da documentação, você pode testar todos os endpoints de forma interativa.

---

### ⚙️ Comandos Úteis do Docker

- **Para parar a aplicação:**
  ```bash
  docker-compose down
  ```

- **Para ver os logs da aplicação em tempo real:**
  ```bash
  docker-compose logs -f
  ```

- **Para forçar a reconstrução da imagem caso faça alterações no Dockerfile:**
  ```bash
  docker-compose up -d --build
  ```

---

## 📁 Estrutura do Projeto
```
/api-gestao-escolar
├── 📁 app/
│   ├── 📄 app.py            # Ponto de entrada da API e rotas principais
│   ├── 📄 database.py       # Configuração da conexão com o banco
│   ├── 📄 models.py         # Modelos de dados do SQLAlchemy
│   ├── 📄 schemas.py        # Schemas de validação do Pydantic
│   └── 📁 routers/          # Módulos com as rotas específicas
├── 📄 .gitignore
├── 📄 Dockerfile           # Receita para construir a imagem Docker
├── 📄 docker-compose.yml   # Arquivo para orquestrar o container
├── 📄 requirements.txt     # Lista de dependências Python
└── 📄 README.md            # Esta documentação
```

---

<details>
<summary><h5> 💻 Como Executar Localmente (Sem Docker) </h5></summary>

  Se preferir rodar a aplicação diretamente na sua máquina, siga os passos abaixo:

  **1. Crie e ative um ambiente virtual:**
  ```sh
  # Criar o ambiente
  python3 -m venv venv

  # Ativar no Linux/Mac
  source venv/bin/activate

  # Ativar no Windows (use o PowerShell)
  .\venv\Scripts\Activate
  ```

  **2. Instale as dependências:**
  ```sh
  pip install -r requirements.txt
  ```

  **3. Execute a aplicação:**
  ```sh
  uvicorn app.app:app --reload
  ```

  **4. Acesse a documentação:**
  [http://127.0.0.1:8000/docs](http://127.0.0.1:8000/docs)
</details>

---

**Observação sobre o Banco de Dados:** O projeto utiliza SQLite. O arquivo do banco (`escola.db`) será criado automaticamente na primeira vez que a aplicação for executada e os dados persistirão entre as reinicializações do container graças ao volume definido no `docker-compose.yml`.