using AutoMapper;
using Business.Requests.Service;
using Business.Responses.Service;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Service;
using HotelProject.Business.Responses.Service;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class ServiceManager : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddServiceResponse Add(AddServiceRequest request)
        {
            var serviceToAdd = _mapper.Map<Service>(request);
            Service addedToService = _unitOfWork.ServiceDal.Add(serviceToAdd);
            var response = _mapper.Map<AddServiceResponse>(addedToService);
            _unitOfWork.Save();
            return response;
        }

        public DeleteServiceResponse Delete(DeleteServiceRequest request)
        {
            Service? serviceToDelete = _unitOfWork.ServiceDal.Get(predicate:s=>s.Id == request.Id);
            Service deletedService = _unitOfWork.ServiceDal.Delete(serviceToDelete!);
            var response = _mapper.Map<DeleteServiceResponse>(deletedService);
            _unitOfWork.Save();
            return response;
        }

        public GetServiceByIdResponse GetById(GetServiceByIdRequest request)
        {
            Service? service = _unitOfWork.ServiceDal.Get(predicate:s=>s.Id==request.Id);
            var response = _mapper.Map<GetServiceByIdResponse>(service);
            return response;
        }

        public GetServiceListResponse GetList(GetServiceListRequest request)
        {
            IList<Service> services = _unitOfWork.ServiceDal.GetList();
            GetServiceListResponse response = _mapper.Map<GetServiceListResponse>(services);
            return response;
        }

        public UpdateServiceResponse Update(UpdateServiceRequest request)
        {
            Service? serviceToUpdate = _unitOfWork.ServiceDal.Get(predicate: g => g.Id == request.Id);
            serviceToUpdate = _mapper.Map(request, serviceToUpdate);
            Service updatedService = _unitOfWork.ServiceDal.Update(serviceToUpdate!);
            var response = _mapper.Map<UpdateServiceResponse>(updatedService);
            _unitOfWork.Save();
            return response;
        }
    }
}
