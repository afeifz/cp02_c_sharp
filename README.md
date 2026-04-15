# 💳 Sistema de Processamento de Pagamentos

## 📌 Descrição
Aplicação console desenvolvida em C# com o objetivo de simular um sistema de pagamentos, permitindo ao usuário escolher entre pagamento com cartão ou boleto.

O sistema coleta os dados necessários, processa a operação e exibe um resumo da transação.

---

## 🎯 Funcionalidades

- ✔ Menu interativo  
- ✔ Pagamento com Cartão  
- ✔ Pagamento com Boleto  
- ✔ Validação de dados  
- ✔ Tratamento de erros  
- ✔ Exibição de resumo do pagamento  

---

## 🧱 Estrutura do Projeto

AppPagamento  
│  
├── images  
│   ├── menu.png  
│   ├── pagamento-cartao.png  
│   ├── pagamento-boleto.png  
│   └── erro-validacao.png  
│  
├── Model  
│   ├── Pagamento.cs  
│   ├── PagamentoCartao.cs  
│   └── PagamentoBoleto.cs  
│  
├── Utils  
│   └── Menu.cs  
│  
├── Program.cs  
└── AppPagamento.csproj  

---

## 🛠️ Tecnologias Utilizadas

- C#  
- .NET 8  
- Aplicação Console  

---

## ▶️ Como Executar

1. Abrir o projeto no Visual Studio  
2. Compilar o projeto  
3. Executar (F5 ou Ctrl + F5)  
4. Escolher uma opção no menu  

---

## 📷 Evidências de Testes

### 🔹 Menu Principal

![Menu Principal](images/menu.png)

---

### 🔹 Pagamento com Cartão

**Entrada de dados:**
- Valor: 150,50  
- Número do cartão: 1234-5678-9012-3456  

**Saída esperada:**
Processando pagamento de R$ 150,50 via Cartão (Número: 1234-5678-9012-3456) na data XX/XX/XXXX.

📸 Print:  
![Pagamento Cartão](cp02/images/cartao.png)

---

### 🔹 Pagamento com Boleto

**Entrada de dados:**
- Valor: 200,00  
- Código de barras: 1111111122222223333333344444444  

**Saída esperada:**
Processando pagamento de R$ 200,00 via Boleto (Cod Barra: 1111111122222223333333344444444) na data XX/XX/XXXX.

📸 Print:  
![Pagamento Boleto](cp02/images/boleto.png)

---

### 🔹 Validação de Erros

**Exemplo: valor inválido**

📸 Print:  
![Erro de Validação](cp02/images/erro.png)

---

## 📚 Conceitos Aplicados

- Programação Orientada a Objetos (POO)  
- Encapsulamento  
- Herança  
- Polimorfismo  
- Tratamento de exceções  
- Validação de entrada de dados  

---

## 👨‍💻 Autor

Projeto desenvolvido para fins acadêmicos.