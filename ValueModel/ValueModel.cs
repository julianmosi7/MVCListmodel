using System;
using System.Collections.Generic;

namespace ModelLib
{
    public class ValueModel
    {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;

        private double val;


        public double Val
        {
            get { return val; }
            set 
            {
                var dictionary = new Dictionary<string, int>();
                dictionary.Add("Hansi", 1);
                dictionary.Add("Pauli", 2);
                dictionary.Add("Susi", 3);
                dictionary.Add("Franzi", 4);
                dictionary.Add("Liesi", 5);
                dictionary.Add("Heinzi", 6);
                foreach (var item in dictionary)
                {
                    
                }
                val = value;
                ValueChanged?.Invoke(this, new ValueChangedEventArgs { Val = val });
            }
        }

    }
}
