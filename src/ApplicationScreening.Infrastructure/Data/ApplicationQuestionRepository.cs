using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApplicationScreening.Infrastructure.Data
{
    public class ApplicationQuestionRepository : IApplicationQuestionRepository
    {
        protected readonly AppDbContext _context;

        public ApplicationQuestionRepository(AppDbContext context)
        {
           _context = context;
        }

        public async Task<ApplicationQuestion> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ApplicationQuestion>> GetList(List<IFilter<ApplicationQuestion>> filters = null)
        {
            IQueryable<ApplicationQuestion> query = _context.Set<ApplicationQuestion>();

            if (filters != null)
            {
                foreach (var filter in filters)
                {
                    query = query.Where(filter.Criteria);
                }
            }
            return await query.ToListAsync();
        }

        public void Create(ApplicationQuestion entity)
        {
            _context.Set<ApplicationQuestion>().Add(entity);
        }

        public void Update(ApplicationQuestion entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ApplicationQuestion application)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
