# User Stories - SauceDemo (Swag Labs)

## Informações do Projeto
- **Site:** https://www.saucedemo.com/
- **Tipo:** E-commerce de demonstração
- **Produto:** Swag Labs - Loja virtual de produtos diversos

---

## Épicos Identificados

### 1. **Épico: Autenticação e Acesso**
Permitir que usuários façam login e logout no sistema de forma segura.

### 2. **Épico: Gestão de Produtos**
Permitir que usuários visualizem, filtrem e interajam com o catálogo de produtos.

### 3. **Épico: Carrinho de Compras**
Permitir que usuários adicionem, removam e gerenciem produtos no carrinho.

### 4. **Épico: Processo de Checkout**
Permitir que usuários finalizem suas compras com segurança.

---

## User Stories

### **User Story 1: Login no Sistema**

**Épico:** Autenticação e Acesso

#### **Narrativa do Usuário:**
```
Como um cliente da Swag Labs
Eu quero fazer login no sistema
Para que eu possa acessar minha conta e realizar compras
```

#### **Entrega de Valor:**
Permitir acesso seguro ao sistema para usuários autenticados, garantindo personalização da experiência de compra.

#### **Requisitos Técnicos:**

**a) Atores:**
- Cliente/Usuário final
- Sistema de autenticação

**b) Interfaces/Fluxos:**
- Página de login com campos de usuário e senha
- Redirecionamento para página de inventário após login bem-sucedido
- Tratamento de erros de autenticação

**c) Dados:**
- Username (obrigatório)
- Password (obrigatório)
- Sessão do usuário

**d) Regras de Negócio:**
- Usuários válidos: standard_user, locked_out_user, problem_user, performance_glitch_user
- Senha padrão: secret_sauce
- Usuário locked_out_user deve ser bloqueado
- Máximo de tentativas de login: 3 tentativas
- Sessão expira após inatividade de 30 minutos

**e) Ambiente:**
- Compatibilidade com navegadores: Chrome, Firefox, Safari, Edge
- Responsivo para desktop e mobile
- Suporte a HTTPS

#### **Critérios de Aceite:**

**Cenário 1: Login bem-sucedido**
- **Dado que** um usuário está na página de login
- **E** possui credenciais válidas
- **Quando** inserir username e password corretos
- **E** clicar no botão "Login"
- **Então** deve ser redirecionado para a página de inventário
- **E** deve visualizar os produtos disponíveis

**Cenário 2: Login com credenciais inválidas**
- **Dado que** um usuário está na página de login
- **Quando** inserir credenciais inválidas
- **E** clicar no botão "Login"
- **Então** deve exibir mensagem de erro
- **E** deve permanecer na página de login

**Cenário 3: Usuário bloqueado**
- **Dado que** um usuário locked_out_user tenta fazer login
- **Quando** inserir as credenciais
- **E** clicar no botão "Login"
- **Então** deve exibir mensagem "Sorry, this user has been locked out"
- **E** não deve permitir o acesso

**Cenário 4: Campos obrigatórios**
- **Dado que** um usuário está na página de login
- **Quando** deixar campos username ou password vazios
- **E** clicar no botão "Login"
- **Então** deve exibir mensagem de erro indicando campos obrigatórios

---

### **User Story 2: Adicionar Produto ao Carrinho**

**Épico:** Carrinho de Compras

#### **Narrativa do Usuário:**
```
Como um cliente autenticado da Swag Labs
Eu quero adicionar produtos ao meu carrinho de compras
Para que eu possa reunir os itens desejados antes de finalizar a compra
```

#### **Entrega de Valor:**
Permitir que o usuário selecione produtos de interesse e os organize em um carrinho para posterior finalização da compra.

#### **Requisitos Técnicos:**

**a) Atores:**
- Cliente autenticado
- Sistema de carrinho de compras
- Sistema de inventário

**b) Interfaces/Fluxos:**
- Página de inventário com lista de produtos
- Botão "Add to cart" em cada produto
- Contador de itens no carrinho (badge)
- Página do carrinho com produtos selecionados

**c) Dados:**
- ID do produto
- Nome do produto
- Preço do produto
- Imagem do produto
- Quantidade no carrinho
- Total do carrinho

**d) Regras de Negócio:**
- Usuário deve estar autenticado
- Produto deve estar disponível em estoque
- Quantidade padrão: 1 unidade por clique
- Carrinho persiste durante a sessão
- Máximo de 99 unidades por produto
- Preços em USD

**e) Ambiente:**
- Funcionalidade disponível em todas as páginas após login
- Sincronização em tempo real do contador do carrinho
- Persistência de dados durante a sessão

#### **Critérios de Aceite:**

**Cenário 1: Adicionar produto com sucesso**
- **Dado que** um usuário está logado na página de inventário
- **E** visualiza a lista de produtos disponíveis
- **Quando** clicar no botão "Add to cart" de um produto
- **Então** o produto deve ser adicionado ao carrinho
- **E** o contador do carrinho deve ser incrementado
- **E** o botão deve mudar para "Remove"

**Cenário 2: Visualizar carrinho com produtos**
- **Dado que** um usuário adicionou produtos ao carrinho
- **Quando** clicar no ícone do carrinho
- **Então** deve ser redirecionado para a página do carrinho
- **E** deve visualizar todos os produtos adicionados
- **E** deve ver o nome, preço e imagem de cada produto

