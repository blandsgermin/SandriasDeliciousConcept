using System;
using System.Data;
using SandriasDeliciousConcept.Data;

namespace SandriasDeliciousConcept.Delivery
{
    public class DeliveryService
    {
        private readonly DeliveryRepository _repository;

        public DeliveryService()
        {
            _repository = new DeliveryRepository();
        }

        public DataTable GetAllDeliveries()
        {
            return _repository.GetAll();
        }

        public DataTable GetDeliveryById(int deliveryId)
        {
            return _repository.GetById(deliveryId);
        }

        public int ScheduleDelivery(
            string deliveryNumber,
            int rfId,
            int assignedUserId,
            string? vehicle,
            DateTime scheduledDate,
            string? deliveryAddress,
            string? remarks,
            int? createdBy)
        {
            return _repository.Add(
                deliveryNumber,
                rfId,
                assignedUserId,
                vehicle,
                scheduledDate,
                deliveryAddress,
                remarks,
                createdBy);
        }

        public void UpdateDelivery(
            int deliveryId,
            int assignedUserId,
            string? vehicle,
            DateTime scheduledDate,
            string? deliveryAddress,
            string? remarks)
        {
            _repository.Update(
                deliveryId,
                assignedUserId,
                vehicle,
                scheduledDate,
                deliveryAddress,
                remarks);
        }

        public void UpdateDeliveryStatus(
            int deliveryId,
            string newStatus,
            int? changedBy,
            string? remarks)
        {
            _repository.SetStatus(
                deliveryId,
                newStatus,
                changedBy,
                remarks);
        }

        public DataTable SearchDeliveries(string search)
        {
            return _repository.Search(search);
        }

        public DataTable GetApprovedRequests()
        {
            return _repository.GetApprovedRequests();
        }

        public DataTable GetDeliveryPersonnel()
        {
            return _repository.GetPersonnel();
        }

        public DataTable GetDeliveryHistory(int deliveryId)
        {
            return _repository.GetHistory(deliveryId);
        }
    }
}
