﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WenhaoLu_Assign1.Controllers
{
    public class question1Controller : ApiController
    {
        [HttpGet]
        public int AddTen(int id)
        {
            return 10 + id;
        }




    }
}
