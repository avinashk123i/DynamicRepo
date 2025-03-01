using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DesignProject.TaskUnderstanding
{
    public class TestTask
    {

        public async Task<string> GetValues()
        {
           //Task.Delay(10000);
            return await Task.FromResult("Random string");
        }

        public async Task<string> GetValues2()
        {
            await Task.Delay(10000);
            return await Task.FromResult("Random string2");
        }


        public void GetValues3()
        {
            Thread.Sleep(10000);
            Console.WriteLine("synchorized blocking");
        }


      


        public void GetResult()
        {
            var result = GetIterator();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }


        }

        public IEnumerable<int> GetIterator()
        {

            for (int i = 0; i < 5; i++)
            {
                yield return i;
            }


        }


            public  async Task Awaitable()
            {
                Task<int> downloading = DownloadDocsMainPageAsync();
                Console.WriteLine($"{nameof(Awaitable)}: Launched downloading.");

                int bytesLoaded =   await downloading;
                Console.WriteLine($"{nameof(Awaitable)}: Downloaded {bytesLoaded} bytes.");
            }


            private async Task<int> DownloadDocsMainPageAsync()
            {
                Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

//                var client = new HttpClient();
//                byte[] content = await client.GetByteArrayAsync("https://learn.microsoft.com/en-us/");

                Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading.");
                return 0;
            }




        public void Mains()
        {
            double radiusValue = 3.92781;

            //Calculate the circumference and area of a circle, returning the results to Main().
            CalculateCircumferenceAndArea(radiusValue, out double circumferenceResult, out var areaResult);
            System.Console.WriteLine($"Circumference of a circle with a radius of {radiusValue} is {circumferenceResult}.");
            System.Console.WriteLine($"Area of a circle with a radius of {radiusValue} is {areaResult}.");
            Console.ReadLine();
        }

        //The calculation worker method.
        public static void CalculateCircumferenceAndArea(double radius, out double circumference, out double area)
        {
            circumference = 2 * Math.PI * radius;
            area = Math.PI * (radius * radius);
        }
    }

    
}
