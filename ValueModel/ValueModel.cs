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

        private int id;

        public int ID
        {
            get => id;
            set 
            {
                id = value;
                if (id <= dictionary.Count && id > 0)
                {                    
                    ValueChanged?.Invoke(this, new ValueChangedEventArgs { ID = id });
                }                
            }
        }
    }
}
