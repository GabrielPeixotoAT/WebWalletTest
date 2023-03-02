﻿using AutoMapper;
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
            Record record = mapper.Map<Record>(request);

            Account? account = accountService.GetByID(record.AccountID);

            if (account == null)
                return new ErrorResult<CreateRecordDTO>(request, "Account not found");


            if (record.RecordTypeId == 1)
                account.Amount -= record.Value;

            else if (record.RecordTypeId == 2)
                account.Amount += record.Value;

            context.Records.Add(record);
            context.SaveChanges();

            return new SuccessResult<CreateRecordDTO>(request);
        }

        public List<ReadRecordDTO> GetAll(string userID)
        {
            List<ReadAccountDTO> accounts = mapper.Map<List<ReadAccountDTO>>(context.Accounts.Where(account => account.UserId == userID).ToList());

            List<ReadRecordDTO> readRecord = mapper.Map<List<ReadRecordDTO>>(context.Records.ToList());

            List<ReadRecordDTO> readRecordFiltered = new List<ReadRecordDTO>();

            foreach (ReadAccountDTO account in accounts)
            {
                readRecord.FindAll(r => r.AccountID == account.AccountID).ForEach(any => readRecordFiltered.Add(any));
            }

            return readRecordFiltered.OrderByDescending(record => record.Date).ToList();
        }
    }
}
