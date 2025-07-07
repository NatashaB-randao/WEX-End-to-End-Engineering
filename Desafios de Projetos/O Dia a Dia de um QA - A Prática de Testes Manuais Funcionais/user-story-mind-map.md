## 2. Mind Map - User Story: Carrinho de Compras

### **User Story:**
*"Como um cliente do e-commerce, eu quero adicionar produtos ao meu carrinho de compras para que eu possa revisar meus itens antes de finalizar a compra."*

### **Mind Map Structure:**

```
                    📝 USER STORY: CARRINHO DE COMPRAS
                              |
                ┌─────────────┼─────────────┐
                │             │             │
            👤 ATOR       🎯 OBJETIVO    💰 VALOR
         (Cliente)    (Adicionar ao   (Revisar antes
                        Carrinho)      de comprar)
                              │
        ┌─────────────────────┼─────────────────────┐
        │                     │                     │
    📋 CRITÉRIOS          🧪 CENÁRIOS           🔧 REQUISITOS
    DE ACEITAÇÃO           DE TESTE             TÉCNICOS
        │                     │                     │
        │                     │                     │
    ┌───┴───┐             ┌───┴───┐             ┌───┴───┐
    │       │             │       │             │       │
 ✅ Deve    ✅ Deve       🟢 Pos.  🔴 Neg.      💾 BD    🌐 API
 adicionar  mostrar      Válido   Inválido      │       │
 produto    contador     │        │             │       │
    │          │         │        │             │       │
    │          │         │        │             │       │
 ✅ Deve    ✅ Deve      │        │          📊 Logs  🔒 Seg.
 calcular   permitir     │        │             │       │
 total      remover      │        │             │       │
    │          │         │        │             │       │
    │          │         │        │             │       │
 ✅ Deve    ✅ Deve      │        │          🎨 UX/UI 📱 Resp.
 persistir  atualizar    │        │             │       │
 sessão     quantidade   │        │             │       │
                         │        │             │       │
                         │        │             │       │
                    ┌────┴────┐   ┌────┴────┐   │       │
                    │         │   │         │   │       │
                 📦 Adicionar │   │ Produto │   │       │
                 produto      │   │ inexist.│   │       │
                 válido       │   │         │   │       │
                    │         │   │ Estoque │   │       │
                 📊 Visualizar│   │ zerado  │   │       │
                 carrinho     │   │         │   │       │
                    │         │   │ Sessão  │   │       │
                 🔄 Atualizar │   │ expirada│   │       │
                 quantidade   │   │         │   │       │
                    │         │   │ Limite  │   │       │
                 🗑️ Remover   │   │ excedido│   │       │
                 item         │   │         │   │       │
                    │         │   │         │   │       │
                 💰 Calcular  │   │         │   │       │
                 total        │   │         │   │       │
```

### **Detalhamento dos Elementos:**

#### **Critérios de Aceitação:**
- ✅ Sistema deve adicionar produto ao carrinho
- ✅ Sistema deve mostrar contador de itens
- ✅ Sistema deve calcular total automaticamente
- ✅ Sistema deve persistir carrinho na sessão
- ✅ Sistema deve permitir remover itens
- ✅ Sistema deve atualizar quantidade

#### **Cenários de Teste Identificados:**
**Positivos:**
- Adicionar produto válido
- Visualizar carrinho com produtos
- Atualizar quantidade de itens
- Remover item do carrinho
- Calcular total corretamente

**Negativos:**
- Produto inexistente
- Estoque zerado
- Sessão expirada
- Limite de itens excedido

#### **Requisitos Técnicos:**
- Banco de dados para persistência
- APIs para integração
- Logs para auditoria
- Segurança de sessão
- Interface responsiva
- Experiência do usuário

---

