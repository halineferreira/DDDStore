using System;
using System.Linq;
using DDDStore.Domain.Entities;
using DDDStore.Domain.Interfaces.Repositories;

namespace DDDStore.Domain.Interfaces.Services.Department
{
    public class MaintenanceService : IMaintenanceService
    {
        readonly IAddressRepository _addressRepository;
        readonly IPhoneRepository _phoneRepository;
        readonly ICustomerRepository _customerRepository;
        readonly ICategoryRepository _categoryRepository;


        public MaintenanceService(IAddressRepository addressRepository,
             IPhoneRepository phoneRepository,
             ICustomerRepository customerRepository,
             ICategoryRepository categoryRepository)
        {
            _addressRepository = addressRepository;
            _phoneRepository = phoneRepository;
            _customerRepository = customerRepository;
            _categoryRepository = categoryRepository;
        }

        public void ChangeAddress(Address newAddress)
        {
            var currentAddress =  _addressRepository.GetById(newAddress.AddressId);
            currentAddress.ChangeAddress(newAddress);
            _addressRepository.Update(currentAddress);
        }

        public void ChangePhone(Phone newPhone)
        {
            var currentPhone = _phoneRepository.GetById(newPhone.PhoneId);
            currentPhone.ChangePhone(newPhone);
            _phoneRepository.Update(currentPhone);
        }

        public void ChangeEmail(int customerId, DateTime dateOfBirth, string newEmail)
        {
            var customer = _customerRepository.GetById(customerId);

            if (dateOfBirth != customer.DateOfBirth)
                throw new Exception($"DateOfBirth is not valid for {customer.FirstName} {customer.LastName}");

            customer.Email = newEmail;
            _customerRepository.Update(customer);

        }

        public void VerifyCategory(int customerId)
        {
            var customer = _customerRepository.GetById(customerId);
            var categories = (_categoryRepository.GetAll()).OrderBy(c => c.Points).ToList();

            foreach (var category in categories)
            {
                if (customer.Points >= category.Points && customer.Category != category)
                {
                    customer.Category = category;
                }
            }
            _customerRepository.Update(customer);
        }

        public void ValidateAge(int customerId, int age)
        {
            var customer = _customerRepository.GetById(customerId);

            var today = DateTime.Today;
            var birthdate = customer.DateOfBirth;
            var customerAge = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-customerAge)) customerAge--;

            if (customerAge != age)
                throw new Exception($"Age is not valid for {customer.FirstName} {customer.LastName}");
        }
    }
}
