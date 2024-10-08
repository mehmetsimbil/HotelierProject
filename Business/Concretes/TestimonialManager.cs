using AutoMapper;
using Business.Requests.Testimonial;
using Business.Responses.Testimonial;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Testimonial;
using HotelProject.Business.Responses.Testimonial;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TestimonialManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddTestimonialResponse Add(AddTestimonialRequest request)
        {
            var testimonialToAdd = _mapper.Map<Testimonial>(request);
            Testimonial addedTestimonial = _unitOfWork.TestimonialDal.Add(testimonialToAdd);
            var response = _mapper.Map<AddTestimonialResponse>(addedTestimonial);
            _unitOfWork.Save();
            return response;
        }

        public DeleteTestimonialResponse Delete(DeleteTestimonialRequest request)
        {
            Testimonial? testimonialToDelete = _unitOfWork.TestimonialDal.Get(predicate:t=>t.Id == request.Id);
            if (testimonialToDelete == null)
            {
                throw new KeyNotFoundException($"No About found with ID {request.Id}");
            }


            testimonialToDelete.IsDeleted = true;
            Testimonial deletedTestimonial = _unitOfWork.TestimonialDal.Delete(testimonialToDelete!);
            var response = _mapper.Map<DeleteTestimonialResponse>(deletedTestimonial);
            _unitOfWork.Save();
            return response;
        }

        public GetTestimonialByIdResponse GetById(GetTestimonialByIdRequest request)
        {
            Testimonial? testimonial = _unitOfWork.TestimonialDal.Get(predicate:  t=>t.Id == request.Id);
            var response = _mapper.Map<GetTestimonialByIdResponse>(testimonial);
            return response;
        }

        public GetTestimonialListResponse GetList(GetTestimonialListRequest request)
        {
            IList<Testimonial> testimonials = _unitOfWork.TestimonialDal.GetList();
            GetTestimonialListResponse response = _mapper.Map<GetTestimonialListResponse>(testimonials);
            return response;
        }

        public UpdateTestimonialResponse Update(UpdateTestimonialRequest request)
        {
            Testimonial? testimonialToUpdate = _unitOfWork.TestimonialDal.Get(predicate: t => t.Id == request.Id);
            testimonialToUpdate = _mapper.Map(request, testimonialToUpdate);
            Testimonial updatedTestimonial = _unitOfWork.TestimonialDal.Update(testimonialToUpdate!);
            var response = _mapper.Map<UpdateTestimonialResponse>(updatedTestimonial);
            _unitOfWork.Save();
            return response;
        }
    }
}
