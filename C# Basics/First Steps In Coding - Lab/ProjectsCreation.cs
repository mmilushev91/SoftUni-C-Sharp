using System;

namespace ProjectsCreation

{
  class Program
  
  {
    static void Main(string[] args)
    
    {
      const int timePerProject = 3;

      string name = Console.ReadLine();
      int projectsCount = int.Parse(Console.ReadLine());
      
      int timeNeeded = projectsCount * timePerProject;

      Console.WriteLine($"The architect {name} will need {timeNeeded} hours to complete {projectsCount} project/s.");    
    }
  }
}
