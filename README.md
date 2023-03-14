# API C# com Odata.

<h4>Finalidade</h4>

O projeto foi criado para que, de forma simples, pudesse habiltar e testar as ferramentas que o Odata V4 oferece.

------------
<h4>Programas utilizados</h4>

- Visual Studio 2022.
- .NET 6.
- SQLiteStudio.

------------

#### Bibliotecas utilizadas

[(Microsoft.AspNetCore.OData) Biblioteca utilizada para implementar o Odata V4.](https://www.nuget.org/packages/Microsoft.AspNetCore.OData)

[(System.Data.SQLite) Biblioteca utilizada para a implantação do SQLite.](https://www.nuget.org/packages/System.Data.SQLite)

------------

#### Funcionalidades

- Todas as funcinalidades de query do [Odata V4](https://docs.oasis-open.org/odata/new-in-odata/v4.01/new-in-odata-v4.01.html).
- Paginação de requisição.

------------

#### Aplicação em funcionamento.

- Busca de pessoas com mais de 18 anos.
![](https://raw.githubusercontent.com/talesxavier1/Arquivos/main/Odata_CSharp/Odata_cshar__p_request_semente_usuarios_mais_de_18.gif )

- Busca com somente CPF e Nome de retorno.
![](https://raw.githubusercontent.com/talesxavier1/Arquivos/main/Odata_CSharp/Odata_cshar__Somente%20nome%20e%20CPF.gif )


- Busca com ordenação de Idade decrescente.
![](https://raw.githubusercontent.com/talesxavier1/Arquivos/main/Odata_CSharp/Odata_cshar__Idade%20decrescente.gif )
