namespace MyPlanner.Shared.Domain.ValueObjects
{
    public class Version : ValueObject<string>
    {
        private Version(string value) : base(value)
        {
        }

        public static Version Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
            return new Version(value);
        }

        public override void AddValidators()
        {
            base.AddValidators();
        }

        public static Version Default()
        {
            return new Version("0.0.0");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
