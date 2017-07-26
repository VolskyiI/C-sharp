using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    //Завдання #5
    class ComplexSet <ComplexNumber> : IEnumerable
    {
        ArrayList complexset = new ArrayList();

        //Завдання #6
        public void SetObject(int index  , ComplexNumber obj1)
        {
            complexset.Insert(index, obj1);
        }
        public ComplexNumber GetObject(int index)
        {
            return (ComplexNumber) complexset[index];
        }


        

        public ComplexNumber this[int index]
        {
            get { return (ComplexNumber)complexset[index]; }

            set { complexset.Insert(index, value); }
        }
        
        public ComplexNumber this[string input]
       {
            get
                        {
                               foreach (var cn in complexset)
                                    {
                                        if (cn.ToString() == input)
                                            {
                        int index = complexset.IndexOf(cn);
                                                return (ComplexNumber)complexset[index];
                                           }
                                    }
                return default(ComplexNumber);
            }
            
                    }
        public IEnumerator GetEnumerator()
        {
            return complexset.GetEnumerator();
        }
    }
}

