using System;
using DDDStore.Domain.Entities;
using DDDStore.Domain.Interfaces.Repositories;

namespace DDDStore.Domain.Interfaces.Services.Team
{
    public class MaintenanceService : IMaintenanceService
    {
        readonly IAddressRepository _addressRepository;
        readonly ICustomerRepository _customerRepository;
        readonly ICategoryRepository _categoryRepository;

        public MaintenanceService(IAddressRepository addressRepository,
             ICustomerRepository customerRepository,
             ICategoryRepository categoryRepository)
        {
            _addressRepository = addressRepository;
            _customerRepository = customerRepository;
            _categoryRepository = categoryRepository;
        }

        public void ChangeAddress(Address newAddress)
        {
            //buscar no repositorio do Address e alterar endereço pelo ID
            var currentAddress =  _addressRepository.GetById(newAddress.AddressId);
            currentAddress.ChangeAddress(newAddress);
            _addressRepository.Update(currentAddress);
        }

        public void ChangeEmail(int customerId, int age, string newEmail)
        {
            var customer = _customerRepository.GetById(customerId);

            var today = DateTime.Today;
            var birthdate = customer.DateOfBirth;
            var customerAge = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-customerAge)) customerAge--;

            if (customerAge != age)
                throw new Exception($"Age is not valid for customer: {customerId}");

            customer.Email = newEmail;
            _customerRepository.Update(customer);

        }

        public void VerifyCategory(int customerId)
        {
            var customer = _customerRepository.GetById(customerId);
            var categories = _categoryRepository.GetAll();
            //atualizar pontos
        }
    }
}
