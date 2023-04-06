using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.Bank;
using WebWallet.Data.Result;
using WebWallet.Models.Cards;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Services.Cards
{
    public class BankService : IBankService
    {
        ApplicationDbContext context;
        IMapper mapper;

        public BankService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Result<CreateBankDTO> Create(CreateBankDTO createBankDTO)
        {
            if (createBankDTO == null)
                return new ErrorResult<CreateBankDTO>(createBankDTO, "Invalid Bank");

            Bank? readBank = ReadByName(createBankDTO.Name, createBankDTO.UserID);
            if (readBank != null)
                return new ErrorResult<CreateBankDTO>(createBankDTO, "This bank is already registered");

            context.Banks.Add(mapper.Map<Bank>(createBankDTO));
            context.SaveChanges();

            return new SuccessResult<CreateBankDTO>(createBankDTO);
        }

        public List<ReadBankDTO> GetAll(string userID)
        {
            return mapper.Map<List<ReadBankDTO>>(context.Banks.Where(bank => bank.UserID == userID));
        }

        public Result<UpdateBankDTO> Update(UpdateBankDTO updateBankDTO)
        {
            if (updateBankDTO == null)
                return new ErrorResult<UpdateBankDTO>(updateBankDTO, "Invalid Bank");

            Bank? readBank = GetByID(updateBankDTO.BankID, updateBankDTO.UserID);

            if (readBank == null)
                return new ErrorResult<UpdateBankDTO>(updateBankDTO, "Bank not found");

            readBank.Code = updateBankDTO.Code;
            readBank.Name = updateBankDTO.Name;

            context.SaveChanges();

            return new SuccessResult<UpdateBankDTO>(updateBankDTO);
        }

        public Result Delete(int id, string userID)
        {
            Bank? readBank = GetByID(id, userID);

            if (readBank == null)
                return new ErrorResult("Bank not found");

            context.Banks.Remove(readBank);
            context.SaveChanges();

            return new SuccessResult();
        }

        public Bank? GetByID(int id, string userID)
        {
            return context.Banks.Where(bank => bank.UserID == userID)
                .Where(bank => bank.BankID == id).FirstOrDefault();
        }

        public ReadBankDTO ReadByID(int id, string userID)
        {
            return mapper.Map<ReadBankDTO>(GetByID(id, userID));
        }

        Bank? ReadByName(string name, string userID)
        {
            return context.Banks.Where(bank => bank.UserID == userID)
                .Where(bank => bank.Name == name).FirstOrDefault();
        }
    }
}
