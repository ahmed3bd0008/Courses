using System.Threading.Tasks;
using Business.HttpResponse;
using Core.Dto;
using System.Collections.Generic;
using System;

namespace Repository.Interfacies
{
    public interface ICourseAssistant
    {
        HttpResponse<int> addInstructor(AddInstructorDto instructorDto);
        Task <HttpResponse<int>> addAsyncInstructor(AddInstructorDto instructorDto);

        Task< HttpResponse<List<InstructorDto>>>GetInstructor(string InstructorName);
        Task< HttpResponse<InstructorDto>>GetInstructor(Guid InstructorId);

        Task< HttpResponse<List<InstructorDto>>>GetInstructor();
        HttpResponse<int> addModule(AddModuleDto moduleDto);
        Task <HttpResponse<int>> addAsyncModule(AddModuleDto moduleDto);
        Task< HttpResponse<List<ModuleDto>>>GetModule(string moduleName);
        Task< HttpResponse<ModuleDto>>GetModule(Guid moduleId);
        Task< HttpResponse<List<ModuleDto>>>GetModule();

         HttpResponse<int> addSkill(AddSkillDto skillDto);
        Task <HttpResponse<int>> addAsyncSkill(AddSkillDto skillDto);

        Task< HttpResponse<List<SkillDto>>>GetSkill(string skillName);
        Task< HttpResponse<SkillDto>>GetSkill(Guid skillId);

        Task< HttpResponse<List<SkillDto>>>GetSkill();
         HttpResponse<int> addSCourseTrack(AddSkillDto CourseTrackDto);
        Task <HttpResponse<int>> addAsyncCourseTrack(AddSkillDto CourseTrackDto);

        Task< HttpResponse<List<SkillDto>>>GetCourseTrack(string CourseTrackName);
        Task< HttpResponse<SkillDto>>GetCourseTrack(Guid CourseTrackId);

        Task< HttpResponse<List<SkillDto>>>GetCourseTrack();

    }
}