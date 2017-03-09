Aplicação Web Api, testes de integração e continuos integration docker e build automaticos com circleci


Instalar o node JS
https://nodejs.org/en/

Instalar o .net core 1.1 (somente)
https://www.asp.net/core


Preparação do ambiente.

1)Instalar visual studio code.
https://code.visualstudio.com/download



2)Instalar npm yeoman e bower

npm install -g npm

npm install -g yo bower


3) Visualizar versão instalação

npm -v
node -v


4) Instalar gerador de template aspnet 

npm i -g generator-aspnet


Criação do projeto

1)Criar pasta 

mkdir src

2)Dentro da pasta SRC .. cd src

yo aspnet 

cd "Crud"
dotnet restore
dotnet build 

Alterar connectionString

http://www.developerfusion.com/tools/sql-connection-string/

dotnet ef database update (to create the SQLite database for the project)
dotnet run



Criar Controller.

Criar View.

Configurar Rota padrão.


https://wandelsonbezer.wixsite.com/netcore



Debug no Windows Vs Code

  "buildOptions": {
    "emitEntryPoint": true,
    "preserveCompilationContext": true,
     "debugType": "portable"
  },



Bower.

bower init

bower install bootstrap --save



CTRL + shift + p  =  usar extensao VS CODE 

CTRL + shift + e =  executa sql

migrations


Install package EntityFramewrokCore
Install package EntityFrameworkCore.Tools - pre

get-help EntityFrameworkCore

get-help add-migration

Adiciona migração 

dotnet ef migrations add MigracaoInicial

Remove a última migração

dotnet ef migrations remove 

executar migration 

dotnet ef database update


Script-Migration gera o sql da migração muito bom uso em produção.


update-database -verbose ambiente de homologação






dotnet ef dbcontext scaffold "Data Source=thinkerp.cf5cl9qlwhk1.sa-east-1.rds.amazonaws.com;Initial Catalog=API;User ID=thinkerpuser; Password=ZWDLEBTO; MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -f -o Models  -t dbo.cities 



Erro de dominio não é uma excessão.

Regra de negocio é notificação..

Exception erro não esperado.


xunit

Teste de integração não rodar testes em paralelo.

Testes de unidade podemos rodar testes em paralelo.


Asp.net core TestHost

substitui a necessidade de um host real para testes de integração.

TestServer automatiza sempre entregar codigo de qualidade substitui o postman.