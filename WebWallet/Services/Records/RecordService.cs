﻿using AutoMapper;
using System.Collections;
using System.Linq;
using WebWallet.Data;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.Records;
using WebWallet.Data.Result;
using WebWallet.Models.Accounts;
using WebWallet.Models.Records;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Services.Records
{
    public class RecordService : IRecordService
    {
        private ApplicationDbContext context;
        private IMapper mapper;
        private IAccountService accountService;

        public RecordService(ApplicationDbContext context, IMapper mapper, IAccountService accountService)
        {
            this.context = context;
            this.mapper = mapper;
            this.accountService = accountService;
        }

        public Result<CreateRecordDTO> Create(CreateRecordDTO request)
        {
            Account? account = accountService.GetByID(request.AccountID);

            if (account == null)
                return new ErrorResult<CreateRecordDTO>(request, "Account not found");

            Record record = mapper.Map<Record>(request);

            if (record.RecordTypeID == 1)
                account.Amount -= record.Value;

            else if (record.RecordTypeID == 2)
                account.Amount += record.Value;

            context.Records.Add(record);
            context.SaveChanges();

            return new SuccessResult<CreateRecordDTO>(request);
        }

        public List<ReadRecordDTO> GetAll(string userID)
        {
            List<ReadRecordDTO> records = context.Accounts.Where(account => account.UserId == userID).Join(context.Records,
                account => account.AccountID, record => record.AccountID, (account, record) => new ReadRecordDTO
                {
                    RecordID = record.RecordID,
                    Value = record.Value,
                    Date = record.Date,
                    AccountID = record.AccountID,
                    RecordTypeID = record.RecordTypeID,
                    RecordSubcategoryID = record.RecordSubcategoryID
                }).OrderByDescending(record => record.Date).ToList();

            return records;
        }

        Record? GetByID(int id)
        {
            return context.Records.FirstOrDefault(r => r.RecordID == id);
        }

        public List<ReadRecordDTO> GetByAccount(int accountID)
        {
            return mapper.Map<List<ReadRecordDTO>>(context.Records.Where(r => r.AccountID == accountID).OrderByDescending(r => r.Date));
        }

        public Result<UpdateRecordDTO> Update(UpdateRecordDTO request)
        {
            Record? record = GetByID(request.RecordID);

            if (record == null) 
                return new ErrorResult<UpdateRecordDTO>(request, "Record not found");

            Account? oldAccount = accountService.GetByID(record.AccountID);
            Account? newAccount = accountService.GetByID(request.AccountID);

            if (oldAccount == null || newAccount == null)
                return new ErrorResult<UpdateRecordDTO>(request, "Account not found");

            if (record.RecordTypeID == 1)
            {
                if (request.RecordTypeID == 1)
                {
                    oldAccount.Amount += record.Value;
                    newAccount.Amount -= request.Value;
                }
                else if (request.RecordTypeID == 2)
                {
                    oldAccount.Amount += record.Value;
                    newAccount.Amount += request.Value;
                }
            }
            else if (record.RecordTypeID == 2)
            {
                if (request.RecordTypeID == 1)
                {
                    oldAccount.Amount -= record.Value;
                    newAccount.Amount -= request.Value;
                }
                else if (request.RecordTypeID == 2)
                {
                    oldAccount.Amount -= record.Value;
                    newAccount.Amount += request.Value;
                }
            }

            record.Value = request.Value;
            record.Date = request.Date;
            record.AccountID = request.AccountID;
            record.RecordTypeID = request.RecordTypeID;
            record.RecordSubcategoryID = request.RecordSubcategoryID;

            context.SaveChanges();

            return new SuccessResult<UpdateRecordDTO>(request);
        }

        public Result Delete(int id)
        {
            Record? record = GetByID(id);

            if (record == null)
                return new ErrorResult("Record not found");

            Account? account = accountService.GetByID(record.AccountID);

            if (account == null)
                return new ErrorResult("Account not found");

            if (record.RecordTypeID == 1)
                account.Amount += record.Value;
            else if (record.RecordTypeID == 2)
                account.Amount -= record.Value;

            context.Records.Remove(record);
            context.SaveChanges();

            return new SuccessResult();
        }
    }
}
