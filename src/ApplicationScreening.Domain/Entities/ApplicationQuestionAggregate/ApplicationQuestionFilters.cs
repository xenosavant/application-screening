using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate.ApplicationQuestionFilters
{
    public class QuestionsWithIds : IFilter<ApplicationQuestion>
    {
        private readonly List<Guid> _ids;

        public QuestionsWithIds(List<Guid> ids)
        {
            _ids = ids;
        }

        public Expression<Func<ApplicationQuestion, bool>> Criteria => q => _ids.Contains(q.Id);
    }
}
