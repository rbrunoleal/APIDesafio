﻿using System;

namespace APIDesafio.Domain.Entity
{
    public class UserToken
    {
        public string Token { get; set; }
        public string Created { get; set; }
        public string Expiration { get; set; }        
        public bool Authenticated { get; set; }
        public string Message { get; set; }
    }
}
