# ?? Orbital Alert API

API desenvolvida em ASP.NET Core 8 para monitoramento de alertas urbanos com integração à API pública da NASA (APOD).

Projeto desenvolvido para a disciplina de DevOps Tools & Cloud Computing da FIAP.

---

# ?? Funcionalidades

- CRUD completo de cidades
- Integração com API da NASA
- Swagger para documentação
- PostgreSQL com Entity Framework Core
- Docker e Docker Compose
- Arquitetura REST

---

# ?? Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- PostgreSQL
- Docker
- Docker Compose
- Swagger
- NASA APOD API

---

# ?? Estrutura do Projeto

```txt
OrbitalAlert.API
?
??? Controllers
??? Models
??? Data
??? Services
??? DTOs
??? Migrations
??? Dockerfile
??? docker-compose.yml
??? appsettings.json
??? Program.cs
```

---

# ?? Como Executar o Projeto

## 1?? Clonar o repositório

```bash
git clone URL_DO_SEU_REPOSITORIO
```

---

## 2?? Entrar na pasta do projeto

```bash
cd OrbitalAlert.API
```

---

## 3?? Subir os containers Docker

```bash
docker compose up --build
```

---

# ?? Acessar Swagger

Abra no navegador:

```txt
http://localhost:8080/swagger
```

---

# ?? Endpoint NASA

## Buscar imagem astronômica do dia

```http
GET /api/Nasa/apod
```

### Exemplo de resposta

```json
{
  "title": "Headphone Nebula",
  "explanation": "Descrição da imagem astronômica...",
  "url": "https://apod.nasa.gov/apod/image/example.jpg",
  "date": "2026-05-27"
}
```

---

# ??? CRUD de Cities

## ? Criar cidade

```http
POST /api/Cities
```

### Body

```json
{
  "name": "São Paulo",
  "state": "SP",
  "riskLevel": "Alto"
}
```

---

## ?? Listar cidades

```http
GET /api/Cities
```

---

## ?? Atualizar cidade

```http
PUT /api/Cities/{id}
```

### Body

```json
{
  "id": 1,
  "name": "São Paulo",
  "state": "SP",
  "riskLevel": "Crítico"
}
```

---

## ? Remover cidade

```http
DELETE /api/Cities/{id}
```

---

# ??? Banco de Dados

Banco utilizado:

```txt
PostgreSQL
```

A conexão é configurada no:

```txt
appsettings.json
```

---

# ?? Docker

## Subir containers

```bash
docker compose up --build
```

## Derrubar containers

```bash
docker compose down
```

---

# ????? Autores
Carlos Eduardo Rodrigues Coelho Pacheco - RM: 557323
João Pedro Amorim Brito Virgens - RM: 559213
Pedro Augusto Costa Ladeira - RM: 558514

Projeto acadêmico desenvolvido para a FIAP utilizando ASP.NET Core, PostgreSQL, Docker e integração com API pública da NASA.