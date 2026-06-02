# 🚀 Orbital Alert API

API desenvolvida em ASP.NET Core 8 para monitoramento de alertas urbanos com integração à API pública da NASA (APOD).

Projeto desenvolvido para a disciplina de DevOps Tools & Cloud Computing da FIAP.

---

# 🌍 Funcionalidades

- CRUD completo de Cities
- CRUD completo de Alerts
- Integração com API da NASA (APOD)
- Swagger para documentação
- PostgreSQL com Entity Framework Core
- Docker e Docker Compose
- Azure App Service
- Azure Database for PostgreSQL
- Arquitetura REST

---

# ☄️ Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- PostgreSQL 16
- Docker
- Docker Compose
- Swagger / OpenAPI
- Azure App Service
- Azure Database for PostgreSQL
- NASA APOD API

---

# 📁 Estrutura do Projeto

```txt
OrbitalAlert.API
│
├── Controllers
│   ├── CitiesController.cs
│   ├── AlertsController.cs
│   └── NasaController.cs
├── Models
├── Data
├── Services
├── DTOs
├── Repositories
├── Migrations
├── Dockerfile
├── docker-compose.yml
├── appsettings.json
└── Program.cs
```

---

# 🐳 Como Executar o Projeto

## 1️⃣ Clonar o repositório

```bash
git clone https://github.com/Global-Solution-Ideatec/orbital-alert-api.git
```

---

## 2️⃣ Entrar na pasta do projeto

```bash
cd OrbitalAlert.API
```

---

## 3️⃣ Subir os containers Docker

```bash
docker compose up --build -d
```

---

## 4️⃣ Verificar containers em execução

```bash
docker ps
```

---

# 🚀 Swagger Publicado na Azure

A API está disponível publicamente através do Azure App Service:

```txt
https://orbitalalert-api-rm557323-czdna8eddqfzgrbc.brazilsouth-01.azurewebsites.net/swagger
```

---

# 🌌 Endpoint NASA

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

# 🏙️ CRUD de Cities

## ➕ Criar cidade

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

## 📖 Listar cidades

```http
GET /api/Cities
```

---

## 🔍 Buscar cidade por ID

```http
GET /api/Cities/{id}
```

---

## ✏️ Atualizar cidade

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

## ❌ Remover cidade

```http
DELETE /api/Cities/{id}
```

---

# 🚨 CRUD de Alerts

## ➕ Criar alerta

```http
POST /api/Alerts
```

### Body

```json
{
  "type": "Enchente",
  "description": "Risco de alagamento",
  "severity": "Alta",
  "cityId": 1
}
```

---

## 📖 Listar alertas

```http
GET /api/Alerts
```

---

## 🔍 Buscar alerta por ID

```http
GET /api/Alerts/{id}
```

---

## ✏️ Atualizar alerta

```http
PUT /api/Alerts/{id}
```

### Body

```json
{
  "id": 1,
  "type": "Enchente",
  "description": "Enchente confirmada",
  "severity": "Crítica",
  "createdAt": "2026-06-01T00:00:00Z",
  "cityId": 1
}
```

---

## ❌ Remover alerta

```http
DELETE /api/Alerts/{id}
```

---

# 🛢️ Banco de Dados

Banco utilizado:

```txt
PostgreSQL 16
```

### Tabela Cities

| Campo | Tipo |
|---------|---------|
| Id | Integer |
| Name | Text |
| State | Text |
| RiskLevel | Text |

### Tabela Alerts

| Campo | Tipo |
|---------|---------|
| Id | Integer |
| Type | Text |
| Description | Text |
| Severity | Text |
| CreatedAt | DateTime |
| CityId | Integer |

Relacionamento:

```txt
Alerts.CityId → Cities.Id
```

A conexão é configurada através do:

```txt
appsettings.json
```

---

# 🐳 Docker

## Subir containers

```bash
docker compose up --build -d
```

## Derrubar containers

```bash
docker compose down
```

## Verificar containers

```bash
docker ps
```

## Visualizar logs

```bash
docker logs rm557323-api
docker logs rm557323-postgres
```

---

# 💾 Persistência de Dados

O PostgreSQL utiliza um volume nomeado:

```yaml
postgres_data:
```

Garantindo persistência dos dados mesmo após reinicializações dos containers.

---

# 🔒 Segurança

A aplicação é executada utilizando um usuário não-root:

```txt
appuser
```

seguindo as boas práticas de segurança para containers Docker.

---

# ☁️ Deploy na Azure

## Azure App Service

```txt
orbitalalert-api-rm557323
```

## Azure Database for PostgreSQL

```txt
orbital-postgres-rm557323
```

## Swagger Publicado

```txt
https://orbitalalert-api-rm557323-czdna8eddqfzgrbc.brazilsouth-01.azurewebsites.net/swagger
```

---

# 👨‍💻 Autores

**Carlos Eduardo Rodrigues Coelho Pacheco**  
RM: 557323

**João Pedro Amorim Brito Virgens**  
RM: 559213

**Pedro Augusto Costa Ladeira**  
RM: 558514

---

Projeto acadêmico desenvolvido para a FIAP utilizando ASP.NET Core 8, PostgreSQL, Docker, Docker Compose, Azure App Service, Azure Database for PostgreSQL e integração com a API pública da NASA.
