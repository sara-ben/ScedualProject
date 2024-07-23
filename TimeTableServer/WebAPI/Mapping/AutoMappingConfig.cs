using AutoMapper;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;
using ViewModel.ModelsDto;

namespace WebApi.Mapping
{
    public class AutoMappingConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapping());
            });
        }
    }
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Absences, AbsencesDto>();
            CreateMap<AbsencesDto, Absences>();

            CreateMap<Constrains, ConstrainsDto>();
            CreateMap<ConstrainsDto, Constrains>();

            CreateMap<Cycle, CycleDto>();
            CreateMap<CycleDto, Cycle>();

            CreateMap<Day, DayDto>();
            CreateMap<DayDto, Day>();

            CreateMap<DraftTable, AbsencesDto>();
            CreateMap<DraftTableDto, DraftTable>();

            CreateMap<Grade, GradeDto>();
            CreateMap<GradeDto, Grade>();

            CreateMap<Hour, HourDto>();
            CreateMap<HourDto, Hour>();

            CreateMap<Lesson, LessonDto>();
            CreateMap<LessonDto, Lesson>();

            CreateMap<ResultTbl, ResultDto>();
            CreateMap<ResultDto, ResultTbl>();

            CreateMap<Subject, SubjectDto>();
            CreateMap<SubjectDto, Subject>();

            CreateMap<SubjectForCycle, SubjectForCycleDto>();
            CreateMap<SubjectForCycleDto, SubjectForCycle>();

            CreateMap<Teacher, TeacherDto>();
            CreateMap<TeacherDto, Teacher>();

            CreateMap<TeacherLessons, TeacherLessonsDto>();
            CreateMap<TeacherLessonsDto, TeacherLessons>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
          
        }
    }
}

