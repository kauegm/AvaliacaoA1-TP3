# Sistema de Distribuidora de Bebidas

Este projeto é um sistema de gerenciamento para uma distribuidora de bebidas, desenvolvido em ASP.NET MVC no Visual Studio Community. A aplicação possui telas públicas para exibição de informações gerais, além de funcionalidades privadas, acessíveis apenas por usuários autenticados.

## Funcionalidades

- **Telas Públicas:**
  - Página inicial com informações gerais sobre a distribuidora.
  - Listagem de produtos disponíveis.
  - Contato para clientes.

- **Funcionalidades Privadas (CRUDs):**
  - **Produto**: Cadastro e gerenciamento dos produtos no estoque.
  - **Categoria**: Organização dos produtos por categoria.
  - **Fornecedor**: Registro e controle dos fornecedores.
  - **Cliente**: Gerenciamento dos dados dos clientes.
  - **Pedido**: Criação e acompanhamento de pedidos.
  - **Estoque**: Controle e monitoramento do estoque.

- **Autenticação e Autorização**:
  - Sistema de login desenvolvido na própria IDE (VS Community) com autenticação individual e integração opcional com provedores externos.

## Tecnologias Utilizadas

- **ASP.NET MVC** para desenvolvimento da aplicação web.
- **Entity Framework** para gerenciamento do banco de dados e das relações entre entidades.
- **SQL Server** como banco de dados relacional.

## Arquitetura do Projeto

A aplicação utiliza uma arquitetura MVC (Model-View-Controller) com um modelo de relacionamento 1:N entre as entidades. Esse modelo permite que cada entidade, como Cliente ou Pedido, tenha várias referências associadas, facilitando o gerenciamento e consulta de dados.

## Como Rodar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/kauegm/AvaliacaoA1.TP3.git
