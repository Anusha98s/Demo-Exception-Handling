using System;

namespace Demo_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("enter your fav No");
                //string No = Console.ReadLine();
                //Int32.Parse(No);

                //Console.WriteLine("No you entered {0}. valid Integer32",No);
                throw new StudentNotFoundException("Student Not Found", "Anusha");

            }
            catch (StudentNotFoundException s)
            {
                Console.WriteLine("student not found exception caught\n" + s.StudentName);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid Integer Number",fe.Message);

                throw;
                throw new StudentNotFoundException("Student Not Found ", "Anusha");
            }
            catch(OverflowException)
            {
                OverflowException a = new OverflowException();
                Console.WriteLine("value you entered is too big to fit in Int32",a.Source);
            }
            //catch (Exception)
            //{
               // Console.WriteLine("some global exception has occured and we are working on it........!");
            //}
            finally
            {
                Console.WriteLine("Hope this object oriented way of programming language");

            }
            Console.WriteLine(".............................!!!!!");
        }
    }
}
