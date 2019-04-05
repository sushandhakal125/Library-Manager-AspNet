using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using LibraryApp.Authorization.Roles;
using LibraryApp.Authorization.Users;
using LibraryApp.Authors.DTO;
using LibraryApp.Books.DTO;
using LibraryApp.Categories.DTO;
using LibraryApp.Models;
using LibraryApp.Roles.Dto;
using LibraryApp.Users.Dto;

namespace LibraryApp
{
    [DependsOn(typeof(LibraryAppCoreModule), typeof(AbpAutoMapperModule))]
    public class LibraryAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                // Role and permission
                #region Authors
                mapper.CreateMap<CreateAuthorInput, Author>().ReverseMap();
                mapper.CreateMap<Author, GetAuthorOutput>().ReverseMap();
                mapper.CreateMap<UpdateAuthorInput, Author>().ReverseMap();
                mapper.CreateMap<Author, GetAuthorOutput>().ReverseMap();
                #endregion
                #region Books
                mapper.CreateMap<CreateBookInput, Book>().ReverseMap();
                mapper.CreateMap<Book, GetBookOutput>().ReverseMap();
                mapper.CreateMap<UpdateBookInput, Book>().ReverseMap();
                mapper.CreateMap<Book, GetBookOutput>().ReverseMap();
                #endregion
                #region Categories
                mapper.CreateMap<CreateCategoryInput, Category>().ReverseMap();
                mapper.CreateMap<Category, GetCategoryOutput>().ReverseMap();
                mapper.CreateMap<UpdateCategoryInput, Category>().ReverseMap();
                mapper.CreateMap<Category, GetCategoryOutput>().ReverseMap();
                #endregion
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }
    }
}
