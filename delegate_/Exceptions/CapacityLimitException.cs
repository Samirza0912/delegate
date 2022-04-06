using System;
namespace delegate_.Exceptions
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException(string text) : base(text)
        {

        }
    }
}
