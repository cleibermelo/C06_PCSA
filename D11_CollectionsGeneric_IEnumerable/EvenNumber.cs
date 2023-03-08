using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_CollectionsGeneric_IEnumerable
{
    internal class EvenNumber
    {

        #region Method do tipo IList<T>
        public IList<int> CreateEvenNumbersList(int quantity)
        {
            List<int> evenNumbersList = new List<int>(quantity);

            int currentNumber = 0;

            while (evenNumbersList.Count <= quantity)
            {
                if(++currentNumber % 2 == 0)
                {
                    evenNumbersList.Add(currentNumber);
                }
            }

            return evenNumbersList;
        }


        #endregion

        #region Method do tipo IEnumerable<T>

        public IEnumerable<int> CreateEvenNumbersIEnumerable(int quantity)
        {
            int currentNumber = 0;

            while (++currentNumber <= quantity)
            {
                if (currentNumber % 2 == 0)
                {
                    yield return currentNumber;
                }
            }            
        }

        #endregion
    }
}
