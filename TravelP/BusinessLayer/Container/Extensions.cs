﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.UowConcrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
      

        public static void ContainerDependencies(this IServiceCollection services)
        {
            
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EFCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EFDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EFAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IResevationDal, EFReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EFGuideDal>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EFContactUsDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EFAnnouncementDal>();

            services.AddScoped<IAppAccountService, AppAccountManager>();
            services.AddScoped<IAccountDal,EFAppAccountDal>();

            services.AddScoped<IUowDal, UowDal>();

        }
        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTOs>, AnnouncementValidator>();

        }
    }
}
