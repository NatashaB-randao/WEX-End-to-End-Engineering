# Documento de Fluxo de Trabalho - SwagLabs Shopping

## Informações do Projeto
- **Nome do Projeto:** SwagLabs Shopping (SS)
- **Tipo:** Sistema de E-commerce
- **Plataforma:** Jira Software
- **Link do Fluxo:** https://natashabrandao.atlassian.net/jira/software/projects/SS/settings/issuetypes/10010/workflow
- **Data de Criação:** 04 de Julho de 2025

---

## Visão Geral do Fluxo

Este documento define os fluxos de trabalho para o projeto SwagLabs Shopping, estabelecendo um processo estruturado para desenvolvimento, testes e entrega de funcionalidades.

### Objetivo
Garantir qualidade, rastreabilidade e eficiência no desenvolvimento de funcionalidades do sistema de e-commerce, com foco especial na qualidade através de testes rigorosos.

---

## Fluxo de Trabalho Principal

### Diagrama do Fluxo
```
COMEÇAR → TO DO → IN PROGRESS → READY FOR TEST → IN TEST → APPROVED → DONE
                      ↑                              ↓
                      ← ← ← ← ← REOPENED ← ← ← ← ← ←
```

---

## Estados e Transições

### 1. **TO DO** 
- **Categoria:** To Do
- **Descrição:** Tarefa criada e aguardando início do desenvolvimento
- **Responsável:** Product Owner / Scrum Master
- **Critérios de Entrada:**
  - User Story definida
  - Critérios de aceite documentados
  - Prioridade definida
  - Estimativa realizada
- **Ações Permitidas:**
  - Iniciar desenvolvimento
  - Editar requisitos
  - Alterar prioridade

### 2. **IN PROGRESS**
- **Categoria:** In Progress
- **Descrição:** Desenvolvimento em andamento
- **Responsável:** Developer
- **Critérios de Entrada:**
  - Developer assume a tarefa
  - Todos os requisitos estão claros
- **Atividades:**
  - Implementação da funcionalidade
  - Testes unitários
  - Code review interno
- **Critérios de Saída:**
  - Código implementado
  - Testes unitários passando
  - Code review aprovado
  - Deploy em ambiente de teste

### 3. **READY FOR TEST**
- **Categoria:** To Do
- **Descrição:** Desenvolvimento finalizado, aguardando testes
- **Responsável:** Developer → QA
- **Critérios de Entrada:**
  - Funcionalidade implementada
  - Ambiente de teste configurado
  - Documentação atualizada
- **Atividades:**
  - Handoff para equipe de QA
  - Preparação dos cenários de teste
  - Verificação de pré-requisitos

### 4. **IN TEST**
- **Categoria:** In Progress
- **Descrição:** Testes em execução pela equipe de QA
- **Responsável:** QA Tester
- **Critérios de Entrada:**
  - Cenários de teste definidos
  - Ambiente de teste disponível
  - Dados de teste preparados
- **Atividades:**
  - Execução de testes funcionais
  - Testes de regressão
  - Validação dos critérios de aceite
  - Documentação de bugs (se encontrados)
- **Possíveis Saídas:**
  - **APPROVED:** Todos os testes passaram
  - **REOPENED:** Bugs encontrados

### 5. **APPROVED**
- **Categoria:** Done
- **Descrição:** Testes aprovados, pronto para produção
- **Responsável:** QA Tester
- **Critérios de Entrada:**
  - Todos os testes passaram
  - Critérios de aceite validados
  - Sem bugs críticos ou bloqueadores
- **Atividades:**
  - Aprovação final da funcionalidade
  - Preparação para deploy em produção
  - Documentação de teste finalizada

### 6. **DONE**
- **Categoria:** Done
- **Descrição:** Tarefa completamente finalizada
- **Responsável:** DevOps / Tech Lead
- **Critérios de Entrada:**
  - Funcionalidade aprovada em testes
  - Deploy realizado com sucesso
  - Validação em produção
- **Atividades:**
  - Monitoramento pós-deploy
  - Fechamento da tarefa
  - Atualização de documentação

### 7. **REOPENED**
- **Categoria:** To Do
- **Descrição:** Tarefa retornada devido a problemas encontrados
- **Responsável:** QA Tester
- **Critérios de Entrada:**
  - Bugs encontrados durante testes
  - Critérios de aceite não atendidos
  - Regressão identificada
- **Atividades:**
  - Documentação detalhada dos problemas
  - Priorização dos bugs
  - Reassignação para developer

---

## Regras de Transição

### Transições Permitidas:

1. **TO DO → IN PROGRESS**
   - Automática quando developer assume a tarefa
   - Requer: Assignee definido

2. **IN PROGRESS → READY FOR TEST**
   - Manual pelo developer
   - Requer: Checklist de desenvolvimento completo

