# 📝 Gerenciador de Tarefas - Rocketseat (Formação C# - Nível 4)

Este projeto é o **desafio prático** do nível 4 da Formação C# da **Rocketseat**.  
O objetivo é desenvolver uma **API de gerenciamento de tarefas** seguindo boas práticas de **arquitetura em camadas**.

Atualmente, o projeto está em desenvolvimento e será atualizado constantemente aqui no repositório.

---

## 📌 Funcionalidades (em desenvolvimento)

Uma tarefa deve conter os seguintes campos:
- `id` único para identificar cada tarefa
- `nome` da tarefa
- `descrição` detalhando o que deve ser feito
- `prioridade` (ex: **alta**, **média**, **baixa**)
- `data limite` para conclusão
- `status` (ex: **concluída**, **em andamento**, **aguardando**)

Endpoints previstos:
- ✅ Criar uma tarefa (`POST /tasks`)
- ✅ Listar todas as tarefas (`GET /tasks`)
- ✅ Visualizar tarefa por ID (`GET /tasks/{id}`)
- ✅ Atualizar uma tarefa (`PUT /tasks/{id}`)
- ✅ Excluir uma tarefa (`DELETE /tasks/{id}`)

> Os endpoints irão retornar **status codes apropriados** para cada situação.

---

## 🏗 Arquitetura

O projeto segue uma **arquitetura em camadas** para manter o código organizado e de fácil manutenção.

- **API_GerenciadorTarefas** → Camada de apresentação (Controllers, entrada/saída HTTP)
- **Gerenciador.Application** → Camada de regras de negócio (UseCases, lógica da aplicação)
- **Gerenciador.Communication** → Camada de comunicação (DTOs, Enums, Requests, Responses)

---

## 🚀 Tecnologias Utilizadas

- **.NET 8**
- **C#**
- **ASP.NET Core Web API**
- **Swagger** (planejado para documentação)
- **Arquitetura em camadas**

---

## ▶️ Como rodar o projeto

### Pré-requisitos

- .NET 8 SDK instalado  
- Visual Studio 2022 ou VS Code  

### Passos para execução

1) Clone o repositório:
```bash
    git clone https://github.com/TheoRondon25/API_GerenciadorTarefas.git
```

2) Acesse a pasta do projeto:
```bash
    cd API_GerenciadorTarefas
```
3) Abra a solução no Visual Studio ou, se preferir, execute via terminal:
```bash
    dotnet restore  
    dotnet run --project API_GerenciadorTarefas
```
4) A aplicação será iniciada e o Swagger ficará disponível em:
```bash
    https://localhost:xxxx/swagger
```
> A porta (`xxxx`) pode variar conforme sua configuração local.

A partir do Swagger é possível testar todos os endpoints da API diretamente pelo navegador.


---

## 📅 Status do Projeto

✅ **Finalizado** – Projeto finalizado com o objetivo de aprimoramento, onde possui apenas as chamadas dos endpoints (sem as regras de negócio) e a arquitetura de camadas.  
Em breve farei mais projetos com toda a regra de negócio, evoluindo cada vez mais.

---

## 📄 Licença
Este projeto é de uso livre para fins de estudo, seguindo a proposta da Rocketseat no curso **Formação C#**.

---

## 📬 Contato
📧 **Theo Rondon** – [LinkedIn](https://www.linkedin.com/in/th%C3%A9o-rondon-b7259726b/) | [GitHub](https://github.com/TheoRondon25)
