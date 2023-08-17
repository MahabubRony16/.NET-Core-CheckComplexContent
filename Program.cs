// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security;
using AutoMapper;
using CheckComplexContent.Models;

namespace CheckComplexContent
{
    static public class Program
    {
        static public readonly IMapper? _mapper;
        static void Main(string[] args)
        {
            AssignProperties();
        }
        static public void AssignProperties()
        {
            DetailInfo detInfo = new(){
                UserId = 12546,
                FirstName = "Mahabub",
                LastName = "Hasan",
                Email = "mahabub.hasan@gmail.com",
                Gender = "Male",
                JobTitle = "Sr. Mechanical Design Engineer",
                Department = "ENT-2",
                Salary = 45,
                Active = true
            };

            Console.WriteLine("Detain Information");
            Console.WriteLine(detInfo.UserId);
            Console.WriteLine(detInfo.FirstName);
            Console.WriteLine(detInfo.LastName);
            Console.WriteLine(detInfo.Email);
            Console.WriteLine(detInfo.Gender);
            Console.WriteLine(detInfo.JobTitle);
            Console.WriteLine(detInfo.Department);
            Console.WriteLine(detInfo.Salary);
            Console.WriteLine(detInfo.Active);


            List<DetailInfo> detInfoList = new()
            {
                detInfo
            };

            // IEnumerable<DetailInfo> detInfoIEn = detInfoList;




            IEnumerable<SummaryInfo> sumInfoList = detInfoList.Select(person => _mapper.Map<SummaryInfo>(person));
            
            // Console.WriteLine(sumInfoList.ToArray().Length);
            // foreach (SummaryInfo sumInfo in sumInfoList)
            // {
            //     Console.WriteLine(sumInfo.UserId);
                // Console.WriteLine(sumInfo.UserId);
                // Console.WriteLine(sumInfo.FirstName);
                // Console.WriteLine(sumInfo.LastName);
                // Console.WriteLine(sumInfo.Email);
                // // Console.WriteLine(sumInfo.Gender);
            // }

            
        }
    }
}
