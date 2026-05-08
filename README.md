<div align="center">

# MuralFatec

Projeto acadêmico desenvolvido em aula com foco em arquitetura em camadas e persistência de dados. O objetivo é organizar entidades acadêmicas (instituição, cursos, disciplinas, mensagens e anexos) em um mural estruturado.

</div>

## Visão Geral

- Arquitetura em camadas (Domain, DAL, BLL).
- Persistência com Entity Framework Core e SQL Server.
- Entidades voltadas ao contexto educacional (usuário, professor, curso, disciplina, mensagem, tags e anexos).

## Tecnologias Utilizadas

- **Linguagem:** C#  
- **Framework:** .NET (Target: net10.0)  
- **ORM:** Entity Framework Core  
- **Banco de Dados:** SQL Server  

## Estrutura do Projeto

- **MuralFatecDomain**: entidades, contratos e valores do domínio.
- **MuralFatecDal**: contexto do EF Core, repositórios e migrations.
- **MuralFatecBll**: regras de negócio e serviços.
- **MuralFatecDAO**: projeto auxiliar para organização de domínio e acesso a dados.

## Entidades Principais

- Instituição
- Usuário
- Professor
- Curso
- Disciplina
- Mensagem
- Anexo
- Tag / TagMensagem

## Como Executar (Local)

1. **Pré-requisitos:** .NET SDK 10.0 e SQL Server.
2. **Clone o repositório:**
   ```bash
   git clone https://github.com/BrunoCamiloRibeiro/MuralFatec.git
   ```
3. **Ajuste a conexão no DbContext** em `MuralFatecDal/Data/SqlServerData.cs`.
4. **Execute o projeto** pelo Visual Studio ou via `dotnet run`.

## Observações

Projeto desenvolvido em ambiente acadêmico para estudo de arquitetura, organização de camadas e persistência com EF Core.
