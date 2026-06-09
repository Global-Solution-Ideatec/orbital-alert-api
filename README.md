# 🚀 Orbital Alert API

API desenvolvida em ASP.NET Core 8 para monitoramento de alertas urbanos com integração à API pública da NASA APOD.

Projeto desenvolvido para a disciplina de DevOps Tools & Cloud Computing da FIAP.

---

# 🌍 Funcionalidades

- CRUD completo de Cities
- CRUD completo de Alerts
- Integração com API pública da NASA APOD
- Swagger para documentação e testes
- PostgreSQL com Entity Framework Core
- Docker e Docker Compose
- Deploy em Máquina Virtual Linux na Azure
- Persistência com volume Docker
- Arquitetura REST

---

# ☄️ Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- PostgreSQL 16
- Docker
- Docker Compose
- Ubuntu Server 24.04 LTS
- Azure Virtual Machine
- Swagger / OpenAPI
- NASA APOD API

---

# ☁️ Ambiente em Nuvem

A aplicação foi executada em uma **Máquina Virtual Linux na Microsoft Azure**, utilizando Docker e Docker Compose.

## VM Azure

```txt
Nome da VM: vm-orbitalalert-rm557323
Sistema operacional: Ubuntu Server 24.04 LTS
IP público: 4.228.218.78
```

## Containers executados na VM

```txt
rm557323-api
rm557323-postgres
```

## Swagger publicado pela VM

```txt
http://4.228.218.78:8080/swagger
```

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

# 🐳 Como Executar o Projeto na VM Azure

## 1️⃣ Conectar na VM

```bash
ssh azureuser@4.228.218.78
```

---

## 2️⃣ Atualizar pacotes da VM

```bash
sudo apt update
```

---

## 3️⃣ Instalar Docker, Docker Compose e Git

```bash
sudo apt install -y docker.io docker-compose-v2 git
```

---

## 4️⃣ Habilitar e iniciar Docker

```bash
sudo systemctl enable docker
sudo systemctl start docker
```

---

## 5️⃣ Clonar o repositório

```bash
git clone https://github.com/Global-Solution-Ideatec/orbital-alert-api.git
```

---

## 6️⃣ Entrar na pasta do projeto

```bash
cd orbital-alert-api
```

---

## 7️⃣ Subir os containers em segundo plano

```bash
docker compose up --build -d
```

---

## 8️⃣ Verificar containers em execução

```bash
docker ps
```

Resultado esperado:

```txt
rm557323-api
rm557323-postgres
```

---

# 🚀 Acessar Swagger

Abra no navegador:

```txt
http://4.228.218.78:8080/swagger
```

---

# 🐳 Docker Compose

O projeto utiliza Docker Compose para executar dois containers integrados na mesma rede Docker:

- Container da API ASP.NET Core
- Container PostgreSQL

## Container da API

```txt
Nome: rm557323-api
Porta: 8080
Usuário não-root: appuser
```

## Container do Banco

```txt
Nome: rm557323-postgres
Banco: PostgreSQL 16
Porta: 5432
Volume: postgres_data
```

---

# 🔒 Segurança

A aplicação é executada dentro do container com usuário não privilegiado:

```txt
appuser
```

Essa configuração é definida no Dockerfile para evitar execução da aplicação como root.

---

# 💾 Persistência de Dados

O PostgreSQL utiliza volume nomeado:

```yaml
postgres_data:
```

Esse volume garante persistência dos dados mesmo após reinicialização dos containers.

---

# 🌐 Rede Docker

Os containers são executados na mesma rede Docker:

```txt
orbital-network
```

A API se comunica com o banco utilizando o nome do container PostgreSQL:

```txt
Host=rm557323-postgres
```

---

# 🛢️ Banco de Dados

Banco utilizado:

```txt
PostgreSQL 16
```

## Tabela Cities

| Campo | Tipo |
|------|------|
| Id | Integer |
| Name | Text |
| State | Text |
| RiskLevel | Text |

## Tabela Alerts

| Campo | Tipo |
|------|------|
| Id | Integer |
| Type | Text |
| Description | Text |
| Severity | Text |
| CreatedAt | DateTime |
| CityId | Integer |

## Relacionamento

```txt
Cities 1:N Alerts
Alerts.CityId → Cities.Id
```

---

# 🌌 Endpoint NASA

## Buscar imagem astronômica do dia

```http
GET /api/Nasa/apod
```

---

# 🏙️ CRUD de Cities

## Criar cidade

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

## Listar cidades

```http
GET /api/Cities
```

---

## Buscar cidade por ID

```http
GET /api/Cities/{id}
```

---

## Atualizar cidade

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

## Remover cidade

```http
DELETE /api/Cities/{id}
```

---

# 🚨 CRUD de Alerts

## Criar alerta

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

## Listar alertas

```http
GET /api/Alerts
```

---

## Buscar alerta por ID

```http
GET /api/Alerts/{id}
```

---

## Atualizar alerta

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
  "createdAt": "2026-06-09T00:00:00Z",
  "cityId": 1
}
```

---

## Remover alerta

```http
DELETE /api/Alerts/{id}
```

---

# 📋 Comandos de Evidência

## Ver containers

```bash
docker ps
```

---

## Ver logs da API

```bash
docker logs rm557323-api
```

---

## Ver logs do PostgreSQL

```bash
docker logs rm557323-postgres
```

---

## Acessar container da API

```bash
docker exec -it rm557323-api sh
```

Dentro do container:

```bash
whoami
pwd
ls -l
```

Sair:

```bash
exit
```

---

## Acessar PostgreSQL

```bash
docker exec -it rm557323-postgres psql -U postgres -d orbitaldb
```

Dentro do PostgreSQL:

```sql
\dt
SELECT * FROM "Cities";
SELECT * FROM "Alerts";
```

Sair:

```sql
\q
```

---

## Ver volumes Docker

```bash
docker volume ls
```

---

# 🧪 Testes

Os testes foram realizados através do Swagger publicado na VM Azure:

```txt
http://4.228.218.78:8080/swagger
```

Foram testados:

- POST, GET, PUT e DELETE de Cities
- POST, GET, PUT e DELETE de Alerts
- GET da integração NASA APOD
- Persistência dos dados no PostgreSQL via SELECT
- Execução dos containers em segundo plano
- Logs dos containers
- Acesso ao terminal dos containers

---

# 👨‍💻 Autores

**Carlos Eduardo Rodrigues Coelho Pacheco**  
RM: 557323

**João Pedro Amorim Brito Virgens**  
RM: 559213

**Pedro Augusto Costa Ladeira**  
RM: 558514

---

Projeto acadêmico desenvolvido para a FIAP utilizando ASP.NET Core 8, PostgreSQL, Docker, Docker Compose, Azure Virtual Machine Linux e integração com a API pública da NASA.
