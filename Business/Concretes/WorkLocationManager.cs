using AutoMapper;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.WorkLocation;
using HotelProject.Business.Responses.WorkLocation;
using HotelProject.Entities.Concrete;


namespace Business.Concretes
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WorkLocationManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddWorkLocationResponse Add(AddWorkLocationRequest request)
        {
            var workLocationToAdd = _mapper.Map<WorkLocation>(request);
            WorkLocation addedWorkLocation = _unitOfWork.WorkLocationDal.Add(workLocationToAdd);
            var response = _mapper.Map<AddWorkLocationResponse>(addedWorkLocation);
            _unitOfWork.Save();
            return response;
        }

        public DeleteWorkLocationResponse Delete(DeleteWorkLocationRequest request)
        {
            WorkLocation? workLocationToDeleted = _unitOfWork.WorkLocationDal.Get(predicate:wl=>wl.Id == request.Id);
            WorkLocation deletedWorkLocation = _unitOfWork.WorkLocationDal.Delete(workLocationToDeleted!);
            var response = _mapper.Map<DeleteWorkLocationResponse>(deletedWorkLocation);
            _unitOfWork.Save();
            return response;
        }

        public GetWorkLocationListResponse Get(GetWorkLocationRequest request)
        {
            IList<WorkLocation> workLocations = _unitOfWork.WorkLocationDal.GetList();
            GetWorkLocationListResponse response = _mapper.Map<GetWorkLocationListResponse>(workLocations);
            return response;
        }

        public UpdateWorkLocationResponse Update(UpdateWorkLocationRequest request)
        {
            WorkLocation? WorkLocationToUpdate = _unitOfWork.WorkLocationDal.Get(predicate: a => a.Id == request.Id);
            WorkLocationToUpdate = _mapper.Map(request, WorkLocationToUpdate);
            WorkLocation updatedWorkLocation = _unitOfWork.WorkLocationDal.Update(WorkLocationToUpdate!);
            var response = _mapper.Map<UpdateWorkLocationResponse>(updatedWorkLocation);
            _unitOfWork.Save();
            return response;
        }
    }
}
