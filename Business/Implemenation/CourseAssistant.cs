using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.HttpResponse;
using Core.Dto;
using Core.Entity;
using Repository.Interfacies;
namespace Business.Implemenation
{
            public class CourseAssistant : ICourseAssistant
            {
                        private readonly IMangerRepo _mangerRepo;
                        private readonly IMapper _mapper;

                        public CourseAssistant(IMangerRepo mangerRepo,
                                                IMapper mapper)
                        {
                            _mangerRepo=mangerRepo;
                            _mapper=mapper;
                        }
                        public async Task<HttpResponse<int>> addAsyncInstructor(AddInstructorDto instructorDto)
                        {
                                    var Instructor=_mapper.Map<Instructor>(instructorDto);
                                    await _mangerRepo.InstructorRepo.AddAsync(Instructor);
                                    await _mangerRepo.saveAsync();
                                    return new HttpResponse<int>(){Status=true, Data=1};
                        }
                        public HttpResponse<int> addInstructor(AddInstructorDto instructorDto)
                        {
                                   var Instructor=_mapper.Map<Instructor>(instructorDto);
                                     _mangerRepo.InstructorRepo.Add(Instructor);
                                     _mangerRepo.save();
                                     return new HttpResponse<int>(){Status=true, Data=1};
                        }
                         public async Task<HttpResponse<List<InstructorDto>>> GetInstructor(string InstructorName)
                        {
                                   var instructor=await _mangerRepo.InstructorRepo.GetInstructors(InstructorName);
                                   var instructorDto=_mapper.Map<List<InstructorDto>>(instructor);
                                   return new HttpResponse<List<InstructorDto>>(){Data=instructorDto};
                        }
                        public async Task<HttpResponse<InstructorDto>> GetInstructor(Guid InstructorId)
                        {
                                   var instructor=await _mangerRepo.InstructorRepo.GetInstructorId(InstructorId);
                                   var instructorDto=_mapper.Map<InstructorDto>(instructor);
                                   return new HttpResponse<InstructorDto>(){Status=true, Data=instructorDto};
                        }
                        public async Task<HttpResponse<List<InstructorDto>>> GetInstructor()
                        {
                                var instructor=await _mangerRepo.InstructorRepo.GetInstructors();
                                var instructorDto=_mapper.Map<List<InstructorDto>>(instructor);
                                return new HttpResponse<List<InstructorDto>>(){Status=true, Data=instructorDto};
                        }
                         public HttpResponse<int> addModule(AddModuleDto moduleDto)
                        {
                                    var module=_mapper.Map<Module>(moduleDto);
                                     _mangerRepo.ModuleRepo.Add(module);
                                     _mangerRepo.save();
                                     return new HttpResponse<int>(){Status=true, Data=1};
                        }
                        public async Task<HttpResponse<int>> addAsyncModule(AddModuleDto moduleDto)
                        {
                                     var module=_mapper.Map<Module>(moduleDto);
                                     await _mangerRepo.ModuleRepo.AddAsync(module);
                                     await _mangerRepo.saveAsync();
                                     return new HttpResponse<int>(){Status=true,Data=1};
                        }
                        public async Task<HttpResponse<List<ModuleDto>>> GetModule(string moduleName)
                        {
                                var modules=await _mangerRepo.ModuleRepo.GetModules(moduleName);
                                var moduleDto=_mapper.Map<List<ModuleDto>>(modules);
                                return new HttpResponse<List<ModuleDto>>(){Status=true,Data=moduleDto};
                        }
                        public async Task<HttpResponse<ModuleDto>> GetModule(Guid moduleId)
                        {
                                var modules=await _mangerRepo.ModuleRepo.GetModuleId(moduleId);
                                var moduleDto=_mapper.Map<ModuleDto>(modules);
                                return new HttpResponse<ModuleDto>(){Status=true,Data=moduleDto};
                        }
                        public async Task<HttpResponse<List<ModuleDto>>> GetModule()
                        {
                                var modules=await _mangerRepo.ModuleRepo.GetModules();
                                var moduleDto=_mapper.Map<List<ModuleDto>>(modules);
                                return new HttpResponse<List<ModuleDto>>(){Status=true,Data=moduleDto};
                        }
                        public HttpResponse<int> addSkill(AddSkillDto skillDto)
                        {
                                    var skill=_mapper.Map<Skill>(skillDto);
                                      _mangerRepo.SkillRepo.Add(skill);
                                      _mangerRepo.save();
                                     return new HttpResponse<int>(){Status=true,Data=1};
                        }
                        public async Task<HttpResponse<int>> addAsyncSkill(AddSkillDto skillDto)
                        {
                                    var skill=_mapper.Map<Skill>(skillDto);
                                     await _mangerRepo.SkillRepo.AddAsync(skill);
                                     await _mangerRepo.saveAsync();
                                     return new HttpResponse<int>(){Status=true,Data=1};
                        }
                        public async Task<HttpResponse<List<SkillDto>>> GetSkill(string skillName)
                        {
                                var skills=await _mangerRepo.SkillRepo.GetSkills(skillName);
                                var skillDtos=_mapper.Map<List<SkillDto>>(skills);
                                return new HttpResponse<List<SkillDto>>(){Status=true,Data=skillDtos};
                        }
                        public async Task<HttpResponse<SkillDto>> GetSkill(Guid skillId)
                        {
                                var skills=await _mangerRepo.SkillRepo.GetSkillId(skillId);
                                var skillDtos=_mapper.Map<SkillDto>(skills);
                                return new HttpResponse<SkillDto>(){Status=true,Data=skillDtos};
                        }
                        public async Task<HttpResponse<List<SkillDto>>> GetSkill()
                        {
                                    var skills=await _mangerRepo.SkillRepo.GetSkills();
                                var skillDtos=_mapper.Map<List<SkillDto>>(skills);
                                return new HttpResponse<List<SkillDto>>(){Status=true,Data=skillDtos};
                        }
            }
}