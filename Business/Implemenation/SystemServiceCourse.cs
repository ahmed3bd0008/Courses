using System;
using System.Collections.Generic;
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
                                   return new HttpResponse<int>(){Status=true, Data=1};
                        }
                        public HttpResponse<int> addCourseLevel(AddCourseLevelDto courseLevelDto)
                        {
                                   var courseLevel=_mapper.Map<CourseLevel>(courseLevelDto);
                                    _mangerRepo.CourseLevelRepo.Add(courseLevel);
                                    _mangerRepo.save();
                                   return new HttpResponse<int>(){Status=true,Data=1};
                        }
                         public async Task<HttpResponse<CourseLevelDto>> GetCourseLevel(Guid courseLevelname)
                        {
                                    var courseLevel=await _mangerRepo.CourseLevelRepo.GetCourseLevelById(courseLevelname);
                                  var courseLevelDto=_mapper.Map<CourseLevelDto>(courseLevel);
                                  return new HttpResponse<CourseLevelDto>(){Status=true,Data=courseLevelDto};
                        }
                          public async Task<HttpResponse<List<CourseLevelDto>>> GetCourseLevel(string courseLevelname)
                        {
                                  var courseLevel=await _mangerRepo.CourseLevelRepo.GetCourseLevel(courseLevelname);
                                  var courseLevelDto=_mapper.Map<List<CourseLevelDto>>(courseLevel);
                                  return new HttpResponse<List<CourseLevelDto>>(){Status=true,Data=courseLevelDto};
                        }

                        public async Task<HttpResponse<List<CourseLevelDto>>> GetCourseLevel()
                        {
                                  var courseLevel=await _mangerRepo.CourseLevelRepo.GetCourseLevel();
                                  var courseLevelDto=_mapper.Map<List<CourseLevelDto>>(courseLevel);
                                  return new HttpResponse<List<CourseLevelDto>>(){Status=true,Data=courseLevelDto};
                        }
                       //AddCourse Status
                         public HttpResponse<int> addCourseStatus(AddCourseStatusDto courseStatusDto)
                        {
                                    var courseStatus=_mapper.Map<CourseStatus>(courseStatusDto);
                                    _mangerRepo.CourseStatuseRepo.Add(courseStatus);
                                    _mangerRepo.save();
                                    return new HttpResponse<int>(){Status=true,Data=1};

                        }
                          public async Task<HttpResponse<int>> addAsyncCourseStatus(AddCourseStatusDto courseStatusDto)
                        {
                                    var courseStatus=_mapper.Map<CourseStatus>(courseStatusDto);
                                   await _mangerRepo.CourseStatuseRepo.AddAsync(courseStatus);
                                   await _mangerRepo.saveAsync();
                                   return new HttpResponse<int>(){Status=true,Data=1};
                        }
                         public async Task<HttpResponse<CourseStatusDto>> GetCourseStatus(Guid coursecoursStatud)
                        {
                                    var courseStatus=await _mangerRepo.CourseStatuseRepo.GetCourseStatusId(coursecoursStatud);
                                    var courseSatatusDto=_mapper.Map<CourseStatusDto>(courseStatus);
                                    return new HttpResponse<CourseStatusDto>(){Status=true,Data=courseSatatusDto};
                        }
                        public async Task<HttpResponse<List<CourseStatusDto>>> GetCourseStatus()
                        {
                                    var courseStatus=await _mangerRepo.CourseStatuseRepo.GetCourseStatus();
                                    var courseSatatusDto=_mapper.Map<List<CourseStatusDto>>(courseStatus);
                                    return new HttpResponse<List<CourseStatusDto>>(){Status=true,Data=courseSatatusDto};
                        }
                        public async Task<HttpResponse<List<CourseStatusDto>>> GetCourseStatus(string coursStatud)
                        {
                                    var courseStatus=await _mangerRepo.CourseStatuseRepo.GetCourseStatus(coursStatud);
                                    var courseSatatusDto=_mapper.Map<List<CourseStatusDto>>(courseStatus);
                                    return new HttpResponse<List<CourseStatusDto>>(){Status=true,Data=courseSatatusDto};
                        }
                        ////Course TYpe
                        public HttpResponse<int> addCourseType(AddCourseTypeDto courseTypeDto)
                        {
                                    var courseType=_mapper.Map<CourseType>(courseTypeDto);
                                    _mangerRepo.CourseTypeRepo.Add(courseType);
                                    _mangerRepo.save();
                                    return new HttpResponse<int>(){Status=true,Data=1};
                        }
                        public async Task<HttpResponse<int>> addAsyncCourseType(AddCourseTypeDto courseTypeDto)
                        {
                                    var courseType=_mapper.Map<CourseType>(courseTypeDto);
                                     await _mangerRepo.CourseTypeRepo.AddAsync(courseType);
                                     await _mangerRepo.saveAsync();
                                     return new HttpResponse<int>(){Status=true,Data=1};
                        }
                        public async Task<HttpResponse<List<CourseTypeDto>>> GetCourseType()
                        {
                                    var courseTypeDb=await _mangerRepo.CourseTypeRepo.GetCourseType();
                                    var courseTypeDto=_mapper.Map<List<CourseTypeDto>>(courseTypeDb);
                                    return new HttpResponse<List<CourseTypeDto>>(){Status=true,Data=courseTypeDto};
                        }
                         public async Task<HttpResponse<List<CourseTypeDto>>> GetCourseType(string courseType)
                        {
                                    var courseTypeDb=await _mangerRepo.CourseTypeRepo.GetCourseType(courseType);
                                    var courseTypeDto=_mapper.Map<List<CourseTypeDto>>(courseTypeDb);
                                    return new HttpResponse<List<CourseTypeDto>>(){Status=true,Data=courseTypeDto};
                        }
                        public async Task<HttpResponse<CourseTypeDto>> GetCourseType(Guid courseType)
                        {
                                    var courseTypeDb=await _mangerRepo.CourseTypeRepo.GetCourseTypeId(courseType);
                                    var courseTypeDto=_mapper.Map<CourseTypeDto>(courseTypeDb);
                                    return new HttpResponse<CourseTypeDto>(){Status=true,Data=courseTypeDto};
                        }

                        public HttpResponse<int> addCourseCategory(AddCourseCategoryDto categoryDto)
                        {
                                    var categoryDb=_mapper.Map<CourseCategory>(categoryDto);
                                    _mangerRepo.CourseCategoryRepo.Add(categoryDb);
                                    _mangerRepo.save();
                                    return new HttpResponse<int>(){Data=1};
                        }

                        public async Task<HttpResponse<int>> addAsyncCourseCategory(AddCourseCategoryDto courseCategoryDto)
                        {
                                    var categoryDb=_mapper.Map<CourseCategory>(courseCategoryDto);
                                    await _mangerRepo.CourseCategoryRepo.AddAsync(categoryDb);
                                    await _mangerRepo.saveAsync();
                                    return new HttpResponse<int>(){Data=1};
                        }

                        public async Task<HttpResponse<List<CourseCategoryDto>>> GetCourseCategory(string courseCategory)
                        {
                                    var courseCategoryDb=await _mangerRepo.CourseCategoryRepo.GetCategory(courseCategory);
                                    var courseCategoryDto=_mapper.Map<List<CourseCategoryDto>>(courseCategoryDb);
                                    return new HttpResponse<List<CourseCategoryDto>>(){Data=courseCategoryDto};

                        }

                        public async Task<HttpResponse<CourseCategoryDto>> GetCourseCategory(Guid courseCategoryId)
                        {
                                    var courseCategoryDb=await _mangerRepo.CourseCategoryRepo.GetCategoryId(courseCategoryId);
                                    var courseCategoryDto=_mapper.Map<CourseCategoryDto>(courseCategoryDb);
                                    return new HttpResponse<CourseCategoryDto>(){Data=courseCategoryDto};
                        }

                        public async Task<HttpResponse<List<CourseCategoryDto>>> GetCourseCategory()
                        {
                                   var courseCategoryDb=await _mangerRepo.CourseCategoryRepo.GetCategory();
                                    var courseCategoryDto=_mapper.Map<List<CourseCategoryDto>>(courseCategoryDb);
                                    return new HttpResponse<List<CourseCategoryDto>>(){Data=courseCategoryDto};
                        }
            }
            
}