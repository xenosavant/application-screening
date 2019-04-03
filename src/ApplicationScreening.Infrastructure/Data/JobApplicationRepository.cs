using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApplicationScreening.Infrastructure.Data
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        protected readonly AppDbContext _context;

        public JobApplicationRepository(AppDbContext context)
        {
           _context = context;
        }

        public async Task<JobApplication> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobApplication>> GetList(List<IFilter<JobApplication>> filters = null)
        {
            throw new NotImplementedException();
        }

        public void Create(JobApplication entity)
        {
            _context.Set<JobApplication>().Add(entity);
        }

        public void Update(JobApplication entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(JobApplication application)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
