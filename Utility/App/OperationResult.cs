﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.App
{
    public class OperationResult
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }
        public OperationResult()
        {
            IsSucceeded = true;
        }
        public OperationResult Succeeded(string message = "عملیات با موفقیت انجام شد")
        {
            IsSucceeded = true;
            Message = message;
            return this;
        }
        public OperationResult Failed(string message)
        {
            IsSucceeded = false;
            Message = message;
            return this;
        }

    }
}