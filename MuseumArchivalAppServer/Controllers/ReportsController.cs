﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Reporting.Services.AspNetCore;
using Telerik.Reporting.Services;

namespace MuseumArchivalAppServer.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ReportsControllerBase
    {
        public ReportsController(IReportServiceConfiguration reportServiceConfiguration) 
            : base(reportServiceConfiguration)
        {
                
        }
    }
}
