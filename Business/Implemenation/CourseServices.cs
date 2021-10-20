using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.HttpResponse;
using Business.Interfacies;
using Core.Dto;
using Repository.Interfacies;
using AutoMapper;
using Core.Entity.Course;

namespace Business.Implemenation
{
            public class CourseServices : ICourseServices
            {
                        private readonly IMangerRepo _mangerRepo;
                        private readonly IMapper _mapper;

                        public CourseServices(IMangerRepo mangerRepo,IMapper mapper)
                {
                    _mangerRepo=mangerRepo;
                    _mapper=mapper;
                }
                        public async Task<HttpResponse<int>> addAsyncCourse(AddCourseDto courseDto)
                        {
                                    var course=_mapper.Map<Course>(courseDto);
                                     await _mangerRepo.CourseRepo.AddAsync(course); 
                                     await _mangerRepo.saveAsync();
                                     return new HttpResponse<int>(){Data=1};
                        }

                        public HttpResponse<int> addCourse(AddCourseDto courseDto)
                        {
                                    var course=_mapper.Map<Course>(courseDto);
                                      _mangerRepo.CourseRepo.Add(course); 
                                      _mangerRepo.save();
                                     return new HttpResponse<int>(){Data=1};
                        }

                        public async Task<HttpResponse<CourseDto>> GetCourseById(Guid Course)
                        {
                            try
                            {
                                  var course =await _mangerRepo.CourseRepo.GetCourse(Course); 
                                  var courseDto=_mapper.Map<CourseDto>(course);
                                  return new HttpResponse<CourseDto>(){Data=courseDto};  
                                 
                            }
                            catch (System.Exception ex)
                            {
                                
                               return new HttpResponse<CourseDto>(){Status=false,Message =ex.Message};  
                            }
                        }

                        public async Task<HttpResponse<List<CourseDto>>> GetCourses(string Course)
                        {
                                var courses=await _mangerRepo.CourseRepo.GetCoursespres(courseName:Course);
                                var courseDto=_mapper.Map<List<CourseDto>>(courses);
                                return new HttpResponse<List<CourseDto>>(){Status=true,Data=courseDto}; 
                        }

                        public async Task<HttpResponse<List<CourseDto>>> GetCourses()
                        {
                                    var courses=await _mangerRepo.CourseRepo.GetCourses();
                                var courseDto=_mapper.Map<List<CourseDto>>(courses);
                                return new HttpResponse<List<CourseDto>>(){Status=true,Data=courseDto};
                        }
            }
}