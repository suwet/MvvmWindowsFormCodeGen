using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gencode.GenDAL;
using Gencode.GenModel;

namespace Gencode
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenClass.GenEditForm("TestConsumeGenCode.Views", "EditMUserForm", "MUserViewModel", "MUserService");
            if (args.Length >= 3)
            {
                switch(args[0])
                {
                    case "GenClass":
                        {
                            GenModel.GenModelsClass.GenClass(args[1], args[2]);
                            Console.WriteLine("Wrote file to Outputs directory");
                            break;
                        }
                    case "GenDal":
                        {
                            GenClass.GenDataAccessClass(args[1], args[2], args[3], args[4]);
                            Console.WriteLine("Wrote file to Outputs directory");
                            break;
                        }
                    case "GenMvvm":
                        {
                            GenModel.GenModelsClass.GenMvvmClass(args[1], args[2]);
                            Console.WriteLine("Wrote file to Outputs directory");
                            break;
                        }
                    case "GenService":
                        {
                            GenClass.GenServiceClass(args[1], args[2], args[3], args[4], args[5]);
                            Console.WriteLine("Wrote file to Outputs directory");
                            break;
                        }
                    case "GenUI":
                        {
                            GenClass.GenEditForm(args[1], args[2], args[3], args[4]);
                            Console.WriteLine("Wrote file to Outputs directory");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("How to use");
                Console.WriteLine("args[0]= command to run and other are paramters ,example: GenClass Demo.Models Load");

                Console.WriteLine("1. GenClass use for generate model and basemode ,parameter(nameSpace,className);");
                Console.WriteLine("      Example:GenClass(\"Demo.Models\",\"Load\")");
                Console.WriteLine("2. GenDal use for generate data acssess layer ,parameter(nameSpace,nameOfDalClass,<ReslutModel> from 1. ,tableName);");
                Console.WriteLine("     Example:  GenDal(\"Demo.Dal\", \"LoadDal\", \"Load\", \"Load\"));");
                Console.WriteLine("3. GenMvvm use for generate mvvm model ,parameter(nameSpace,nameOfMvvmClass");
                Console.WriteLine("     Example: GenMvvm(\"DemoMvvm\",\"LoadViewModel\")");
                Console.WriteLine("4. GenService use for generate service class  ,parameter(nameSpace,nameOfServiceClass,modelClassname,dalClassName", "viewModelClassName");
                Console.WriteLine("     Example:GenService(\"Demo.Services\", \"LoadService\", \"Load\", \"LoadDal\", \"LoadViewModel\")");
                Console.WriteLine("5. GenUI use for generate windows from ui design.cs and .cs   ,parameter(nameSpace,nameOfwindowsform,viewmodelname,servicename");
                Console.WriteLine("     Example: GenClass.GenEditForm(\"TestConsumeGenCode.Views\", \"EditMUserForm\", \"MUserViewModel\", \"MUserService\")");
            }
            /*
            GenModel.GenModelsClass.GenClass(args[0], args[1]);
            GenClass.GenDataAccessClass("Demo.Dal", "LoadDal", "Load", "Load");
            GenModel.GenModelsClass.GenMvvmClass("DemoMvvm","LoadViewModel");
            GenClass.GenServiceClass("Demo.Services", "LoadService", "Load", "LoadDal", "LoadViewModel");
            GenClass.GenEditForm("TestConsumeGenCode.Views", "EditMUserForm", "MUserViewModel", "MUserService");
            */
            //Console.ReadLine();
        }
    }
}
