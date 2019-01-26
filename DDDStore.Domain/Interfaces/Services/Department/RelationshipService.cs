using DDDStore.Domain.Interfaces.Repositories;

namespace DDDStore.Domain.Interfaces.Services.Department
{
    public class RelationshipService : IRelationshipService
    {
        readonly ICustomerRepository _customerRepository;

        public RelationshipService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void SendBirthdayCommunication(int customerId, string message)
        {
            var customer = _customerRepository.GetById(customerId);
        }

        public void SendDowngradeCommunication(int customerId, string message)
        {
            var customer = _customerRepository.GetById(customerId);
        }

        public void ToggleAutoCommunication(int customerId)
        {
            var customer = _customerRepository.GetById(customerId);
            customer.IsCommunicationEnabled = !customer.IsCommunicationEnabled;
            _customerRepository.Update(customer);
        }
    }
}
