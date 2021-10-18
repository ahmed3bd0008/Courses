using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.HttpResponse;
using Business.Interfacies;
using Core.Dto;
using Core.Entity.Course;
using Repository.Interfacies;

namespace Business.Implemenation
{
            public class SystemServiceCourse : ISystemServiceCourse
            {
                        private readonly IMangerRepo _mangerRepo;
                        private readonly IMapper _mapper;

                        public SystemServiceCourse(IMangerRepo mangerRepo,IMapper mapper)
                        {
                            _mangerRepo=mangerRepo;
                            _mapper=mapper;
                        }

                        public async Task<HttpResponse<int>> addAsyncCourseLevel(AddCourseLevelDto courseLevelDto)
                        {
                                    var courseLevel=_mapper.Map<CourseLevel>(courseLevelDto);
                                   await _mangerRepo.CourseLevelRepo.AddAsync(courseLevel);
                                   await _mangerRepo.saveAsync();
                                   return new HttpResponse<int>(){Data=1};
                        }

                        public HttpResponse<int> addCourseLevel(AddCourseLevelDto courseLevelDto)
                        {
                                   var courseLevel=_mapper.Map<CourseLevel>(courseLevelDto);
                                    _mangerRepo.CourseLevelRepo.Add(courseLevel);
                                    _mangerRepo.save();
                                   return new HttpResponse<int>(){Data=1};
                        }

                        public Task<HttpResponse<CourseLevelDto>> GetCourseLevel(string courseLevel)
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<HttpResponse<CourseLevelDto>> GetCourseLevel(Guid courseLevel)
                        {
                                    throw new NotImplementedException();
                        }

                        public async Task<HttpResponse<List<CourseLevelDto>>> GetCourseLevel()
                        {
                                  var courseLevel=await _mangerRepo.CourseLevelRepo.GetCourseLevel();
                                  var courseLevelDto=_mapper.Map<List<CourseLevelDto>>(courseLevel);
                                  return new HttpResponse<List<CourseLevelDto>>(){Data=courseLevelDto};
                        }
            }
            
}