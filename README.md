<h1 align = "center">D_NOTEPAD</h1> 

<img src="https://raw.githubusercontent.com/Aldacelio/front-end-D_Notepad/main/src/assets/images/bannerGit.PNG" width="1300px">

## Tecnologias usadas

* C#
* Entity Framework Core
* ASP.NET Core
* PostgreSQL

## Objetivo do projeto

* O objetivo deste projeto é permitir que os usuários cadastrem, excluam e editem pensamentos. O aplicativo foi desenvolvido usando as melhores práticas de desenvolvimento web e arquiteturas modernas.

## Boas práticas

* Utilização do padrão de injeção de dependência.
* Separado em camadas (Controller, Repository, Model).
* Utilização de migrations para controle de versão do banco de dados.

## Arquitetura do projeto

* O projeto segue uma arquitetura MVC (Model-View-Controller) para a separação de responsabilidades. As entidades e a camada de acesso a dados são gerenciadas pelo Entity Framework Core.

## Pré-requisitos
* Certifique-se de ter o .NET Core SDK instalado em sua máquina. Você pode baixá-lo e instalá-lo a partir do seguinte link: [Download .NET Core](https://dotnet.microsoft.com/download).
* Certifique-se de ter o PostgreSQL instalado e em execução.

## Como executar o projeto

### **Para executar o projeto localmente, siga estas etapas:**

1. Clone este repositório para o seu computador. Você pode fazer isso usando o seguinte comando no terminal:

   `git clone https://github.com/Aldacelio/back-end-D_Notepad.git`

2. Navegue até a pasta do projeto usando o terminal. Você pode fazer isso usando o seguinte comando:

   `cd caminho/para/o/diretorio/do/projeto`

3. Restaure as dependências do projeto:

   `dotnet restore`

4. Atualize a string de conexão com o banco de dados no arquivo `ConnectionContext.cs`.

5. Execute as migrações para criar o banco de dados:

    `dotnet ef database update`

6. Compile e execute o projeto:

    `dotnet run`

7. Acesse a aplicação em http://localhost:5161/swagger/index.html.

## Aplicação em uso
<div align="center">

### Tela inicial

<img src="https://raw.githubusercontent.com/Aldacelio/front-end-D_Notepad/main/src/assets/images/Mural%20de%20Pensamentos.gif" width="480px">

### Criar pensamento

<img src="https://raw.githubusercontent.com/Aldacelio/front-end-D_Notepad/main/src/assets/images/Criar%20Pensamento.gif" width="480px">

### Editar pensamento

<img src="https://raw.githubusercontent.com/Aldacelio/front-end-D_Notepad/main/src/assets/images/Editar%20Pensamento.gif" width="480px">

### Excluir pensamento

<img src="https://raw.githubusercontent.com/Aldacelio/front-end-D_Notepad/main/src/assets/images/Excluir%20Pensamento.gif" width="480px">
</div>
<br>
<b>Lembrando que essa aplicação em uso não é apenas o back e sim a integração dele com front-end em Angular. Segue o link para o front-end do projeto:</b> https://github.com/Aldacelio/front-end-D_Notepad
