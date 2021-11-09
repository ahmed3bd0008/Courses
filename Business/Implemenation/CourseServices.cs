using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.HttpResponse;
using Business.Interfacies;
using Core.Dto;
using Repository.Interfacies;
using AutoMapper;
using Core.Entity.Course;
using Microsoft.AspNetCore.Http;
using System.IO;

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
                                    var photo=ConvertImgToByte(courseDto.CoursePho);
                                    course.CoursePhoto=photo;
                                     await _mangerRepo.CourseRepo.AddAsync(course); 
                                     await _mangerRepo.saveAsync();
                                     return new HttpResponse<int>(){Data=1};
                        }

                        public HttpResponse<int> addCourse(AddCourseDto courseDto)
                        {

                                    var course=_mapper.Map<Course>(courseDto);
                                    var photo=ConvertImgToByte(courseDto.CoursePho);
                                    course.CoursePhoto=photo;
                                      _mangerRepo.CourseRepo.Add(course); 
                                      _mangerRepo.save();
                                     return new HttpResponse<int>(){Status=true, Data=1};
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
                        private byte[] ConvertImgToByte(IFormFile file)
                        {
                                    using (var ms = new MemoryStream())
                                    {
                                    file.CopyTo(ms);
                                    var fileBytes = ms.ToArray();
                                    string s = Convert.ToBase64String(fileBytes);
                                    // act on the Base64 data
                                    return fileBytes;    
                                    }   
                        }
            }
}
