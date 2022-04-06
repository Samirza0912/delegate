using System;

namespace delegate_.Exceptions
{
    public class AlreadyExistsException:Exception
    {
        public AlreadyExistsException(string text):base(text)
        {

        }
    }
}
