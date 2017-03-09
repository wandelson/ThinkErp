Template do projeto Think.Erp

Requerimento VS 2017

Docker Imagem SQL SERVER

docker comandos
 
docker -v 

docker images

Conteiner ativo
docker ps

Conteiner instanciado
docker ps -a

Depois rodar SQL com as credenciais

docker run -p 1433:1433 -e SA_PASSWORD=Workshop@123  -e ACCEPT_EULA=Y  microsoft/mssql-server-linux

docker logs

Baixar imagem

docker pull microsoft/mssql-server-linux

parar imagem
docker ps stop 3c

"DefaultConnection": "Data Source=localhost;Initial Catalog=workshop; MultipleActiveResultSets=true; Integrated Security=True"
