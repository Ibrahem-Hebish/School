﻿namespace SchoolProject.Core.Mapping.StudentMapping;

public partial class StudentMapping
{
    public void GetStudentMapping()
    {
        CreateMap<Student, GetStudentDto>()
         .ForMember(std => std.DepName, opt => opt.MapFrom(s => s.Department.Name))
         .ForMember(std => std.Subjects, opt => opt.MapFrom(s => s.Subjects.Select(s => s.Name)))
         .ReverseMap()
         .ForMember(s => s.Id, opt => opt.Ignore())
         .ForMember(s => s.Subjects, opt => opt.Ignore())
         .ForMember(s => s.Studentsubjects, opt => opt.Ignore())
         .ForMember(s => s.DepId, opt => opt.Ignore());
    }

}
