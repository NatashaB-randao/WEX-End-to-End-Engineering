# Cenário de Teste 2: Login com Credenciais Inválidas
## Formato Zephyr - JIRA
## Step by Step
---

### **PASSO 1**
**PASSO:** Acessar a página de login do sistema  
**DADOS DE TESTE:** Servidor QA  
**RESULTADO ESPERADO:** Página de login carregada com campos Username e Password visíveis

---

### **PASSO 2**
**PASSO:** Verificar elementos da página  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Todos os elementos estão visíveis e funcionais

---

### **PASSO 3**
**PASSO:** Inserir credenciais inválidas no campo Username  
**DADOS DE TESTE:** usuario_inexistente@teste.com  
**RESULTADO ESPERADO:** Campo preenchido com o valor informado

---

### **PASSO 4**
**PASSO:** Inserir senha inválida no campo Password  
**DADOS DE TESTE:** senha_incorreta123  
**RESULTADO ESPERADO:** Campo preenchido com valor mascarado (asteriscos)

---

### **PASSO 5**
**PASSO:** Clicar no botão "Login"  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Sistema processa a tentativa de login

---

### **PASSO 6**
**PASSO:** Verificar exibição de mensagem de erro  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Mensagem de erro "Credenciais inválidas" é exibida na tela

---

### **PASSO 7**
**PASSO:** Verificar se permanece na página de login  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Usuário continua na página de login, URL não é alterada

---

## Variações de Dados de Teste

### **Massa de Dados para Testes Adicionais:**

| Caso | Username | Password | Cenário |
|------|----------|----------|---------|
| 1 | usuario_inexistente@teste.com | senha123 | Usuário não cadastrado |
| 2 | admin@teste.com | senha_errada | Senha incorreta |
| 3 | email_invalido | senha123 | Formato de email inválido |
| 4 | admin@teste.com | (vazio) | Campo senha vazio |
| 5 | (vazio) | senha123 | Campo username vazio |
| 6 | admin@teste.com | 123 | Senha muito curta |

---

## Informações Complementares

### **Pré-condições:**
- Sistema deve estar disponível no ambiente de QA
- Página de login deve estar acessível
- Navegador deve estar configurado corretamente

### **Critérios de Aceitação:**
- Sistema deve rejeitar credenciais inválidas
- Mensagem de erro deve ser clara e não revelar informações sensíveis
- Usuário deve permanecer na página de login
- Sistema deve permitir nova tentativa de login

### **Observações para Execução:**
- Testar em diferentes navegadores (Chrome, Firefox, Edge)
- Verificar comportamento em dispositivos móveis
- Validar se há limite de tentativas (se aplicável)
- Confirmar se logs de segurança são gerados

### **Defeitos Possíveis:**
- Sistema permite login com credenciais inválidas
- Mensagem de erro não é exibida
- Redirecionamento indevido para página interna
- Erro 500 ou travamento do sistema
- Mensagem revela informações do banco de dados