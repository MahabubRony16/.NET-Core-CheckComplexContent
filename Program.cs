// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security;
using AutoMapper;
using CheckComplexContent.Models;
using HelloWorld.Models;

namespace CheckComplexContent
{
    static public class Program
    {
        static public readonly IMapper? _mapper;
        static void Main(string[] args)
        {
            string computerJson = File.ReadAllText("ComputersSnake.json");
            // System.Console.WriteLine(computerJson);

            MapperConfiguration mapperConfig = new MapperConfiguration((cfg) => {
                cfg.CreateMap<ComputerSnake, Computer>()
                    .ForMember(destination => destination.ComputerId, options => 
                        options.MapFrom(source => source.computer_id))
                    .ForMember(destination => destination.CPUCores, options => 
                        options.MapFrom(source => source.cpu_cores))
                    .ForMember(destination => destination.HasLTE, options => 
                        options.MapFrom(source => source.has_lte))
                    .ForMember(destination => destination.HasWifi, options => 
                        options.MapFrom(source => source.has_wifi))
                    .ForMember(destination => destination.Motherboard, options => 
                        options.MapFrom(source => source.motherboard))
                    .ForMember(destination => destination.VideoCard, options => 
                        options.MapFrom(source => source.video_card))
                    .ForMember(destination => destination.ReleaseDate, options => 
                        options.MapFrom(source => source.release_date))
                    .ForMember(destination => destination.Price, options => 
                        options.MapFrom(source => source.price));
            });

            Mapper mapper = new Mapper(mapperConfig);
            IMapper iMapper = mapperConfig.CreateMapper();

            IEnumerable<ComputerSnake>?computersSnake = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<ComputerSnake>>(computerJson);

            // if (computersSnake != null)
            // {
            //     foreach (ComputerSnake computer in computersSnake)
            //     {
            //         // System.Console.WriteLine(computer.motherboard);
            //     }
            // }

            if (computersSnake != null)
            {
                IEnumerable<Computer> computers = iMapper.Map<IEnumerable<Computer>>(computersSnake);

                if (computers != null)
                {
                    foreach (Computer computer in computers)
                    {
                        System.Console.WriteLine(computer.Motherboard);
                    }
                }
            }


            // AssignProperties();

            
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

            Console.WriteLine("Detail Information --------------------------");
            Console.WriteLine(detInfo.UserId);
            Console.WriteLine(detInfo.FirstName);
            Console.WriteLine(detInfo.LastName);
            Console.WriteLine(detInfo.Email);
            Console.WriteLine(detInfo.Gender);
            Console.WriteLine(detInfo.JobTitle);
            Console.WriteLine(detInfo.Department);
            Console.WriteLine(detInfo.Salary);
            Console.WriteLine(detInfo.Active);

            MapperConfiguration mapperConfig = new MapperConfiguration(cfg => {
                    cfg.CreateMap<DetailInfo, SummaryInfo>()
                    .ForMember(destination => destination.User_Id, options => options.MapFrom(source => source.UserId));
                    });

            // Create an IMapper instance using the configuration
            IMapper iMapper = mapperConfig.CreateMapper();
            Mapper mapper = new Mapper(mapperConfig);

            SummaryInfo sumInfo = iMapper.Map<SummaryInfo>(detInfo);
            SummaryInfo sumInfo2 = mapper.Map<SummaryInfo>(detInfo);


            Console.WriteLine("Summary Information --------------------------");
            Console.WriteLine(sumInfo.User_Id);
            Console.WriteLine(sumInfo.FirstName);
            Console.WriteLine(sumInfo.LastName);
            Console.WriteLine(sumInfo.Email);

            
        }
    }
}
