# Título do repositório
Estacionamento

## Tecnologias utilizadas
- .NET 6
- Sql Server
- Docker

## Para executar, deve-se:

## Regras de negócio
### Estacionamentos:
- Um estacionamento pode ter somente um cadastro ativo, definido pelo seu CNPJ
- No momento do cadastro será informado a capacidade máxima de vagas em dois grupos: motocicletas e carros/vans 
- Será efetuado um controle máximo de vagas disponíveis, conforme capacidades informadas anteriormente
### Usuários:
- Poderá haver somente um cadastro de usuário por CPF
- Usuário será separado por nível de perfil, sendo eles: administrador, operador e cliente. Os níveis serão separados no momento do cadastro e validados por CPF
- O perfil "usuário" não poderá realizar nenhuma atividade no sistema
- O perfil "operador", poderá somente realizar as seguintes atividades: Cadastrar novos usuários do nível cliente, realizar a abertura e fechamento de tickets de estacionamento e cadastro de novos veículos
- O perfil "administrador" poderá realizar todas as atividades que o nível operador realizar, além de poder realizar novos cadastros de usuários (operadores e administradores) ao sistema e realizar consulta de fluxo de caixa filtrado por período

### Veículos:
- Cada veículo poderá ter somente um cadastro, definido pela sua placa
- Ao realizar o cadastro de veículo deve-se informar um cliente responsável pelo mesmo

### Tickets:
- Cada veículo poderá ter somente um ticket em aberto por vez
- O valor do ticket irá variar conforme foi configurado a cobrança no momento do cadastro de estacionamento