**Cenário 3: Remover produto do carrinho**
- **Dado que** um usuário tem produtos no carrinho
- **E** está na página de inventário
- **Quando** clicar no botão "Remove" de um produto
- **Então** o produto deve ser removido do carrinho
- **E** o contador do carrinho deve ser decrementado
- **E** o botão deve voltar para "Add to cart"

**Cenário 4: Carrinho vazio**
- **Dado que** um usuário está na página do carrinho
- **E** não possui produtos adicionados
- **Quando** visualizar a página
- **Então** deve exibir mensagem indicando carrinho vazio
- **E** deve disponibilizar opção para continuar comprando

**Cenário 5: Persistência do carrinho**
- **Dado que** um usuário adicionou produtos ao carrinho
- **Quando** navegar para outras páginas do site
- **E** retornar à página do carrinho
- **Então** os produtos devem permanecer no carrinho
- **E** o contador deve manter a quantidade correta

---

### **User Story 3: Finalizar Compra**

**Épico:** Processo de Checkout

#### **Narrativa do Usuário:**
```
Como um cliente da Swag Labs com produtos no carrinho
Eu quero finalizar minha compra fornecendo informações de entrega
Para que eu possa receber os produtos adquiridos
```

#### **Entrega de Valor:**
Permitir que o usuário complete o processo de compra de forma segura e eficiente, fornecendo informações necessárias para entrega.

#### **Requisitos Técnicos:**

**a) Atores:**
- Cliente autenticado
- Sistema de checkout
- Sistema de pagamento (simulado)

**b) Interfaces/Fluxos:**
- Página do carrinho com botão "Checkout"
- Formulário de informações do cliente
- Página de revisão da compra
- Página de confirmação da compra

**c) Dados:**
- First Name (obrigatório)
- Last Name (obrigatório)
- Postal Code (obrigatório)
- Lista de produtos no carrinho
- Valores: subtotal, tax, total

**d) Regras de Negócio:**
- Carrinho deve conter pelo menos 1 produto
- Todos os campos do formulário são obrigatórios
- Tax fixo: $2.40
- Cálculo do total: subtotal + tax
- Após finalização, carrinho deve ser limpo

**e) Ambiente:**
- Processo deve ser concluído em uma única sessão
- Validação de formulário client-side e server-side
- Simulação de processamento de pagamento

#### **Critérios de Aceite:**

**Cenário 1: Checkout bem-sucedido**
- **Dado que** um usuário tem produtos no carrinho
- **E** está na página do carrinho
- **Quando** clicar no botão "Checkout"
- **Então** deve ser redirecionado para o formulário de informações
- **E** deve preencher todos os campos obrigatórios
- **E** clicar em "Continue"
- **Então** deve visualizar a página de revisão da compra
- **E** deve ver o resumo dos produtos e valores
- **E** clicar em "Finish"
- **Então** deve ser redirecionado para a página de confirmação
- **E** deve exibir mensagem "THANK YOU FOR YOUR ORDER"

**Cenário 2: Validação de campos obrigatórios**
- **Dado que** um usuário está no formulário de checkout
- **Quando** deixar algum campo obrigatório vazio
- **E** clicar em "Continue"
- **Então** deve exibir mensagem de erro específica
- **E** deve destacar o campo com problema
- **E** deve permanecer na página do formulário

**Cenário 3: Revisão da compra**
- **Dado que** um usuário preencheu as informações de checkout
- **E** está na página de revisão
- **Quando** visualizar o resumo
- **Então** deve ver todos os produtos com nome, preço e quantidade
- **E** deve ver o subtotal calculado corretamente
- **E** deve ver o valor do tax ($2.40)
- **E** deve ver o total final (subtotal + tax)

**Cenário 4: Cancelar checkout**
- **Dado que** um usuário está em qualquer etapa do checkout
- **Quando** clicar no botão "Cancel"
- **Então** deve retornar à página do carrinho
- **E** os produtos devem permanecer no carrinho
- **E** nenhuma alteração deve ser feita no pedido

---

## Considerações Técnicas INVEST

### **Independente (Independent):**
- Cada User Story pode ser desenvolvida e testada independentemente
- Não há dependências críticas entre as funcionalidades

### **Negociável (Negotiable):**
- Detalhes específicos podem ser ajustados conforme necessidade
- Critérios de aceite podem ser refinados com o time

### **Valiosa (Valuable):**
- Cada história entrega valor direto ao usuário final
- Funcionalidades essenciais para um e-commerce

### **Estimável (Estimable):**
- Escopo bem definido permite estimativas precisas
- Complexidade média para equipes experientes

### **Pequena (Small):**
- Cada US pode ser desenvolvida em 1-2 sprints
- Escopo limitado e focado

### **Testável (Testable):**
- Critérios de aceite específicos e mensuráveis
- Cenários de teste bem definidos

---

## Técnicas Adicionais Sugeridas

### **Mapeamento de Jornada do Usuário:**
1. Acesso → Login → Navegação → Seleção → Carrinho → Checkout → Confirmação

### **Prototipagem:**
- Wireframes das telas principais
- Fluxos de navegação
- Estados de erro e sucesso

### **Testes de Usabilidade:**
- Cenários de teste com usuários reais
- Análise de conversão do funil de vendas
- Feedback sobre experiência do usuário

---

*Documento elaborado seguindo as melhores práticas de escrita de User Stories e metodologia ágil.*