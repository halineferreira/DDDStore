using System;
using DDDStore.Domain.Entities;

namespace DDDStore.Domain.Interfaces.Services.Team
{
    public interface IMaintenanceService
    {
        void ChangeAddress(Address newAddress);
        void VerifyCategory(int customerId);
        void ChangeEmail(int customerId, int age, string newEmail);
    }
}
