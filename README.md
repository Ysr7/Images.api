# Images.Api

Trata-se de uma API construída em .NET com objetivo de integrar com o frontend do aplicativo, construído em flutter e tem como funções principais
Cadastrar, Listar, Excluir bem como dar Likes e Dislikes na imagem.

## Instalação da Api

Para funcionamento da API faz-se necessária a instalação do Docker(conforme
instruções ao fim da documentação), com a instalação do Docker concluída,
rode os seguintes comandos;

Para ter acesso ao banco da aplicação, rode o comando.
```bash
docker-compose up
```
Em seguida, rode o comando abaixo para restaurar as dependências do
projeto.
```bash
dotnet restore
```
Agora, rode o comando abaixo para compilar todo o projeto e suas
dependências.

```bash
dotnet build
```
Certifique-se de que a porta 8888 não esteja em uso, para isso abra o projeto
no caminho 01_Presentation/API/Program.cs. Em seguida, rode o comando para
iniciar a API

```bash
dotnet run
```

## Apoio 

### Collections:

Recomendo uso do arquivo no Postman
[Collections da API](https://drive.google.com/file/d/11xAO6Yq32ftFrQawaxHOkGJjPQfh7lcz/view?usp=sharing)

### Guia de Instalação Docker:

• Windows: https://docs.docker.com/docker-for-windows/install/
• MacOSX: https://docs.docker.com/docker-for-mac/install/
• Linux: https://www.digitalocean.com/community/tutorials/como-instalar-eusar-o-docker-no-ubuntu-18-04-pt
