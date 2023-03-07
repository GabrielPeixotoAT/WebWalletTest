using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Records;
using WebWallet.Data.Result;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Controllers
{
    public class RecordController : Controller
    {
        private IRecordService recordService;

        public RecordController(IRecordService recordService)
        {
            this.recordService = recordService;
        }

        public IActionResult Create(CreateRecordDTO request)
        {
            Result<CreateRecordDTO> result = recordService.Create(request);

            if (result.HasError)
                return StatusCode(500);

            return Redirect("/");
        }

        public IActionResult Delete(int id)
        {
            Result result = recordService.Delete(id);

            if (result.HasError)
                return StatusCode(500);

            return Redirect("/");
        }
    }
}
