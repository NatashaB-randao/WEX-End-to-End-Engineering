## 3. Casos de Teste BDD

### **Caso BDD 1: Busca de Produtos**

```gherkin
Feature: Busca de produtos no e-commerce
  Como um cliente do e-commerce
  Eu quero buscar produtos por nome
  Para que eu possa encontrar rapidamente o que desejo comprar

  Background:
    Given que estou na página inicial do e-commerce
    And existem produtos cadastrados no sistema

  Scenario: Busca por produto existente
    Given que estou na barra de busca
    When eu digito "smartphone Samsung"
    And clico no botão "Buscar"
    Then deve exibir uma lista de produtos relacionados
    And cada produto deve mostrar nome, preço e imagem
    And deve exibir a quantidade de resultados encontrados

  Scenario: Busca por produto inexistente
    Given que estou na barra de busca
    When eu digito "produto inexistente xyz"
    And clico no botão "Buscar"
    Then deve exibir mensagem "Nenhum produto encontrado"
    And deve sugerir produtos similares ou populares
    And deve manter a barra de busca visível para nova tentativa

  Scenario: Busca com termo vazio
    Given que estou na barra de busca
    When eu clico no botão "Buscar" sem digitar nada
    Then deve exibir mensagem "Digite um termo para buscar"
    And não deve executar a busca
    And deve manter o foco na barra de busca

  Scenario: Busca com filtros
    Given que estou na barra de busca
    When eu digito "notebook"
    And clico no botão "Buscar"
    And seleciono o filtro "Preço: R$ 1000 - R$ 2000"
    And seleciono o filtro "Marca: Dell"
    Then deve exibir apenas notebooks Dell na faixa de preço selecionada
    And deve mostrar os filtros aplicados
    And deve permitir remover filtros individualmente
```

### **Caso BDD 2: Finalização de Compra**

```gherkin
Feature: Finalização de compra no e-commerce
  Como um cliente do e-commerce
  Eu quero finalizar minha compra
  Para que eu possa receber os produtos em casa

  Background:
    Given que estou logado no sistema
    And tenho produtos no meu carrinho
    And tenho um endereço de entrega cadastrado

  Scenario: Finalização de compra com sucesso
    Given que estou na página do carrinho
    When clico em "Finalizar Compra"
    And confirmo o endereço de entrega
    And seleciono a forma de pagamento "Cartão de Crédito"
    And preencho os dados do cartão válido
    And clico em "Confirmar Pedido"
    Then deve exibir mensagem "Pedido realizado com sucesso"
    And deve exibir o número do pedido
    And deve enviar email de confirmação
    And deve limpar o carrinho

  Scenario: Finalização com cartão inválido
    Given que estou na página do carrinho
    When clico em "Finalizar Compra"
    And confirmo o endereço de entrega
    And seleciono a forma de pagamento "Cartão de Crédito"
    And preencho dados de cartão inválido
    And clico em "Confirmar Pedido"
    Then deve exibir mensagem "Dados do cartão inválidos"
    And deve manter os produtos no carrinho
    And deve permitir corrigir os dados do cartão
    And não deve gerar pedido

  Scenario: Finalização sem estoque
    Given que estou na página do carrinho
    And um produto do carrinho ficou sem estoque
    When clico em "Finalizar Compra"
    Then deve exibir mensagem "Produto sem estoque"
    And deve destacar o produto indisponível
    And deve sugerir produtos similares
    And deve permitir remover o produto do carrinho
    And não deve permitir finalizar até resolver o problema

  Scenario: Finalização com cupom de desconto
    Given que estou na página do carrinho
    And tenho um cupom de desconto válido "DESC10"
    When clico em "Finalizar Compra"
    And insiro o cupom "DESC10" no campo apropriado
    And clico em "Aplicar Cupom"
    Then deve aplicar o desconto no total
    And deve exibir o valor original e o valor com desconto
    And deve mostrar o cupom aplicado
    When clico em "Confirmar Pedido"
    Then deve finalizar a compra com o valor com desconto
```

### **Vantagens do BDD:**
- **Linguagem Natural:** Fácil entendimento por todos os stakeholders
- **Colaboração:** Product Owner, Desenvolvedor e Testador falam a mesma língua
- **Cobertura:** Garante que os cenários reais de uso sejam testados
- **Automação:** Pode ser automatizado com ferramentas como Cucumber
- **Documentação:** Serve como documentação viva do comportamento esperado