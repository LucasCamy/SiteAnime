# SiteAnime / AnimeHub

Aplicação de catálogo de anime com API em ASP.NET Core e frontend em Flutter. Inclui integração com APIs públicas de metadados, tradução e opções de processamento de imagem.

## Execução local

1. Copie `.env.example` para `.env` e defina uma senha de PostgreSQL e uma chave JWT longa e aleatória.
2. Execute `docker compose up --build` na raiz do projeto.
3. Para desenvolvimento apenas da API, consulte os arquivos em `Backend/SiteAnimes_Api`.

As senhas e chaves são fornecidas por variáveis de ambiente. O repositório não inclui contas administrativas prontas para uso. Imagens e metadados de anime retornados por serviços externos permanecem sujeitos aos direitos e termos de suas fontes.
