namespace UnitTestExample
{
    internal class Mock<T>
    {
        private object strict;

        public Mock(object strict)
        {
            this.strict = strict;
        }
    }
}