﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer.Container;

//namespace BusinessLayer.Container
//{
//    public static class -
//    {
//        public static void ContainerDependencies(IServiceCollection services)
//        {
            
//            services.AddScoped<ICommentService, CommentManager>();
//            services.AddScoped<ICommentDal, EFCommentDal>();

//            services.AddScoped<IDestinationService, DestinationManager>();
//            services.AddScoped<IDestinationDal, EFDestinationDal>();

//            services.AddScoped<IAppUserService, AppUserManager>();
//            services.AddScoped<IAppUserDal, EFAppUserDal>();

//            services.AddScoped<IReservationService, ReservationManager>();
//            services.AddScoped<IResevationDal,EFReservationDal>();

//            services.AddScoped<IGuideService, GuideManager>();
//            services.AddScoped<IGuideDal, EFGuideDal>();

//            services.AddScoped<IExcelService, ExcelManager>();
//            services.AddScoped<IPdfService,PdfManager>();

//            services.AddScoped<IContactUsService, ContactUsManager>();
//            services.AddScoped<IContactUsDal,EFContactUsDal>();

//           services.AddScoped<IAnnouncementService,AnnouncementManager>();
//            services.AddScoped<IAnnouncementDal, EFAnnouncementDal>();



//        }
//        public static void CustomerValidator(this IServiceCollection services)
//        {
//            services.AddTransient<IValidator<AnnouncementAddDTOs>, AnnouncementValidator>();

//        }
//    }
//}
