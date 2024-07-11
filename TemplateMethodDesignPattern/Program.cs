using System;

namespace TemplateMethodDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BuildProject buildProject = new BuildProject();

            //Method Template for Design Pattern
            BuildProjectOnStaging obj = new BuildProjectOnStaging();
            obj.RunTest();
            Console.ReadKey();
        }
    }

    public class BuildProject
    {                
        public BuildProject()
        {
            CompileCode();
            RunTest();
            DeployCode();
        }
        
        public virtual void CompileCode()
        {
            Console.WriteLine("Code is Compiled!");
        }
     
        public virtual void RunTest()
        {
            Console.WriteLine("Run test succesfull");
        }
     
        public virtual void DeployCode()
        {
            Console.WriteLine("Deploy QE server ");
        }
    }

    public class BuildProjectOnStaging : BuildProject
    {
        public BuildProjectOnStaging(): base() 
        { }
        // suprascriere metodei RunTest din clasa de baza
        // Run-time polymorphism is also known as inheritance-based polymorphism or method overriding. 
        public override void RunTest()
        {
            Console.WriteLine("Running is here...");
        }
    }
}
