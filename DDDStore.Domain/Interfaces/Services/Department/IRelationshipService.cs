namespace DDDStore.Domain.Interfaces.Services.Department
{
    public interface IRelationshipService
    {
        /*
         * - Deve-se conhecer a preferencia do cliente pelo título a ser usado. OK
         * - Deve-se utilizar sempre o último nome para comunicações oficiais. OK
         * - Deve-se ter ao menos 2 opções válidas de endereços e telefones, e uma opção de email. OK
         * - As opções para programa de fidelidade são: SILVER, GOLD, PLATINUM. OK
         * - Deve-se enviar comunicações especiais durante todo o mês de aniversário.
         * - Deve-se ter opção para desativar comunicações automáticas.
         * - Após 3 meses da última compra, um aviso de diminuição de categoria deve ser enviado, mesmo com notificação desligada.
         */

        void SendBirthdayCommunication(int customerId, string message);
        void SendDowngradeCommunication(int customerId, string message);
        void ToggleAutoCommunication(int customerId);
    }
}
