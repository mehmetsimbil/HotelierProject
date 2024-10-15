using AutoMapper;
using Business.Requests.About;
using Business.Responses.About;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.About;
using HotelProject.Business.Responses.About;
using HotelProject.Entities.Concrete;


namespace HotelProject.Business.Concretes
{
    public class AboutManager : IAboutService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AboutManager(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddAboutResponse Add(AddAboutRequest request)
        {
            var aboutToAdd = _mapper.Map<About>(request);
            About addedAbout = _unitOfWork.AboutDal.Add(aboutToAdd);
            var response = _mapper.Map<AddAboutResponse>(addedAbout);
            _unitOfWork.Save();
            return response;
            
        }

        public DeleteAboutResponse Delete(DeleteAboutRequest request)
        {
            About? aboutToDelete = _unitOfWork.AboutDal.Get(predicate: a => a.Id == request.Id);

            if (aboutToDelete == null)
            {
                throw new KeyNotFoundException($"No About found with ID {request.Id}");
            }

            
            aboutToDelete.IsDeleted = true;

           
            About updatedAbout = _unitOfWork.AboutDal.Update(aboutToDelete);
            var response = _mapper.Map<DeleteAboutResponse>(updatedAbout);
            _unitOfWork.Save();

            return response;
        }


        public GetAboutByIdResponse GetById(GetAboutByIdRequest request)
        {
           About? about = _unitOfWork.AboutDal.Get(predicate:a=> a.Id == request.Id);
            var response = _mapper.Map<GetAboutByIdResponse>(about);
            return response;    
        }

        public GetAboutListResponse GetList(GetAboutListRequest request)
        {
            IList<About> abouts = _unitOfWork.AboutDal.GetList(predicate:a=>a.IsDeleted==false);
            GetAboutListResponse response = _mapper.Map<GetAboutListResponse>(abouts);
            return response;
        }

        public UpdateAboutResponse Update(UpdateAboutRequest request)
        {
            About? aboutToUpdate = _unitOfWork.AboutDal.Get(predicate: a=> a.Id == request.Id);
            aboutToUpdate= _mapper.Map(request,aboutToUpdate);
            About updatedAbout = _unitOfWork.AboutDal.Update(aboutToUpdate!);
            var response = _mapper.Map<UpdateAboutResponse>(updatedAbout);
            _unitOfWork.Save();
            return response;

        }

       
    }
}
