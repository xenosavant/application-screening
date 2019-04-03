using ApplicationScreening.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate
{
    public class Answer: ValueObject<Answer>
    {
        public string Value { get; private set; }

        public Answer(string value)
        {
            Value = value;
        }

        public override bool Equals(Answer other)
        {
            return string.Compare(this.Value.ToLower(), other.Value.ToLower()) == 0;
        }

        public override int GetHashCode(Answer other)
        {
            return Value.GetHashCode();
        }
    }
}
