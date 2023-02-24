using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWallet.Data.Result
{
    public abstract class Result
    {
        public string? Message;
        public bool Success;
        public bool HasError;
    }

    public abstract class Result<TResult>
    {
        public string? Message;
        public bool Success;
        public bool HasError;

        public TResult ResultObject { get; set; }
    }
}