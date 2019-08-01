using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic_Array_Of_Objects baoc = new Basic_Array_Of_Objects();
            // baoc.RunExercise();

            // Array_Of_Possibly_Null_Objects aopno = new Array_Of_Possibly_Null_Objects();
            // aopno.RunExercise();

            // Television_Definition td = new Television_Definition();
            // td.RunExercise();

            Objects_As_Parameters oap = new Objects_As_Parameters();
            oap.RunExercise();

            Objects_As_Return_Values oarp = new Objects_As_Return_Values();
            oarp.RunExercise();

            Objects_As_Parameters_And_Return_Values oasarv = new Objects_As_Parameters_And_Return_Values();
            oasarv.RunExercise();

            // Even though these are no longer part of this PCE they're being left here:
            BarChart_Demonstration bcd = new BarChart_Demonstration();
            bcd.RunExercise();

            TVStorage_Demonstration tvsd_d = new TVStorage_Demonstration();
            tvsd_d.RunExercise();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class Basic_Array_Of_Objects
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfTVs();
        }
    }

    // This is the "user interface" for the Objects-As-Parameters exercise
    public class TelevisionHandler
    {
        public void PrintArrayOfTVs()
        {
            //  Console.WriteLine("You need to implement this!!");
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            // Console.WriteLine("You need to implement this!!");
        }

        public void PrintMyTV(Television theTV)
        {
            if (theTV == null)
                Console.WriteLine("Nothing...");
            if (theTV != null)
                theTV.Print();

        }

        public void PrintMyTVUsingGetters(Television theTV)
        {
            if (theTV == null)
                Console.WriteLine("Nothing...");
            else
            {
                theTV.SetBrand("Sony");
                string brand = theTV.GetBrand();
                theTV.SetPrice(1000.17m);
                decimal price = theTV.GetPrice();
                theTV.SetSize(10.5);
                double size = theTV.GetSize();
                Console.WriteLine("The TV's Brand is: {0}, which is rad.", brand);
                Console.WriteLine("The TV's Price is: {0}, which is really rad.", price);
                Console.WriteLine("The TV's Size is: {0}, which is wicked rad.", size);
            }

        }

        public Television CreateATV()
        {
            Television aTV = new Television("Brand X", 10.0m, 42.0);
            aTV.Print();
            return aTV; // note that you can do this
            // note that this is NOT what you should do for this exercise! :)
        }

        public Television CreateATVFromUserInput()
        {
            decimal d;
            double n;
            Console.WriteLine("Enter Brand: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            Decimal.TryParse(Console.ReadLine(), out d);
            Console.WriteLine("Enter Size: ");
            Double.TryParse(Console.ReadLine(), out n);
            Television userTV = new Television();
            userTV.Print(s, d, n);
            return userTV;

        }


        public Television PickMoreExpensiveTV(Television t1, Television t2)
        {
            if (t1.GetPrice() > t2.GetPrice())
                return t1;
            else if (t2.GetPrice() > t1.GetPrice())
                return t2;
            else if (t1.GetPrice() == t2.GetPrice())
                return t1;
            if (t1 == null && t2 != null)
                return t2;
            else if (t1 != null && t2 == null)
                return t1;
            else if (t1 == null && t2 == null)
                return null;
            else
                return null;


        }
    }

    /////////////////////////////////////////////////////////////////////////////////


    class Array_Of_Possibly_Null_Objects
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfPossiblyNullTVs();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class Television_Definition
    {
        public void RunExercise()
        {
        }
    }

    // We need a class to pass as a parameter for this exercises, so
    // we've whipped up the 'Television' class
    public class Television
    {
        private string brand;
        private decimal price;
        private double size;
        public Television()
        {
            price = 0;
            size = 0;
            brand = " ";
        }
        public Television(string br, decimal pr, double si)
        {
            if (brand != null)
                brand = br;
            else
                brand = br;
            if (0 < pr)
                price = pr;
            else
                price = 0m;
            if (0 < si)
                size = si;
            else
                size = 0.0;
        }

        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string newBrand)
        {
            if (newBrand != null)
                brand = newBrand;
            else if (newBrand == null)
                brand = newBrand;
        }
        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(decimal newPrice)
        {
            if (0 < newPrice)
                price = newPrice;
            else
                price = 0;
        }
        public double GetSize()
        {
            return size;
        }
        public void SetSize(double newSize)
        {
            if (0 < newSize)
                size = newSize;
            else
                size = 0;
        }
        public void Print()
        {
            Console.WriteLine("Brand: {0}", brand);
            Console.WriteLine("Price: {0:0.00}", price);
            Console.WriteLine("Size: {0:0.00}", size);
        }
        public void Print(string br, decimal pr, double si)
        {
            Console.WriteLine("Brand: " + br);
            Console.WriteLine("Price: " + pr);
            Console.WriteLine("Size: " + si);
        }
    }

    class Objects_As_Parameters
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();

            Television tv = new Television("Sony", 2000.0m, 50);

            Console.WriteLine("Printing using the Print method: ");
            tvh.PrintMyTV(tv);

            Console.WriteLine("Printing using getters: ");
            tvh.PrintMyTVUsingGetters(tv);
        }
    }


    /////////////////////////////////////////////////////////////////////////////////

    class Objects_As_Return_Values
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();

            Television tv1;

            tv1 = tvh.CreateATV();
            tv1 = tvh.CreateATVFromUserInput();

        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    class Objects_As_Parameters_And_Return_Values
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();
            Television firstTV = new Television("Samsung", 2.0m, 10.5);
            Television secondTV = new Television("Westinghouse", 10.5m, 42);
            //firstTV = tvh.CreateATV();
            //secondTV = tvh.CreateATVFromUserInput();

            Television moreExpensiveTV;

            moreExpensiveTV = tvh.PickMoreExpensiveTV(firstTV, secondTV);

            firstTV.Print();
            secondTV.Print();

            Console.WriteLine("The more expensive TV is: ");
            tvh.PrintMyTV(moreExpensiveTV);

        }
    }

    // Even though these are no longer part of this PCE they're being left here:

    /////////////////////////////////////////////////////////////////////////////////

    public class BarChart
    {
        int[] m_numbers;

        public BarChart()
        {
            m_numbers = new int[5];
        }

        public int GetSize()
        {
            return m_numbers.Length;
        }

        public void SetValue(int newVal, int idx)
        {
            if (idx >= 0 && idx < m_numbers.Length)
                m_numbers[idx] = newVal;

            // Interesting point: note the silent failure
            // if idx is out of range
        }

        public int GetValue(int idx)
        {
            if (idx >= 0 && idx < m_numbers.Length)
                return m_numbers[idx];

            // Is this a good value to return here?
            return 0;
            // zero is fine, i just like your point of returning a value that you don't 
            //expect will mess with the program
        }

        public double GetAverage()
        {
            double sum = 0;
            for (int i = 0; i < m_numbers.Length; i++)
            {
                sum = sum + m_numbers[i];
            }
            return sum / m_numbers.Length;
        }

        public void PrintBarChart()
        {
            for (int i = 0; i < m_numbers.Length; i++)
            {
                double star;
                star = m_numbers[i];

                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }

    public class BarChart_Demonstration
    {
        public void RunExercise()
        {
            BarChart h1 = new BarChart();
            BarChart h2 = new BarChart();

            for (int i = 0; i < 5; i++)
            {
                h1.SetValue((i + 1) * 2, i);
                h2.SetValue(10 - i, i);
            }


            Console.WriteLine("Data set 1 (Version 1): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // What if the first two values were different?
            h1.SetValue(5, 0);
            h1.SetValue(7, 1);

            Console.WriteLine("Data set 1 (Version 2): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // Wait, hold on - I got those backwards :)
            h1.SetValue(7, 0);
            h1.SetValue(5, 1);

            Console.WriteLine("Data set 1 (Version 3): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // I just got some new data - let me adjust the first value:
            h1.SetValue(9, 0);

            Console.WriteLine("Data set 1 (Version 4): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // How do the two data sets compare?
            Console.WriteLine("Data set 1 (Version 4): Avg: {0:0.00}", h1.GetAverage());
            Console.WriteLine("Data set 2 (Version 1): Avg: {0:0.00}", h2.GetAverage());

            Console.WriteLine("\nData set 1:");
            h1.PrintBarChart();
            Console.WriteLine("\nData set 2:");
            h2.PrintBarChart();
            Console.WriteLine();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class TVStorage
    {
        Television[] tvs = new Television[5];

        public TVStorage()
        {
        }

        // TODO: Implement this method!
        // If the location is invalid (negative, or too large) do nothing.
        // If the parameter is null (and the location is ok), then replace
        //      the object reference in the array with null
        public void StoreTV(int iLocation, Television tvToStore)
        {
            if (tvs[iLocation] == null)
                tvs[iLocation] = tvToStore;

        }

        // TODO: Implement this method!
        // If the location is invalid (negative, or too large) return null.
        public Television GetTV(int iLocation)
        {
            if (tvs[iLocation] == null)
                return null;
            else
                return tvs[iLocation]; 

         }

        // TODO: Implement this method!
        // If a given slot in the array is non-NULL, then call .Print on it
        // otherwise, print out "Slot X is null", where X is the slot index.
        public void PrintAllTVs()
        {
            for (int i = 0; i < tvs.Length; i++)
            {
                if (tvs[i] == null)
                    Console.WriteLine("Slot {0} is null", i);
                else
                    tvs[i].Print();
            }


        }

    }

    public class TVStorage_Demonstration
    {
        public void RunExercise()
        {
            TVStorage tvs = new TVStorage();
            tvs.PrintAllTVs();

            Television t = new Television("Brand X", 1000, 42);
            tvs.StoreTV(2, t);
            tvs.StoreTV(4, new Television("Brand Y", 2000, 52));

            Television t2 = tvs.GetTV(0);
            Console.WriteLine("Is t2 null? (It should be) {0}", t2 == null);

            tvs.PrintAllTVs();

            t2 = tvs.GetTV(2);
            Console.WriteLine("Is t2 the same as t? (It should be) {0}", t2 == t);

        }
    }
}
