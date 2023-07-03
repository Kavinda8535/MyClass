using Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Services
{
    public class AssignmentService : IAssignmentService
    {
        public IEnumerable<char> PickFiveRandomStringValues(string value)
        {
            const int numberOfCharactersToPick = 5;

            // Create a random number generator
            Random random = new Random();

            // Create a char array to store the picked characters
            char[] pickedCharacters = new char[numberOfCharactersToPick];

            // Pick random characters from the input string
            for (int i = 0; i < numberOfCharactersToPick; i++)
            {
                // Generate a random index within the range of the input string
                int randomIndex = random.Next(0, value.Length);

                // Pick the character at the random index
                pickedCharacters[i] = value[randomIndex];
            }

            return pickedCharacters;
        }
    }
}
