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
- ⏳ Atualizar uma tarefa (`PUT /tasks/{id}`)
- ⏳ Excluir uma tarefa (`DELETE /tasks/{id}`)

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

## 📅 Status do Projeto
🚧 **Em desenvolvimento** – Atualmente implementado apenas o **Create** (registro de tarefa).  
As próximas etapas seguirão a mesma arquitetura.

---

## 📄 Licença
Este projeto é de uso livre para fins de estudo, seguindo a proposta da Rocketseat no curso **Formação C#**.

---

## 📬 Contato
📧 **Theo Rondon** – [LinkedIn](https://www.linkedin.com/in/th%C3%A9o-rondon-b7259726b/) | [GitHub](https://github.com/TheoRondon25)
