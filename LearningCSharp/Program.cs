using System;

namespace LearningCSharp
{
    partial class Program
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }

            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                var video = new Video() { Title = "Video 1" };
                var videoEncoder = new VideoEncoder(); // publisher
                var mailService = new MailService(); //subscriber
                var messageService = new MessageService(); //subscriber

                videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
                videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
                videoEncoder.Encode(video);

                // var person = Person.Parse("PC");
                // person.Introduce("Tsai");
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
        }
    }
}
