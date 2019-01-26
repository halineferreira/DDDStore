using System.Collections.Generic;
using DDDStore.Domain.Entities;

namespace DDDStore.Domain.Interfaces.Services.Department
{
    public interface ISalesService
    {
        /*
         * - Precisa ter acesso a todo o histórico de vendas, não apenas a última.
         * - Precisa saber para cada venda, qual endereço utilizar. (O cliente pode cadastrar quantos endereços quiser).
         * - Precisa ter acesso ao mês de aniversário para incluir desconto especial.
         * - Precisa ter acesso ao nível do programa de fidelidade para incluir o desconto, e aplicar os pontos. (cada $1 equivale a 1 ponto).
        */

        IEnumerable<Order> LoadSalesHistory(int customerId);
        void IncludeSpecialDiscount(int customerId, int orderId, int discount);
        void AddPointsToCustomer(int customerId, int points);
    }
}
