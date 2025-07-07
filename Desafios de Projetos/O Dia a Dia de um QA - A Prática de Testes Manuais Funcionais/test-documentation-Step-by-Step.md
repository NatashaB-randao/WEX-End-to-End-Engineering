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


---
# Casos de Teste e Análise de User Story

## 1. Caso de Teste Step by Step - Cadastro de Usuário

### **Cenário 3: Cadastro de novo usuário com dados válidos**

---

### **PASSO 1**
**PASSO:** Acessar a página de cadastro do sistema  
**DADOS DE TESTE:** URL do ambiente de QA  
**RESULTADO ESPERADO:** Página de cadastro carregada com formulário visível

---

### **PASSO 2**
**PASSO:** Preencher o campo Nome completo  
**DADOS DE TESTE:** João Silva Santos  
**RESULTADO ESPERADO:** Campo preenchido com o nome informado

---

### **PASSO 3**
**PASSO:** Preencher o campo E-mail  
**DADOS DE TESTE:** joao.santos@teste.com  
**RESULTADO ESPERADO:** Campo preenchido com e-mail válido

---

### **PASSO 4**
**PASSO:** Preencher o campo Senha  
**DADOS DE TESTE:** MinhaSenh@123  
**RESULTADO ESPERADO:** Campo preenchido com senha mascarada

---

### **PASSO 5**
**PASSO:** Preencher o campo Confirmar Senha  
**DADOS DE TESTE:** MinhaSenh@123  
**RESULTADO ESPERADO:** Campo preenchido com confirmação da senha

---

### **PASSO 6**
**PASSO:** Selecionar checkbox "Aceito os termos de uso"  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Checkbox marcado e habilitado

---

### **PASSO 7**
**PASSO:** Clicar no botão "Cadastrar"  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Sistema processa o cadastro

---

### **PASSO 8**
**PASSO:** Verificar mensagem de sucesso  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Mensagem "Cadastro realizado com sucesso" é exibida

---

### **PASSO 9**
**PASSO:** Verificar redirecionamento para página de login  
**DADOS DE TESTE:** -  
**RESULTADO ESPERADO:** Usuário é redirecionado para tela de login

---

