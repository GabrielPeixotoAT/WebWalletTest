using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWallet.Data.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(string? message = null)
        {
            this.Message = message;
            this.Success = true;
            this.HasError = false;
        }
    }

    public class SuccessResult<TResult> : Result<TResult>
    {
        public SuccessResult(TResult resultObject, string? message = null)
        {
            this.Message = message;
            this.Success = true;
            this.HasError = false;

            this.ResultObject = resultObject;
        }
    }
}