# Images.Api

Esta é uma API .Net que integra com um app flutter possuindo as funçoes de cadastrar,listar,excluir,like e dislike em imagens

## Instalação da Api

Devemos ter o Docker instalado em sua máquina.

Primeiro devemos rodar o comando a abaixo na raiz do projeto para gerar o banco da aplicação:

```bash
docker-compose up
```
Agora vamos rodar os seguintes comandos do dotnet:

```bash
dotnet restore
```
```bash
dotnet build
```
Devemos verificar a porta que será levantada nossa API, entre no arquivo Program.cs na linha 18 Certifique-se que a porta não está sendo usada.

Vamos abrir o teminal do VSCode na pasta 01_Presentation/API e rodar o camando abaixo:

```bash
dotnet run
```

## Arquivo de collections


[Collections da API](https://drive.google.com/file/d/11xAO6Yq32ftFrQawaxHOkGJjPQfh7lcz/view?usp=sharing)
