﻿using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.JobApplicationAggregate
{
    interface IJobApplicationRepository : IRepository<JobApplication>
    {

    }
}