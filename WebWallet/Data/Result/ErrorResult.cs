using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWallet.Data.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(string? message = null)
        {
            this.Message = message;
            this.Success = false;
            this.HasError = true;
        }
    }

    public class ErrorResult<TResult> : Result<TResult>
    {
        public ErrorResult(TResult resultObject, string? message = null)
        {
            this.Message = message;
            this.Success = false;
            this.HasError = true;

            this.ResultObject = resultObject;
        }
    }
}