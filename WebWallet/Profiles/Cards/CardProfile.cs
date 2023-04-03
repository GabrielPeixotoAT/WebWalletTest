using AutoMapper;
using WebWallet.Data.DTO.Card;
using WebWallet.Models.Cards;

namespace WebWallet.Profiles.Cards
{
    public class CardProfile : Profile
    {
        public CardProfile() 
        {
            CreateMap<CreateCardDTO, Card>();
            CreateMap<UpdateCardDTO, Card>();
            CreateMap<Card, ReadCardDTO>();
        }
    }
}
