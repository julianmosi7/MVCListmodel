using System;
using System.Collections.Generic;

namespace ModelLib
{
    public class ValueModel
    {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;

        public Dictionary<string, int> dictionary;

        public ValueModel()
        {
            dictionary = new Dictionary<string, int>();
            dictionary.Add("Hansi", 1);
            dictionary.Add("Pauli", 2);
            dictionary.Add("Susi", 3);
            dictionary.Add("Franzi", 4);
            dictionary.Add("Liesi", 5);
            dictionary.Add("Heinzi", 6);
        }


        private double id;

        public double ID
        {
            get => id;
            set 
            {
                //value dictionary
                id = value;
                ValueChanged?.Invoke(this, new ValueChangedEventArgs { ID = id });
            }
        }

    }
}
