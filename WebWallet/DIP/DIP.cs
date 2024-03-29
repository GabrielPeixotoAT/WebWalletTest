﻿using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Accounts;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Auth;
using WebWallet.Services.Records.Interfaces;
using WebWallet.Services.Records;
using WebWallet.Services.Cards.Interfaces;
using WebWallet.Services.Cards;

namespace WebWallet.DIP
{
    public class DIP
    {
        public DIP(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            services.AddTransient<IAccountTypeService, AccountTypeService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IRecordService, RecordService>();
            services.AddTransient<IRecordCategoryService, RecordCategoryService>();
            services.AddTransient<IRecordSubcategoryService, RecordSubcategoryService>();
            services.AddTransient<IRecordTypeService, RecordTypeService>();

            services.AddTransient<IBankService, BankService>();
            services.AddTransient<ICardService, CardService>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IInvoiceStatusService, InvoiceStatusService>();
        }
    }
}
