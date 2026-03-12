using BeyondNet.Ddd.Rules;
using BeyondNet.Ddd.Rules.Impl;
using MyPlanner.Shared.Helpers;

namespace MyPlanner.Shared.Domain.ValueObjects.Validators
{
    public class VersionValidator : AbstractRuleValidator<ValueObject<string>>
    {
        public VersionValidator(ValueObject<string> subject) : base(subject)
        {
        }
        public override void AddRules(RuleContext context)
        {
            var value = Subject!.GetValue();
            if (string.IsNullOrWhiteSpace(value))
            {
                AddBrokenRule("Version", "Version is required");
            }
            if (!string.IsNullOrWhiteSpace(value) && !VersionHelper.IsValidVersion(value))
            {
                AddBrokenRule("Version", "Version is invalid");
            }
        }
    }
}
