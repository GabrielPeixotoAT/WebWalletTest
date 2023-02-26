using System.Security.Claims;
using WebWallet.Services.Auth.Interfaces;

namespace WebWallet.Services.Auth
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId()
        {
            return httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