3. **READY FOR TEST → IN TEST**
   - Manual pelo QA
   - Requer: Ambiente de teste validado

4. **IN TEST → APPROVED**
   - Manual pelo QA
   - Requer: Todos os testes passaram

5. **IN TEST → REOPENED**
   - Manual pelo QA
   - Requer: Bugs documentados

6. **REOPENED → IN PROGRESS**
   - Manual pelo developer
   - Requer: Análise dos problemas reportados

7. **APPROVED → DONE**
   - Manual pelo Tech Lead/DevOps
   - Requer: Deploy em produção realizado

---

## Papéis e Responsabilidades

### **Product Owner**
- Criação e priorização de User Stories
- Definição de critérios de aceite
- Validação final do produto

### **Scrum Master**
- Facilitação do processo
- Remoção de impedimentos
- Monitoramento do fluxo

### **Developer**
- Implementação das funcionalidades
- Testes unitários
- Code review
- Correção de bugs

### **QA Tester**
- Planejamento de testes
- Execução de testes funcionais
- Validação de critérios de aceite
- Documentação de bugs

### **DevOps/Tech Lead**
- Deploy em ambientes
- Monitoramento pós-deploy
- Configuração de infraestrutura

---

## Métricas e Indicadores

### **Lead Time**
- Tempo médio de TO DO até DONE
- Meta: < 5 dias úteis

### **Cycle Time**
- Tempo médio de IN PROGRESS até DONE
- Meta: < 3 dias úteis

### **Taxa de Retrabalho**
- Percentual de tarefas que vão para REOPENED
- Meta: < 15%

### **Throughput**
- Número de tarefas finalizadas por sprint
- Meta: Baseline estabelecido após 3 sprints

### **Qualidade**
- Número de bugs encontrados em produção
- Meta: < 2 bugs por release

---

## Critérios de Qualidade

### **Definition of Ready (DoR)**
- [ ] User Story escrita no formato padrão
- [ ] Critérios de aceite definidos
- [ ] Estimativa realizada
- [ ] Dependências identificadas
- [ ] Mockups/wireframes disponíveis (se aplicável)

### **Definition of Done (DoD)**
- [ ] Código implementado e revisado
- [ ] Testes unitários criados e passando
- [ ] Testes funcionais executados e aprovados
- [ ] Documentação atualizada
- [ ] Deploy realizado com sucesso
- [ ] Monitoramento pós-deploy validado

---

## Cenários de Exceção

### **Bugs Críticos em Produção**
- Criação de Hotfix
- Fluxo acelerado: TO DO → IN PROGRESS → DONE
- Aprovação do Product Owner obrigatória

### **Mudanças de Escopo**
- Retorno para TO DO
- Reavaliação de critérios
- Nova estimativa necessária

### **Impedimentos Técnicos**
- Status "Blocked" (sub-status de IN PROGRESS)
- Escalation para Tech Lead
- Documentação do impedimento

---

## Configurações no Jira

### **Campos Obrigatórios por Status:**
- **IN PROGRESS:** Assignee, Sprint
- **READY FOR TEST:** Test Environment URL
- **IN TEST:** Test Cases Executed
- **REOPENED:** Bug Details, Priority
- **APPROVED:** Test Sign-off
- **DONE:** Production URL

### **Automações Configuradas:**
- Notificação ao QA quando status = READY FOR TEST
- Atribuição automática ao reporter quando status = REOPENED
- Logging de tempo automático em transições

---

## Boas Práticas

### **Para Developers:**
- Sempre atualizar comentários ao mover tarefas
- Incluir links para PRs e branches
- Documentar decisões técnicas importantes

### **Para QA:**
- Documentar cenários de teste executados
- Incluir evidências (screenshots, logs)
- Classificar bugs por severidade

### **Para Product Owner:**
- Revisar tarefas em APPROVED antes de DONE
- Manter critérios de aceite atualizados
- Priorizar correções de bugs

---

## Revisão e Melhoria Contínua

### **Retrospectivas:**
- Análise do fluxo a cada sprint
- Identificação de gargalos
- Propostas de melhoria

### **Revisão Trimestral:**
- Análise de métricas
- Ajustes no fluxo se necessário
- Atualização de critérios de qualidade

---

## Conclusão

Este fluxo de trabalho foi projetado para garantir qualidade e eficiência no desenvolvimento do SwagLabs Shopping, com foco especial na validação rigorosa através de testes. A implementação adequada deste processo, junto com o monitoramento contínuo das métricas definidas, deve resultar em entregas de alta qualidade e satisfação do cliente.

---

*Documento criado em 04/07/2025 - Versão 1.0*
*Projeto: SwagLabs Shopping (SS)*
*Responsável: [Natasha Brandão]*