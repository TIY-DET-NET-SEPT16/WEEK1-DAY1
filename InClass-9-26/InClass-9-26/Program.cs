using System;

namespace InClass_9_26
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Hello World");
            //Console.WriteLine();
            //Console.WriteLine("Hello World");

            //            bool learningBools = true;
            ////            learningBools = 5;
            //            Console.WriteLine(learningBools);

            //            int myInteger = 5;
            //            //myInteger = -54864651;
            //            //myInteger = 5.2;
            //            Console.WriteLine(myInteger);

            //            double myDouble = 5.2;
            //            double newDouble = 5.3;
            //            myDouble = 5;
            //            Console.WriteLine(myDouble);

            //            string myString = "Any set of character on the keyboard and some not on the keyboardn_)(*&^%$#09876543";
            //            string stringOne = "Some Text";
            //            string stringTwo = "some text";
            //            string anotherString = "5";
            //            Console.WriteLine(myString);

            //            DateTime myDateTime = DateTime.UtcNow;
            //            Console.WriteLine(myDateTime);

            //            Console.WriteLine(myDateTime);
            //            Console.WriteLine(myDateTime);
            //            Console.WriteLine(myDateTime);

            //            int myNewInt = 5;
            //            double myNewDouble = 5.2;

            //            myNewInt = Convert.ToInt32(Math.Round(myNewDouble));

            //            int moreInts = 5;
            //            int moreInts1 = 5;
            //            double moreDoubles = 5.2;

            //            moreDoubles = moreInts;

            //            string newString = moreDoubles.ToString();
            //            Console.WriteLine(moreDoubles);
            //            Console.WriteLine(moreDoubles.GetType());

            //            string one = "The start of my sentence ";
            //            string two = "the end of it";

            //            Console.WriteLine(one + two);
            //            Console.WriteLine(moreInts + moreInts1);

            //            int someName;
            //            var newVariable = 5;
            //            Console.WriteLine(newVariable.GetType());

            //            var newVariable1 = 5.4;
            //            Console.WriteLine(newVariable1.GetType());

            //int[] firstArray = new int[] { 10, 12, 14 };
            //Console.WriteLine(firstArray[1]);

            //int[] myIntArray = new int[6];

            //myIntArray[0] = -5;

            //for(int i = 0; i < myIntArray.Length; i++)
            //{
            //    myIntArray[i] = i + 10;
            //}

            //for (int c = 0; c < myIntArray.Length; c++)
            //{
            //    Console.WriteLine(myIntArray[c]);
            //}

            //Console.WriteLine(myIntArray[1]);
            #endregion

            //var person = new { firstName = "Chris", lastName = "Newby" };
            //person = new { firstName = "Ronda", lastName = "Bergman" };

            dynamic myAnonArray = new[]
            {
                new { firstName = "Ronda", lastName = "Bergman", birthDate = Convert.ToDateTime("10/24") },
                new { firstName = "Q", lastName = "Allen", birthDate = Convert.ToDateTime("09/08") },
                new { firstName = "Ike", lastName = "HisName", birthDate = Convert.ToDateTime("01/01") }
            };

            Console.WriteLine(myAnonArray.GetType());

            Console.WriteLine(myAnonArray[0].lastName + ", " + myAnonArray[0].firstName + " " + myAnonArray[0].birthDate.ToShortDateString());

            Console.WriteLine(myAnonArray[1].lastName + ", " + myAnonArray[1].firstName);

            Console.ReadLine();

        }
    }
}
