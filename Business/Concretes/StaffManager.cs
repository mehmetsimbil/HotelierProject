using AutoMapper;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Staff;
using HotelProject.Business.Responses.Staff;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class StaffManager : IStaffService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StaffManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddStaffResponse Add(AddStaffRequest request)
        {
            var staffToAdd = _mapper.Map<Staff>(request);
            Staff addedToStaff = _unitOfWork.StaffDal.Add(staffToAdd);
            var response = _mapper.Map<AddStaffResponse>(addedToStaff);
            _unitOfWork.Save();
            return response;
        }

        public DeleteStaffResponse Delete(DeleteStaffRequest request)
        {
            Staff? staffToDelete = _unitOfWork.StaffDal.Get(predicate:  s=> s.Id == request.Id);
            Staff deletedStaff = _unitOfWork.StaffDal.Delete(staffToDelete!);
            var response = _mapper.Map<DeleteStaffResponse>(deletedStaff);
            _unitOfWork.Save();
            return response;
        }

        public GetStaffListResponse GetList(GetStaffListRequest request)
        {
            IList<Staff> staffs = _unitOfWork.StaffDal.GetList();
            GetStaffListResponse response = _mapper.Map<GetStaffListResponse>(staffs);
            return response;
        }

        public UpdateStaffResponse Update(UpdateStaffRequest request)
        {
            Staff? staffToUpdate = _unitOfWork.StaffDal.Get(predicate: g => g.Id == request.Id);
            staffToUpdate = _mapper.Map(request, staffToUpdate);
            Staff updatedStaff = _unitOfWork.StaffDal.Update(staffToUpdate!);
            var response = _mapper.Map<UpdateStaffResponse>(updatedStaff);
            _unitOfWork.Save();
            return response;
        }
    }
}
