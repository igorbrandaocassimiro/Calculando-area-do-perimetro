# 📘 Trabalhando com Formatação de Números em C#

Este repositório contém uma atividade prática em **C#** para demonstrar como **formatar valores numéricos** para melhorar a apresentação dos resultados.

---

## 📌 Descrição
Nesta atividade:
- Utilizamos o valor `3.14159` para representar **PI**.
- Aplicamos `.ToString("F2")` para exibir o número **com duas casas decimais**.
- Essa formatação facilita a leitura e interpretação dos valores, tornando o programa **mais amigável para o usuário**.

---

## 🧠 Exemplo prático
```csharp
double pi = 3.14159;
Console.WriteLine(pi.ToString("F2")); // Saída: 3.14
