using ApplicationScreening.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.QuestionAggregate
{
    public class Answer: ValueObject
    {
        public string Value { get; private set; }

        public Answer(string value)
        {
            Value = value;
        }

        public override bool Equals(ValueObject other)
        {
            return string.Compare(this.Value.ToLower(), (other as Answer).Value.ToLower()) == 0;
        }

        public override int GetHashCode(ValueObject other)
        {
            return Value.GetHashCode();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
