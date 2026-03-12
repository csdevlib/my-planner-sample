namespace MyPlanner.Plannings.Domain
{
    public class ReleaseDate : ValueObject<DateTime>
    {
        private ReleaseDate(DateTime value) : base(value)
        {
        }

        public static ReleaseDate Create(DateTime value)
        {
            if (value == default)
            {
                throw new ArgumentException("Release date cannot be the default value.", nameof(value));
            }
            return new ReleaseDate(value);
        }

        public static ReleaseDate From(DateTime date) => new ReleaseDate(date);

        public static ReleaseDate Default()
        {           
            return new ReleaseDate(DateTime.Now);
        }

        public override string ToString() => Value.ToString("yyyy-MM-dd");

        public string ToUtcString() => Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
