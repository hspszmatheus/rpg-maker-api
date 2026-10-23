# 🛡️ RPG Manager API

API simples para gerenciar personagens de RPG, focada em organização de código e boas práticas de .NET.

## 🚀 Como testar
1. Aperte **F5** no Visual Studio 2022.
2. Na página que abrir (Swagger), siga esta ordem:

* **Cadastrar:** Vá em `POST /api/Characters`, clique em **Try it out**, preencha o JSON e clique em **Execute**.
* **Listar:** Vá em `GET /api/Characters`, clique em **Try it out** e **Execute**. O herói aparecerá ali.

## 📁 Estrutura do Projeto
Organizei o código seguindo o padrão de mercado para facilitar a manutenção:
* **Controller:** Porta de entrada para as requisições HTTP.
* **DTOs:** Objetos para transferência de dados (Name, Description, UserId).
* **Interface & Service:** Onde a lógica de negócio e o armazenamento em memória acontecem.
* **Injeção de Dependência:** Configurada no `Program.cs`.

---
*Atividade desenvolvida para fins de estudo em .NET.*