using System;
using System.Collections;
using System.Collections.Generic;

namespace PayrollSystem {

    public class PaymentCollection<T> where T : IPayment {
        private T[] payments;
        private int numElements;
        private const int DEFAULTSIZE = 5;

        public PaymentCollection () {
            payments = new T[DEFAULTSIZE];
            numElements = 0;
        }

        public PaymentCollection (int size) {
            payments = new T[size];
            numElements = 0;
        }

        public void Add(T item)
        {
            if (numElements < payments.Length)
            {
                payments[ numElements ] = item;
                numElements++;
            } else
            {
                throw new System.Exception("Payment Collection is full!");
            }
        }

        public T Remove()
        {
            if (numElements != 0)
            {
                T item = payments[--numElements];
                return item;
            }
            throw new System.Exception("Payment collection is empty!");
        }

        public T GetEnumerator()
        {
            foreach (T item in payments)
            {
                yield return item;
            }
        }

        // public T[] GetAllPayments()
        // {
        //     if (numElements > 0)
        //     {
        //         return payments;
        //     } 
        //     throw new System.Exception("Payment collection is empty!");
        // }


    }
}