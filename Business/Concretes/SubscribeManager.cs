using AutoMapper;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Subscribe;
using HotelProject.Business.Responses.Subscribe;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SubscribeManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddSubscribeResponse Add(AddSubscribeRequest request)
        {
            var subscribeToAdd = _mapper.Map<Subscribe>(request);
            Subscribe addedSubscribe = _unitOfWork.SubscribeDal.Add(subscribeToAdd);
            var response = _mapper.Map<AddSubscribeResponse>(addedSubscribe);
            _unitOfWork.Save();
            return response;
        }

        public DeleteSubscribeResponse Delete(DeleteSubscribeRequest request)
        {
            Subscribe? subscribeToDelete = _unitOfWork.SubscribeDal.Get(predicate:s=>s.Id == request.Id);
            Subscribe deletedSubscribe = _unitOfWork.SubscribeDal.Delete(subscribeToDelete!);
            var response = _mapper.Map<DeleteSubscribeResponse>(deletedSubscribe);
            _unitOfWork.Save();
            return response;
        }

        public GetSubscribeListResponse GetList(GetSubscribeListRequest request)
        {
            IList<Subscribe> subscribes = _unitOfWork.SubscribeDal.GetList();
            GetSubscribeListResponse response = _mapper.Map<GetSubscribeListResponse>(subscribes);
            return response;
        }

        public UpdateSubscribeResponse Update(UpdateSubscribeRequest request)
        {
            Subscribe? subscribeToUpdate = _unitOfWork.SubscribeDal.Get(predicate: s => s.Id == request.Id);
            subscribeToUpdate = _mapper.Map(request, subscribeToUpdate);
            Subscribe updatedSubscribe = _unitOfWork.SubscribeDal.Update(subscribeToUpdate!);
            var response = _mapper.Map<UpdateSubscribeResponse>(updatedSubscribe);
            _unitOfWork.Save();
            return response;
        }
    }
}
