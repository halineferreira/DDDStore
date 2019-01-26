using System;
using DDDStore.Domain.Entities;

namespace DDDStore.Domain.Interfaces.Services.Department
{
    public interface IMaintenanceService
    {
        void ChangeAddress(Address newAddress);
        void ChangePhone(Phone newPhone);
        void ChangeEmail(int customerId, DateTime dateOfBirth, string newEmail);
        void ValidateAge(int customerId, int age);
        void VerifyCategory(int customerId);

    }
}
