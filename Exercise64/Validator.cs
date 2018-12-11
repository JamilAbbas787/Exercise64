namespace Exercise64
{
    public class Validator
    {

        public bool IsInt(string userInput)
        {
            if (int.TryParse(userInput, out int numberValid) )
            {
                return true;
            }

            return false;
        }

    }
}
