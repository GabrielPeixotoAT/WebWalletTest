﻿using WebWallet.Data.DTO.Records;
using WebWallet.Data.Result;

namespace WebWallet.Services.Records.Interfaces
{
    public interface IRecordService
    {
        Result<CreateRecordDTO> Create(CreateRecordDTO request);
        List<ReadRecordDTO> GetAll(string userId);
        List<ReadRecordDTO> GetByAccount(int accountID);
        Result<UpdateRecordDTO> Update(UpdateRecordDTO request);
        Result Delete(int id);
    }
}